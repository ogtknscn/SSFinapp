using MaterialSkin.Controls;
using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.UI.Helpers;

namespace SSFinapp.UI.Forms;

/// <summary>
/// Ürün yönetimi formu
/// </summary>
public partial class ProductManagementForm : MaterialForm
{
    private readonly IStockService _stockService;
    private readonly IExportService _exportService;
    
    public ProductManagementForm(IStockService stockService, IExportService exportService)
    {
        _stockService = stockService;
        _exportService = exportService;
        InitializeComponent();
        LoadProducts();
        SetupKeyboardShortcuts();
    }
    
    private void SetupKeyboardShortcuts()
    {
        KeyboardHelper.SetupKeyboardShortcuts(
            this,
            onInsert: () => btnAdd_Click(btnAdd, EventArgs.Empty), // INS: Yeni ürün ekle
            onDelete: () => btnDelete_Click(btnDelete, EventArgs.Empty), // DEL: Seçili ürünü sil
            onF5: () => btnRefresh_Click(btnRefresh, EventArgs.Empty), // F5: Yenile
            onF3: () => txtSearch.Focus(), // F3: Arama kutusuna odaklan
            onEscape: () => btnClose_Click(btnClose, EventArgs.Empty) // ESC: Kapat
        );
    }
    
    private async void LoadProducts()
    {
        try
        {
            var products = await _stockService.GetAllProductsAsync();
            dgvProducts.DataSource = products.ToList();
            
            // Kolon başlıklarını Türkçeleştir
            if (dgvProducts.Columns.Count > 0)
            {
                dgvProducts.Columns["Id"].HeaderText = "ID";
                dgvProducts.Columns["Ad"].HeaderText = "Ürün Adı";
                dgvProducts.Columns["Birim"].HeaderText = "Birim";
                dgvProducts.Columns["Aktif"].HeaderText = "Aktif";
                dgvProducts.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma Tarihi";
                
                // Navigation property'yi gizle
                if (dgvProducts.Columns.Contains("StokHareketleri"))
                    dgvProducts.Columns["StokHareketleri"].Visible = false;
            }
            
            lblTotalCount.Text = $"Toplam: {products.Count()} ürün";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürünler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = Program.ServiceProvider?.GetService(typeof(ProductEditForm)) as ProductEditForm;
        if (form != null && form.ShowDialog() == DialogResult.OK)
        {
            LoadProducts();
        }
    }
    
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen düzenlemek için bir ürün seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
        if (selectedProduct != null)
        {
            var form = Program.ServiceProvider?.GetService(typeof(ProductEditForm)) as ProductEditForm;
            if (form != null)
            {
                form.LoadProduct(selectedProduct.Id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }
    }
    
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
        if (selectedProduct != null)
        {
            var result = MessageBox.Show(
                $"'{selectedProduct.Ad}' ürününü silmek istediğinizden emin misiniz?",
                "Ürün Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _stockService.DeleteProductAsync(selectedProduct.Id);
                    MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün silinirken hata: {ex.Message}", "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadProducts();
    }
    
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (dgvProducts.DataSource is List<Product> products)
        {
            var searchText = txtSearch.Text.ToLower();
            var filtered = products.Where(p => 
                p.Ad.ToLower().Contains(searchText) ||
                p.Birim.ToLower().Contains(searchText)
            ).ToList();
            
            dgvProducts.DataSource = filtered;
            lblTotalCount.Text = $"Gösterilen: {filtered.Count} / Toplam: {products.Count} ürün";
        }
    }
    
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    
    private async void btnExport_Click(object sender, EventArgs e)
    {
        using var saveDialog = new SaveFileDialog
        {
            Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
            FileName = $"Urunler_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
            Title = "Excel'e Aktar"
        };
        
        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
            await UIHelper.ExecuteWithLoadingAsync(this, async () =>
            {
                await _exportService.ExportProductsToExcelAsync(saveDialog.FileName);
                UIHelper.ShowSuccess($"Ürünler başarıyla Excel'e aktarıldı!\n\nDosya: {saveDialog.FileName}");
                
                // Dosyayı aç
                if (UIHelper.ConfirmAction("Dosyayı şimdi açmak ister misiniz?"))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = saveDialog.FileName,
                        UseShellExecute = true
                    });
                }
            });
        }
    }
    
    private async void btnViewStock_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen stok bilgisini görmek için bir ürün seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
        if (selectedProduct != null)
        {
            try
            {
                var stockLevel = await _stockService.GetCurrentStockLevelAsync(selectedProduct.Id);
                MessageBox.Show(
                    $"Ürün: {selectedProduct.Ad}\n" +
                    $"Mevcut Stok: {stockLevel} {selectedProduct.Birim}",
                    "Stok Bilgisi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok bilgisi alınırken hata: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

