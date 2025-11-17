using MaterialSkin;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSFinapp.Business.Services;
using SSFinapp.Data;
using SSFinapp.Data.Repositories;
using SSFinapp.UI.Forms;
using SSFinapp.UI.Helpers;
using System.Windows.Forms;

namespace SSFinapp.UI;

static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    
    public static T? GetService<T>() => ServiceProvider != null 
        ? (T?)ServiceProvider.GetService(typeof(T)) 
        : default;
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();
            
            // Dependency Injection yapılandırması
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            
            // Veritabanını oluştur/güncelle
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
            }
            
            // Tema ayarını yükle ve uygula
            var theme = ThemeHelper.LoadTheme();
            ThemeHelper.ApplyThemeToAllForms(theme);
            
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Uygulama başlatılırken hata oluştu:\n\n{ex.Message}\n\nDetay:\n{ex.StackTrace}", 
                "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private static void ConfigureServices(ServiceCollection services)
    {
        // DbContext
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=ssfinapp.db"));
        
        // Repositories
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IStockTransactionRepository, StockTransactionRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICurrentAccountTransactionRepository, CurrentAccountTransactionRepository>();
        services.AddScoped<ICashAccountRepository, CashAccountRepository>();
        services.AddScoped<ICashTransactionRepository, CashTransactionRepository>();
        
        // Unit of Work
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        // Services
        services.AddScoped<IStockService, StockService>();
        services.AddScoped<ICurrentAccountService, CurrentAccountService>();
        services.AddScoped<ICashService, CashService>();
        services.AddScoped<IExportService, ExportService>();
        services.AddScoped<IBackupService, BackupService>();
        
        // Forms
        services.AddTransient<MainForm>();
        services.AddTransient<ProductManagementForm>();
        services.AddTransient<ProductEditForm>();
        services.AddTransient<StockTransactionForm>();
        services.AddTransient<StockTransactionEditForm>();
        services.AddTransient<CustomerManagementForm>();
        services.AddTransient<CustomerEditForm>();
        services.AddTransient<CurrentAccountForm>();
        services.AddTransient<CurrentAccountTransactionEditForm>();
        services.AddTransient<CashManagementForm>();
        services.AddTransient<CashTransactionEditForm>();
        services.AddTransient<SettingsForm>();
    }
}