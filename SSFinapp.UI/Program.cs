using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSFinapp.Business.Services;
using SSFinapp.Data;
using SSFinapp.Data.Repositories;
using SSFinapp.UI.Forms;

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
        
        Application.Run(ServiceProvider.GetRequiredService<MainForm>());
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
        
        // Unit of Work
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        // Services
        services.AddScoped<IStockService, StockService>();
        services.AddScoped<ICurrentAccountService, CurrentAccountService>();
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
    }
}