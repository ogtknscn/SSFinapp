using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;

namespace SSFinapp.UI.Forms;

/// <summary>
/// Ürün ekleme/düzenleme formu
/// </summary>
public partial class ProductEditForm : Form
{
    private readonly IStockService _stockService;
    private int? _productId;
    
    public ProductEditForm(IStockService stockService)
    {
        _stockService = stockService;
        InitializeComponent();
        InitializeBirimComboBox();
    }
    
    private void InitializeBirimComboBox()
    {
        cmbBirim.Items.AddRange(new object[]
        {
            "Adet",
            "kg",
            "m³",
            "m²",
            "m",
            "lt",
            "ton",
            "paket",
            "kutu",
            "koli"
        });
        cmbBirim.SelectedIndex = 0;
    }
    
    public async void LoadProduct(int productId)
    {
        try
        {
            _productId = productId;
            var product = await _stockService.GetProductByIdAsync(productId);
            
            if (product != null)
            {
                txtAd.Text = product.Ad;
                cmbBirim.Text = product.Birim;
                chkAktif.Checked = product.Aktif;
                
                lblTitle.Text = "Ürün Düzenle";
                this.Text = "Ürün Düzenle";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürün yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async void btnSave_Click(object sender, EventArgs e)
    {
        // Validasyon
        if (string.IsNullOrWhiteSpace(txtAd.Text))
        {
            MessageBox.Show("Ürün adı boş olamaz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAd.Focus();
            return;
        }
        
        if (string.IsNullOrWhiteSpace(cmbBirim.Text))
        {
            MessageBox.Show("Birim seçiniz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbBirim.Focus();
            return;
        }
        
        try
        {
            if (_productId.HasValue)
            {
                // Güncelleme
                var product = await _stockService.GetProductByIdAsync(_productId.Value);
                if (product != null)
                {
                    product.Ad = txtAd.Text.Trim();
                    product.Birim = cmbBirim.Text.Trim();
                    product.Aktif = chkAktif.Checked;
                    
                    await _stockService.UpdateProductAsync(product);
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Yeni ekleme
                var product = new Product
                {
                    Ad = txtAd.Text.Trim(),
                    Birim = cmbBirim.Text.Trim(),
                    Aktif = chkAktif.Checked
                };
                
                await _stockService.AddProductAsync(product);
                MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürün kaydedilirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

