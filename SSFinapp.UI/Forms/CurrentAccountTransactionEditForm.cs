using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;

namespace SSFinapp.UI.Forms;

public partial class CurrentAccountTransactionEditForm : Form
{
    private readonly ICurrentAccountService _currentAccountService;
    private int? _transactionId;
    
    public CurrentAccountTransactionEditForm(ICurrentAccountService currentAccountService)
    {
        _currentAccountService = currentAccountService;
        InitializeComponent();
        LoadCustomers();
    }
    
    private async void LoadCustomers()
    {
        try
        {
            var customers = await _currentAccountService.GetActiveCustomersAsync();
            cmbCustomer.Items.Clear();
            
            foreach (var customer in customers.OrderBy(c => c.Ad))
            {
                cmbCustomer.Items.Add(new ComboBoxItem 
                { 
                    Value = customer.Id, 
                    Text = customer.Ad
                });
            }
            
            if (cmbCustomer.Items.Count > 0)
                cmbCustomer.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Müşteriler yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    public async void LoadTransaction(int transactionId)
    {
        try
        {
            _transactionId = transactionId;
            var transactions = await _currentAccountService.GetAllTransactionsAsync();
            var trans = transactions.FirstOrDefault(t => t.Id == transactionId);
            
            if (trans != null)
            {
                dtpTarih.Value = trans.Tarih;
                
                for (int i = 0; i < cmbCustomer.Items.Count; i++)
                {
                    var item = (ComboBoxItem)cmbCustomer.Items[i];
                    if (item.Value == trans.MusteriId)
                    {
                        cmbCustomer.SelectedIndex = i;
                        break;
                    }
                }
                
                txtMalzeme.Text = trans.Malzeme;
                numTutar.Value = trans.Tutar;
                numAlinan.Value = trans.Alinan;
                numVerilen.Value = trans.Verilen;
                rdbPara.Checked = trans.IslemTipi == PaymentType.Para;
                rdbMal.Checked = trans.IslemTipi == PaymentType.Mal;
                txtAciklama.Text = trans.Aciklama;
                
                lblTitle.Text = "Cari İşlem Düzenle";
                this.Text = "Cari İşlem Düzenle";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"İşlem yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (cmbCustomer.SelectedItem == null)
        {
            MessageBox.Show("Müşteri seçiniz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        try
        {
            var selectedCustomer = (ComboBoxItem)cmbCustomer.SelectedItem;
            
            if (_transactionId.HasValue)
            {
                var transactions = await _currentAccountService.GetAllTransactionsAsync();
                var transaction = transactions.FirstOrDefault(t => t.Id == _transactionId.Value);
                
                if (transaction != null)
                {
                    transaction.MusteriId = selectedCustomer.Value;
                    transaction.Tarih = dtpTarih.Value;
                    transaction.Malzeme = txtMalzeme.Text.Trim();
                    transaction.Tutar = numTutar.Value;
                    transaction.Alinan = numAlinan.Value;
                    transaction.Verilen = numVerilen.Value;
                    transaction.IslemTipi = rdbPara.Checked ? PaymentType.Para : PaymentType.Mal;
                    transaction.Aciklama = txtAciklama.Text.Trim();
                    
                    await _currentAccountService.UpdateTransactionAsync(transaction);
                    MessageBox.Show("İşlem başarıyla güncellendi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var transaction = new CurrentAccountTransaction
                {
                    MusteriId = selectedCustomer.Value,
                    Tarih = dtpTarih.Value,
                    Malzeme = txtMalzeme.Text.Trim(),
                    Tutar = numTutar.Value,
                    Alinan = numAlinan.Value,
                    Verilen = numVerilen.Value,
                    IslemTipi = rdbPara.Checked ? PaymentType.Para : PaymentType.Mal,
                    Aciklama = txtAciklama.Text.Trim()
                };
                
                await _currentAccountService.AddTransactionAsync(transaction);
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
    
    private class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; } = "";
        public override string ToString() => Text;
    }
}

