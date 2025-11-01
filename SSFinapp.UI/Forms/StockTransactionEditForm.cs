using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;

namespace SSFinapp.UI.Forms;

/// <summary>
/// Stok işlemi ekleme/düzenleme formu
/// </summary>
public partial class StockTransactionEditForm : Form
{
    private readonly IStockService _stockService;
    private int? _transactionId;
    
    public StockTransactionEditForm(IStockService stockService)
    {
        _stockService = stockService;
        InitializeComponent();
        LoadProducts();
    }
    
    private async void LoadProducts()
    {
        try
        {
            var products = await _stockService.GetActiveProductsAsync();
            cmbProduct.Items.Clear();
            
            foreach (var product in products.OrderBy(p => p.Ad))
            {
                cmbProduct.Items.Add(new ComboBoxItem 
                { 
                    Value = product.Id, 
                    Text = $"{product.Ad} ({product.Birim})",
                    Tag = product.Birim
                });
            }
            
            if (cmbProduct.Items.Count > 0)
                cmbProduct.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürünler yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    public async void LoadTransaction(int transactionId)
    {
        try
        {
            _transactionId = transactionId;
            var transaction = await _stockService.GetAllTransactionsAsync();
            var trans = transaction.FirstOrDefault(t => t.Id == transactionId);
            
            if (trans != null)
            {
                dtpTarih.Value = trans.Tarih;
                
                // Ürünü seç
                for (int i = 0; i < cmbProduct.Items.Count; i++)
                {
                    var item = (ComboBoxItem)cmbProduct.Items[i];
                    if (item.Value == trans.UrunId)
                    {
                        cmbProduct.SelectedIndex = i;
                        break;
                    }
                }
                
                rdbGiris.Checked = trans.IslemTipi == TransactionType.Giris;
                rdbCikis.Checked = trans.IslemTipi == TransactionType.Cikis;
                
                numMiktar.Value = trans.Miktar;
                txtAciklama.Text = trans.Aciklama;
                
                lblTitle.Text = "Stok İşlemi Düzenle";
                this.Text = "Stok İşlemi Düzenle";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlem yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbProduct.SelectedItem is ComboBoxItem item)
        {
            lblBirim.Text = $"Birim: {item.Tag}";
        }
    }
    
    private async void btnSave_Click(object sender, EventArgs e)
    {
        // Validasyon
        if (cmbProduct.SelectedItem == null)
        {
            MessageBox.Show("Ürün seçiniz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbProduct.Focus();
            return;
        }
        
        if (numMiktar.Value <= 0)
        {
            MessageBox.Show("Miktar 0'dan büyük olmalıdır!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numMiktar.Focus();
            return;
        }
        
        try
        {
            var selectedProduct = (ComboBoxItem)cmbProduct.SelectedItem;
            
            if (_transactionId.HasValue)
            {
                // Güncelleme
                var transactions = await _stockService.GetAllTransactionsAsync();
                var transaction = transactions.FirstOrDefault(t => t.Id == _transactionId.Value);
                
                if (transaction != null)
                {
                    transaction.Tarih = dtpTarih.Value;
                    transaction.IslemTipi = rdbGiris.Checked ? TransactionType.Giris : TransactionType.Cikis;
                    transaction.UrunId = selectedProduct.Value;
                    transaction.Miktar = numMiktar.Value;
                    transaction.Birim = selectedProduct.Tag?.ToString() ?? "";
                    transaction.Aciklama = txtAciklama.Text.Trim();
                    
                    await _stockService.UpdateTransactionAsync(transaction);
                    MessageBox.Show("İşlem başarıyla güncellendi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Yeni ekleme
                var transaction = new StockTransaction
                {
                    Tarih = dtpTarih.Value,
                    IslemTipi = rdbGiris.Checked ? TransactionType.Giris : TransactionType.Cikis,
                    UrunId = selectedProduct.Value,
                    Miktar = numMiktar.Value,
                    Birim = selectedProduct.Tag?.ToString() ?? "",
                    Aciklama = txtAciklama.Text.Trim()
                };
                
                await _stockService.AddTransactionAsync(transaction);
                MessageBox.Show("İşlem başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlem kaydedilirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
    
    // Helper class
    private class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; } = "";
        public object? Tag { get; set; }
        
        public override string ToString() => Text;
    }
}

