using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;

namespace SSFinapp.UI.Forms;

/// <summary>
/// Stok hareketi yönetimi formu
/// </summary>
public partial class StockTransactionForm : Form
{
    private readonly IStockService _stockService;
    private List<StockTransaction> _allTransactions = new();
    
    public StockTransactionForm(IStockService stockService)
    {
        _stockService = stockService;
        InitializeComponent();
        LoadData();
    }
    
    private async void LoadData()
    {
        await LoadTransactions();
        await LoadProductsForFilter();
    }
    
    private async Task LoadTransactions()
    {
        try
        {
            var transactions = await _stockService.GetAllTransactionsAsync();
            _allTransactions = transactions.OrderByDescending(t => t.Tarih).ToList();
            
            dgvTransactions.DataSource = _allTransactions;
            
            // Kolon başlıklarını Türkçeleştir
            if (dgvTransactions.Columns.Count > 0)
            {
                dgvTransactions.Columns["Id"].HeaderText = "ID";
                dgvTransactions.Columns["Tarih"].HeaderText = "Tarih";
                dgvTransactions.Columns["IslemTipi"].HeaderText = "İşlem Tipi";
                dgvTransactions.Columns["UrunId"].HeaderText = "Ürün ID";
                dgvTransactions.Columns["Miktar"].HeaderText = "Miktar";
                dgvTransactions.Columns["Birim"].HeaderText = "Birim";
                dgvTransactions.Columns["Aciklama"].HeaderText = "Açıklama";
                dgvTransactions.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma Tarihi";
                
                // Navigation property'yi gizle
                if (dgvTransactions.Columns.Contains("Urun"))
                    dgvTransactions.Columns["Urun"].Visible = false;
                    
                // Tarih formatı
                dgvTransactions.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvTransactions.Columns["OlusturmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                
                // Miktar formatı
                dgvTransactions.Columns["Miktar"].DefaultCellStyle.Format = "N2";
            }
            
            lblTotalCount.Text = $"Toplam: {_allTransactions.Count} işlem";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlemler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async Task LoadProductsForFilter()
    {
        try
        {
            var products = await _stockService.GetAllProductsAsync();
            cmbProductFilter.Items.Clear();
            cmbProductFilter.Items.Add("Tüm Ürünler");
            
            foreach (var product in products.OrderBy(p => p.Ad))
            {
                cmbProductFilter.Items.Add($"{product.Id} - {product.Ad}");
            }
            
            cmbProductFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürünler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<StockTransactionEditForm>();
        if (form != null && form.ShowDialog() == DialogResult.OK)
        {
            LoadTransactions();
        }
    }
    
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvTransactions.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen düzenlemek için bir işlem seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as StockTransaction;
        if (selectedTransaction != null)
        {
            var form = Program.GetService<StockTransactionEditForm>();
            if (form != null)
            {
                form.LoadTransaction(selectedTransaction.Id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadTransactions();
                }
            }
        }
    }
    
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvTransactions.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen silmek için bir işlem seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as StockTransaction;
        if (selectedTransaction != null)
        {
            var result = MessageBox.Show(
                $"Bu işlemi silmek istediğinizden emin misiniz?\n\n" +
                $"İşlem: {selectedTransaction.IslemTipi}\n" +
                $"Miktar: {selectedTransaction.Miktar} {selectedTransaction.Birim}\n" +
                $"Tarih: {selectedTransaction.Tarih:dd.MM.yyyy HH:mm}",
                "İşlem Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _stockService.DeleteTransactionAsync(selectedTransaction.Id);
                    MessageBox.Show("İşlem başarıyla silindi.", "Başarılı", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadTransactions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"İşlem silinirken hata: {ex.Message}", "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadTransactions();
    }
    
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    
    private void cmbProductFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }
    
    private void cmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }
    
    private void ApplyFilters()
    {
        var filtered = _allTransactions.AsEnumerable();
        
        // Ürün filtresi
        if (cmbProductFilter.SelectedIndex > 0)
        {
            var selectedText = cmbProductFilter.SelectedItem?.ToString() ?? "";
            if (int.TryParse(selectedText.Split('-')[0].Trim(), out int productId))
            {
                filtered = filtered.Where(t => t.UrunId == productId);
            }
        }
        
        // İşlem tipi filtresi
        if (cmbTypeFilter.SelectedIndex == 1) // Giriş
        {
            filtered = filtered.Where(t => t.IslemTipi == TransactionType.Giris);
        }
        else if (cmbTypeFilter.SelectedIndex == 2) // Çıkış
        {
            filtered = filtered.Where(t => t.IslemTipi == TransactionType.Cikis);
        }
        
        var result = filtered.ToList();
        dgvTransactions.DataSource = result;
        lblTotalCount.Text = $"Gösterilen: {result.Count} / Toplam: {_allTransactions.Count} işlem";
    }
}

