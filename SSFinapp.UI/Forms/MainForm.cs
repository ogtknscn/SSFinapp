using SSFinapp.Business.Services;
using SSFinapp.UI.Forms;

namespace SSFinapp.UI;

/// <summary>
/// Ana form - Dashboard
/// </summary>
public partial class MainForm : Form
{
    private readonly IStockService _stockService;
    private readonly ICurrentAccountService _currentAccountService;
    
    public MainForm(IStockService stockService, ICurrentAccountService currentAccountService)
    {
        _stockService = stockService;
        _currentAccountService = currentAccountService;
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
}

