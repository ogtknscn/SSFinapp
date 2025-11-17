using MaterialSkin.Controls;
using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;
using SSFinapp.UI.Helpers;

namespace SSFinapp.UI.Forms;

public partial class CashManagementForm : MaterialForm
{
    private readonly ICashService _cashService;
    private List<CashTransaction> _allTransactions = new();
    
    public CashManagementForm(ICashService cashService)
    {
        _cashService = cashService;
        InitializeComponent();
        LoadData();
        SetupKeyboardShortcuts();
    }
    
    private void SetupKeyboardShortcuts()
    {
        KeyboardHelper.SetupKeyboardShortcuts(
            this,
            onInsert: () => btnAdd_Click(btnAdd, EventArgs.Empty), // INS: Yeni işlem ekle
            onDelete: () => btnDelete_Click(btnDelete, EventArgs.Empty), // DEL: Seçili işlemi sil
            onF5: () => btnRefresh_Click(btnRefresh, EventArgs.Empty), // F5: Yenile
            onEscape: () => btnClose_Click(btnClose, EventArgs.Empty) // ESC: Kapat
        );
    }
    
    private async void LoadData()
    {
        await LoadTransactions();
        await LoadCashAccountsForFilter();
    }
    
    private async Task LoadTransactions()
    {
        try
        {
            var transactions = await _cashService.GetAllTransactionsAsync();
            _allTransactions = transactions.OrderByDescending(t => t.Tarih).ToList();
            
            dgvTransactions.DataSource = _allTransactions;
            
            if (dgvTransactions.Columns.Count > 0)
            {
                dgvTransactions.Columns["Id"].HeaderText = "ID";
                dgvTransactions.Columns["KasaId"].HeaderText = "Kasa ID";
                dgvTransactions.Columns["Tarih"].HeaderText = "Tarih";
                dgvTransactions.Columns["IslemTipi"].HeaderText = "İşlem Tipi";
                dgvTransactions.Columns["Tutar"].HeaderText = "Tutar";
                dgvTransactions.Columns["Aciklama"].HeaderText = "Açıklama";
                dgvTransactions.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma Tarihi";
                
                if (dgvTransactions.Columns.Contains("Kasa"))
                    dgvTransactions.Columns["Kasa"].Visible = false;
                if (dgvTransactions.Columns.Contains("HedefHesapId"))
                    dgvTransactions.Columns["HedefHesapId"].Visible = false;
                if (dgvTransactions.Columns.Contains("HedefHesapTipi"))
                    dgvTransactions.Columns["HedefHesapTipi"].Visible = false;
                    
                dgvTransactions.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvTransactions.Columns["OlusturmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvTransactions.Columns["Tutar"].DefaultCellStyle.Format = "N2";
                
                // İşlem tipi için görsel iyileştirme
                dgvTransactions.Columns["IslemTipi"].DefaultCellStyle.Format = "g";
            }
            
            lblTotalCount.Text = $"Toplam: {_allTransactions.Count} işlem";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlemler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async Task LoadCashAccountsForFilter()
    {
        try
        {
            var accounts = await _cashService.GetAllCashAccountsAsync();
            cmbCashAccountFilter.Items.Clear();
            cmbCashAccountFilter.Items.Add("Tüm Kasalar");
            
            foreach (var account in accounts.OrderBy(a => a.Ad))
            {
                cmbCashAccountFilter.Items.Add($"{account.Id} - {account.Ad}");
            }
            
            cmbCashAccountFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Kasalar yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CashTransactionEditForm>();
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
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as CashTransaction;
        if (selectedTransaction != null)
        {
            var form = Program.GetService<CashTransactionEditForm>();
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
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as CashTransaction;
        if (selectedTransaction != null)
        {
            var result = MessageBox.Show(
                $"Bu işlemi silmek istediğinizden emin misiniz?\n\n" +
                $"Tutar: {selectedTransaction.Tutar:N2} TL\n" +
                $"Tarih: {selectedTransaction.Tarih:dd.MM.yyyy HH:mm}",
                "İşlem Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _cashService.DeleteTransactionAsync(selectedTransaction.Id);
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
    
    private void cmbCashAccountFilter_SelectedIndexChanged(object sender, EventArgs e)
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
        
        if (cmbCashAccountFilter.SelectedIndex > 0)
        {
            var selectedText = cmbCashAccountFilter.SelectedItem?.ToString() ?? "";
            if (int.TryParse(selectedText.Split('-')[0].Trim(), out int cashAccountId))
            {
                filtered = filtered.Where(t => t.KasaId == cashAccountId);
            }
        }
        
        if (cmbTypeFilter.SelectedIndex == 1) // Giriş
        {
            filtered = filtered.Where(t => t.IslemTipi == CashTransactionType.Giris);
        }
        else if (cmbTypeFilter.SelectedIndex == 2) // Çıkış
        {
            filtered = filtered.Where(t => t.IslemTipi == CashTransactionType.Cikis);
        }
        else if (cmbTypeFilter.SelectedIndex == 3) // Transfer
        {
            filtered = filtered.Where(t => t.IslemTipi == CashTransactionType.Transfer);
        }
        
        var result = filtered.ToList();
        dgvTransactions.DataSource = result;
        lblTotalCount.Text = $"Gösterilen: {result.Count} / Toplam: {_allTransactions.Count} işlem";
    }
}

