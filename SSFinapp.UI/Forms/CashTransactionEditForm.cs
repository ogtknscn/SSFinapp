using MaterialSkin.Controls;
using SSFinapp.Business.Services;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;
using SSFinapp.UI.Helpers;

namespace SSFinapp.UI.Forms;

public partial class CashTransactionEditForm : MaterialForm
{
    private readonly ICashService _cashService;
    private int? _transactionId;
    
    public CashTransactionEditForm(ICashService cashService)
    {
        _cashService = cashService;
        InitializeComponent();
        LoadCashAccounts();
        SetupKeyboardShortcuts();
    }
    
    private void SetupKeyboardShortcuts()
    {
        KeyboardHelper.SetupKeyboardShortcuts(
            this,
            onEnter: () => btnSave_Click(btnSave, EventArgs.Empty), // ENTER: Kaydet
            onEscape: () => btnCancel_Click(btnCancel, EventArgs.Empty) // ESC: İptal
        );
    }
    
    private async void LoadCashAccounts()
    {
        try
        {
            var accounts = await _cashService.GetActiveCashAccountsAsync();
            cmbCashAccount.Items.Clear();
            
            foreach (var account in accounts.OrderBy(a => a.Ad))
            {
                cmbCashAccount.Items.Add(new ComboBoxItem 
                { 
                    Value = account.Id, 
                    Text = $"{account.Ad} ({account.ParaBirimi})"
                });
            }
            
            if (cmbCashAccount.Items.Count > 0)
                cmbCashAccount.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Kasalar yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    public async void LoadTransaction(int transactionId)
    {
        try
        {
            _transactionId = transactionId;
            var transactions = await _cashService.GetAllTransactionsAsync();
            var trans = transactions.FirstOrDefault(t => t.Id == transactionId);
            
            if (trans != null)
            {
                dtpTarih.Value = trans.Tarih;
                
                for (int i = 0; i < cmbCashAccount.Items.Count; i++)
                {
                    var item = (ComboBoxItem)cmbCashAccount.Items[i];
                    if (item.Value == trans.KasaId)
                    {
                        cmbCashAccount.SelectedIndex = i;
                        break;
                    }
                }
                
                numTutar.Value = trans.Tutar;
                rdbGiris.Checked = trans.IslemTipi == CashTransactionType.Giris;
                rdbCikis.Checked = trans.IslemTipi == CashTransactionType.Cikis;
                rdbTransfer.Checked = trans.IslemTipi == CashTransactionType.Transfer;
                txtAciklama.Text = trans.Aciklama;
                
                lblTitle.Text = "Kasa İşlemi Düzenle";
                this.Text = "Kasa İşlemi Düzenle";
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
        if (cmbCashAccount.SelectedItem == null)
        {
            MessageBox.Show("Kasa seçiniz!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        if (numTutar.Value <= 0)
        {
            MessageBox.Show("Tutar 0'dan büyük olmalıdır!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        try
        {
            var selectedAccount = (ComboBoxItem)cmbCashAccount.SelectedItem;
            CashTransactionType transactionType;
            
            if (rdbGiris.Checked)
                transactionType = CashTransactionType.Giris;
            else if (rdbCikis.Checked)
                transactionType = CashTransactionType.Cikis;
            else
                transactionType = CashTransactionType.Transfer;
            
            if (_transactionId.HasValue)
            {
                var transactions = await _cashService.GetAllTransactionsAsync();
                var transaction = transactions.FirstOrDefault(t => t.Id == _transactionId.Value);
                
                if (transaction != null)
                {
                    transaction.KasaId = selectedAccount.Value;
                    transaction.Tarih = dtpTarih.Value;
                    transaction.Tutar = numTutar.Value;
                    transaction.IslemTipi = transactionType;
                    transaction.Aciklama = txtAciklama.Text.Trim();
                    
                    await _cashService.UpdateTransactionAsync(transaction);
                    MessageBox.Show("İşlem başarıyla güncellendi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var transaction = new CashTransaction
                {
                    KasaId = selectedAccount.Value,
                    Tarih = dtpTarih.Value,
                    Tutar = numTutar.Value,
                    IslemTipi = transactionType,
                    Aciklama = txtAciklama.Text.Trim()
                };
                
                await _cashService.AddTransactionAsync(transaction);
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

