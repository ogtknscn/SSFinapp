using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;

namespace SSFinapp.UI.Forms;

public partial class CustomerManagementForm : Form
{
    private readonly ICurrentAccountService _currentAccountService;
    
    public CustomerManagementForm(ICurrentAccountService currentAccountService)
    {
        _currentAccountService = currentAccountService;
        InitializeComponent();
        LoadCustomers();
    }
    
    private async void LoadCustomers()
    {
        try
        {
            var customers = await _currentAccountService.GetAllCustomersAsync();
            dgvCustomers.DataSource = customers.ToList();
            
            if (dgvCustomers.Columns.Count > 0)
            {
                dgvCustomers.Columns["Id"].HeaderText = "ID";
                dgvCustomers.Columns["Ad"].HeaderText = "Müşteri Adı";
                dgvCustomers.Columns["Telefon"].HeaderText = "Telefon";
                dgvCustomers.Columns["Email"].HeaderText = "Email";
                dgvCustomers.Columns["Adres"].HeaderText = "Adres";
                dgvCustomers.Columns["Aktif"].HeaderText = "Aktif";
                dgvCustomers.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma Tarihi";
                
                if (dgvCustomers.Columns.Contains("CariHareketler"))
                    dgvCustomers.Columns["CariHareketler"].Visible = false;
                    
                dgvCustomers.Columns["OlusturmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            
            lblTotalCount.Text = $"Toplam: {customers.Count()} müşteri";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Müşteriler yüklenirken hata: {ex.Message}", "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = Program.GetService<CustomerEditForm>();
        if (form != null && form.ShowDialog() == DialogResult.OK)
        {
            LoadCustomers();
        }
    }
    
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen düzenlemek için bir müşteri seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
        if (selectedCustomer != null)
        {
            var form = Program.GetService<CustomerEditForm>();
            if (form != null)
            {
                form.LoadCustomer(selectedCustomer.Id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }
    }
    
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
        if (selectedCustomer != null)
        {
            var result = MessageBox.Show(
                $"'{selectedCustomer.Ad}' müşterisini silmek istediğinizden emin misiniz?",
                "Müşteri Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _currentAccountService.DeleteCustomerAsync(selectedCustomer.Id);
                    MessageBox.Show("Müşteri başarıyla silindi.", "Başarılı", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Müşteri silinirken hata: {ex.Message}", "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
    private async void btnViewBalance_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen bakiye görmek için bir müşteri seçin.", "Uyarı", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        var selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
        if (selectedCustomer != null)
        {
            try
            {
                var balance = await _currentAccountService.GetCustomerBalanceAsync(selectedCustomer.Id);
                var balanceText = balance >= 0 ? $"+{balance:N2} TL (Alacak)" : $"{balance:N2} TL (Borç)";
                
                MessageBox.Show(
                    $"Müşteri: {selectedCustomer.Ad}\n" +
                    $"Bakiye: {balanceText}",
                    "Bakiye Bilgisi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bakiye bilgisi alınırken hata: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadCustomers();
    }
    
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (dgvCustomers.DataSource is List<Customer> customers)
        {
            var searchText = txtSearch.Text.ToLower();
            var filtered = customers.Where(c => 
                c.Ad.ToLower().Contains(searchText) ||
                (c.Telefon?.ToLower().Contains(searchText) ?? false) ||
                (c.Email?.ToLower().Contains(searchText) ?? false)
            ).ToList();
            
            dgvCustomers.DataSource = filtered;
            lblTotalCount.Text = $"Gösterilen: {filtered.Count} / Toplam: {customers.Count} müşteri";
        }
    }
    
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

