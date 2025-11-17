using MaterialSkin;
using MaterialSkin.Controls;
using SSFinapp.Business.Services;
using SSFinapp.UI.Forms;

namespace SSFinapp.UI;

/// <summary>
/// Ana form - Dashboard
/// </summary>
public partial class MainForm : MaterialForm
{
    private readonly IStockService _stockService;
    private readonly ICurrentAccountService _currentAccountService;
    private readonly ICashService _cashService;
    
    public MainForm(IStockService stockService, ICurrentAccountService currentAccountService, ICashService cashService)
    {
        _stockService = stockService;
        _currentAccountService = currentAccountService;
        _cashService = cashService;
        InitializeComponent();
        LoadDashboard();
    }
    
    private async void LoadDashboard()
    {
        try
        {
            // Dashboard verilerini yükle
            var productCount = (await _stockService.GetAllProductsAsync()).Count();
            var customerCount = (await _currentAccountService.GetAllCustomersAsync()).Count();
            
            lblProductCount.Text = $"Toplam Ürün: {productCount}";
            lblCustomerCount.Text = $"Toplam Müşteri: {customerCount}";
            
            // Widget verilerini yükle
            var totalCollections = await _currentAccountService.GetTotalCollectionsThisMonthAsync();
            var overdueCount = await _currentAccountService.GetOverdueReceivablesCountAsync();
            var totalOverdue = await _currentAccountService.GetTotalOverdueReceivablesAsync();
            var criticalStockCount = await _stockService.GetCriticalStockCountAsync(10);
            
            lblWidgetCollections.Text = totalCollections.ToString("N2") + " ₺";
            lblWidgetOverdue.Text = $"{overdueCount} Müşteri\n{totalOverdue:N2} ₺";
            lblWidgetCriticalStock.Text = criticalStockCount.ToString() + " Ürün";
            
            // Kasa bakiyelerini yükle
            var cashBalances = await _cashService.GetAllCashAccountBalancesAsync();
            var totalCash = cashBalances.Values.Sum();
            lblWidgetCash.Text = totalCash.ToString("N2") + " ₺";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnStockManagement_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<StockTransactionForm>();
        form?.ShowDialog();
        LoadDashboard();
    }
    
    private void btnCurrentAccount_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CurrentAccountForm>();
        form?.ShowDialog();
        LoadDashboard();
    }
    
    private void btnProducts_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<ProductManagementForm>();
        form?.ShowDialog();
        LoadDashboard();
    }
    
    private void btnCustomers_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CustomerManagementForm>();
        form?.ShowDialog();
        LoadDashboard();
    }
    
    private void btnSettings_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<SettingsForm>();
        form?.ShowDialog();
    }
    
    private void btnCashManagement_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CashManagementForm>();
        form?.ShowDialog();
        LoadDashboard();
    }
}

