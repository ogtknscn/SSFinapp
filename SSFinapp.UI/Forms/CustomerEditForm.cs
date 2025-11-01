using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;

namespace SSFinapp.UI.Forms;

public partial class CustomerEditForm : Form
{
    private readonly ICurrentAccountService _currentAccountService;
    private int? _customerId;
    
    public CustomerEditForm(ICurrentAccountService currentAccountService)
    {
        _currentAccountService = currentAccountService;
        InitializeComponent();
    }
    
    public async void LoadCustomer(int customerId)
    {
        try
        {
            _customerId = customerId;
            var customer = await _currentAccountService.GetCustomerByIdAsync(customerId);
            
            if (customer != null)
            {
                txtAd.Text = customer.Ad;
                txtTelefon.Text = customer.Telefon;
                txtEmail.Text = customer.Email;
                txtAdres.Text = customer.Adres;
                chkAktif.Checked = customer.Aktif;
                
                lblTitle.Text = "Müşteri Düzenle";
                this.Text = "Müşteri Düzenle";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Müşteri yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAd.Text))
        {
            MessageBox.Show("Müşteri adı boş olamaz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAd.Focus();
            return;
        }
        
        try
        {
            if (_customerId.HasValue)
            {
                var customer = await _currentAccountService.GetCustomerByIdAsync(_customerId.Value);
                if (customer != null)
                {
                    customer.Ad = txtAd.Text.Trim();
                    customer.Telefon = txtTelefon.Text.Trim();
                    customer.Email = txtEmail.Text.Trim();
                    customer.Adres = txtAdres.Text.Trim();
                    customer.Aktif = chkAktif.Checked;
                    
                    await _currentAccountService.UpdateCustomerAsync(customer);
                    MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var customer = new Customer
                {
                    Ad = txtAd.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Adres = txtAdres.Text.Trim(),
                    Aktif = chkAktif.Checked
                };
                
                await _currentAccountService.AddCustomerAsync(customer);
                MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Müşteri kaydedilirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

