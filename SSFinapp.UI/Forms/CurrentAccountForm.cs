using MaterialSkin.Controls;
using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;
using SSFinapp.UI.Helpers;

namespace SSFinapp.UI.Forms;

public partial class CurrentAccountForm : MaterialForm
{
    private readonly ICurrentAccountService _currentAccountService;
    private List<CurrentAccountTransaction> _allTransactions = new();
    
    public CurrentAccountForm(ICurrentAccountService currentAccountService)
    {
        _currentAccountService = currentAccountService;
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
        await LoadCustomersForFilter();
    }
    
    private async Task LoadTransactions()
    {
        try
        {
            var transactions = await _currentAccountService.GetAllTransactionsAsync();
            _allTransactions = transactions.OrderByDescending(t => t.Tarih).ToList();
            
            dgvTransactions.DataSource = _allTransactions;
            
            if (dgvTransactions.Columns.Count > 0)
            {
                dgvTransactions.Columns["Id"].HeaderText = "ID";
                dgvTransactions.Columns["MusteriId"].HeaderText = "Müşteri ID";
                dgvTransactions.Columns["Tarih"].HeaderText = "Tarih";
                dgvTransactions.Columns["Malzeme"].HeaderText = "Malzeme/Açıklama";
                dgvTransactions.Columns["Tutar"].HeaderText = "Tutar";
                dgvTransactions.Columns["Alinan"].HeaderText = "Alınan";
                dgvTransactions.Columns["Verilen"].HeaderText = "Verilen";
                dgvTransactions.Columns["IslemTipi"].HeaderText = "İşlem Tipi";
                dgvTransactions.Columns["Aciklama"].HeaderText = "Açıklama";
                dgvTransactions.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma Tarihi";
                
                if (dgvTransactions.Columns.Contains("Musteri"))
                    dgvTransactions.Columns["Musteri"].Visible = false;
                    
                dgvTransactions.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvTransactions.Columns["OlusturmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvTransactions.Columns["Tutar"].DefaultCellStyle.Format = "N2";
                dgvTransactions.Columns["Alinan"].DefaultCellStyle.Format = "N2";
                dgvTransactions.Columns["Verilen"].DefaultCellStyle.Format = "N2";
            }
            
            lblTotalCount.Text = $"Toplam: {_allTransactions.Count} işlem";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlemler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async Task LoadCustomersForFilter()
    {
        try
        {
            var customers = await _currentAccountService.GetAllCustomersAsync();
            cmbCustomerFilter.Items.Clear();
            cmbCustomerFilter.Items.Add("Tüm Müşteriler");
            
            foreach (var customer in customers.OrderBy(c => c.Ad))
            {
                cmbCustomerFilter.Items.Add($"{customer.Id} - {customer.Ad}");
            }
            
            cmbCustomerFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Müşteriler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CurrentAccountTransactionEditForm>();
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
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as CurrentAccountTransaction;
        if (selectedTransaction != null)
        {
            var form = Program.GetService<CurrentAccountTransactionEditForm>();
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
        
        var selectedTransaction = dgvTransactions.SelectedRows[0].DataBoundItem as CurrentAccountTransaction;
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
                    await _currentAccountService.DeleteTransactionAsync(selectedTransaction.Id);
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
    
    private void cmbCustomerFilter_SelectedIndexChanged(object sender, EventArgs e)
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
        
        if (cmbCustomerFilter.SelectedIndex > 0)
        {
            var selectedText = cmbCustomerFilter.SelectedItem?.ToString() ?? "";
            if (int.TryParse(selectedText.Split('-')[0].Trim(), out int customerId))
            {
                filtered = filtered.Where(t => t.MusteriId == customerId);
            }
        }
        
        if (cmbTypeFilter.SelectedIndex == 1) // Para
        {
            filtered = filtered.Where(t => t.IslemTipi == PaymentType.Para);
        }
        else if (cmbTypeFilter.SelectedIndex == 2) // Mal
        {
            filtered = filtered.Where(t => t.IslemTipi == PaymentType.Mal);
        }
        
        var result = filtered.ToList();
        dgvTransactions.DataSource = result;
        lblTotalCount.Text = $"Gösterilen: {result.Count} / Toplam: {_allTransactions.Count} işlem";
    }
}

