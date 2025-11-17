using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class CashTransactionEditForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle, lblTarih, lblCashAccount, lblTutar, lblIslemTipi, lblAciklama;
    private DateTimePicker dtpTarih;
    private MaterialComboBox cmbCashAccount;
    private MaterialTextBox txtAciklama;
    private NumericUpDown numTutar;
    private RadioButton rdbGiris, rdbCikis, rdbTransfer;
    private MaterialButton btnSave, btnCancel;
    private Panel panelTop, panelContent;
    private GroupBox grpIslemTipi;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.panelTop = new Panel();
        this.lblTitle = new MaterialLabel();
        this.panelContent = new Panel();
        this.lblTarih = new MaterialLabel();
        this.dtpTarih = new DateTimePicker();
        this.lblCashAccount = new MaterialLabel();
        this.cmbCashAccount = new MaterialComboBox();
        this.lblTutar = new MaterialLabel();
        this.numTutar = new NumericUpDown();
        this.grpIslemTipi = new GroupBox();
        this.rdbGiris = new RadioButton();
        this.rdbCikis = new RadioButton();
        this.rdbTransfer = new RadioButton();
        this.lblAciklama = new MaterialLabel();
        this.txtAciklama = new MaterialTextBox();
        this.btnSave = new MaterialButton();
        this.btnCancel = new MaterialButton();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.grpIslemTipi.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.numTutar).BeginInit();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(600, 60);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Text = "Yeni Kasa İşlemi";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // lblTarih
        this.lblTarih.AutoSize = true;
        this.lblTarih.Depth = 0;
        this.lblTarih.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTarih.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTarih.Location = new Point(30, 20);
        this.lblTarih.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTarih.Text = "Tarih:";
        
        // dtpTarih
        this.dtpTarih.Font = new Font("Segoe UI", 11F);
        this.dtpTarih.Format = DateTimePickerFormat.Custom;
        this.dtpTarih.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dtpTarih.Location = new Point(30, 45);
        this.dtpTarih.Size = new Size(200, 27);
        
        // lblCashAccount
        this.lblCashAccount.AutoSize = true;
        this.lblCashAccount.Depth = 0;
        this.lblCashAccount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblCashAccount.FontType = MaterialSkinManager.fontType.Body1;
        this.lblCashAccount.Location = new Point(30, 85);
        this.lblCashAccount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblCashAccount.Text = "Kasa:";
        
        // cmbCashAccount
        this.cmbCashAccount.AutoResize = false;
        this.cmbCashAccount.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbCashAccount.Depth = 0;
        this.cmbCashAccount.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbCashAccount.DropDownHeight = 174;
        this.cmbCashAccount.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCashAccount.DropDownWidth = 121;
        this.cmbCashAccount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbCashAccount.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbCashAccount.FormattingEnabled = true;
        this.cmbCashAccount.Hint = "";
        this.cmbCashAccount.IntegralHeight = false;
        this.cmbCashAccount.ItemHeight = 43;
        this.cmbCashAccount.Location = new Point(30, 110);
        this.cmbCashAccount.MaxDropDownItems = 4;
        this.cmbCashAccount.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbCashAccount.Size = new Size(500, 49);
        this.cmbCashAccount.StartIndex = 0;
        
        // lblTutar
        this.lblTutar.AutoSize = true;
        this.lblTutar.Depth = 0;
        this.lblTutar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTutar.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTutar.Location = new Point(30, 170);
        this.lblTutar.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTutar.Text = "Tutar:";
        
        // numTutar
        this.numTutar.DecimalPlaces = 2;
        this.numTutar.Font = new Font("Segoe UI", 11F);
        this.numTutar.Location = new Point(30, 195);
        this.numTutar.Maximum = 999999999;
        this.numTutar.Size = new Size(200, 27);
        
        // grpIslemTipi
        this.grpIslemTipi.Font = new Font("Segoe UI", 10F);
        this.grpIslemTipi.Location = new Point(30, 235);
        this.grpIslemTipi.Size = new Size(500, 60);
        this.grpIslemTipi.Text = "İşlem Tipi";
        
        // rdbGiris
        this.rdbGiris.AutoSize = true;
        this.rdbGiris.Checked = true;
        this.rdbGiris.Font = new Font("Segoe UI", 10F);
        this.rdbGiris.Location = new Point(20, 25);
        this.rdbGiris.Text = "💰 Giriş (Tahsilat)";
        this.rdbGiris.TabStop = true;
        
        // rdbCikis
        this.rdbCikis.AutoSize = true;
        this.rdbCikis.Font = new Font("Segoe UI", 10F);
        this.rdbCikis.Location = new Point(200, 25);
        this.rdbCikis.Text = "💸 Çıkış (Ödeme)";
        
        // rdbTransfer
        this.rdbTransfer.AutoSize = true;
        this.rdbTransfer.Font = new Font("Segoe UI", 10F);
        this.rdbTransfer.Location = new Point(380, 25);
        this.rdbTransfer.Text = "🔄 Transfer";
        
        this.grpIslemTipi.Controls.AddRange(new Control[] { this.rdbGiris, this.rdbCikis, this.rdbTransfer });
        
        // lblAciklama
        this.lblAciklama.AutoSize = true;
        this.lblAciklama.Depth = 0;
        this.lblAciklama.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAciklama.FontType = MaterialSkinManager.fontType.Body1;
        this.lblAciklama.Location = new Point(30, 310);
        this.lblAciklama.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAciklama.Text = "Açıklama:";
        
        // txtAciklama
        this.txtAciklama.AnimateReadOnly = false;
        this.txtAciklama.BorderStyle = BorderStyle.None;
        this.txtAciklama.Depth = 0;
        this.txtAciklama.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtAciklama.Hint = "";
        this.txtAciklama.LeadingIcon = null;
        this.txtAciklama.Location = new Point(30, 335);
        this.txtAciklama.MaxLength = 500;
        this.txtAciklama.MouseState = MaterialSkin.MouseState.OUT;
        this.txtAciklama.Multiline = false;
        this.txtAciklama.Size = new Size(500, 50);
        this.txtAciklama.Text = "";
        this.txtAciklama.TrailingIcon = null;
        this.txtAciklama.UseAccent = false;
        
        // btnSave
        this.btnSave.AutoSize = false;
        this.btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnSave.Depth = 0;
        this.btnSave.HighEmphasis = true;
        this.btnSave.Icon = null;
        this.btnSave.Location = new Point(310, 410);
        this.btnSave.Margin = new Padding(4, 6, 4, 6);
        this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnSave.UseAccentColor = false;
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += btnSave_Click;
        
        // btnCancel
        this.btnCancel.AutoSize = false;
        this.btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnCancel.Depth = 0;
        this.btnCancel.HighEmphasis = false;
        this.btnCancel.Icon = null;
        this.btnCancel.Location = new Point(430, 410);
        this.btnCancel.Margin = new Padding(4, 6, 4, 6);
        this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Type = MaterialButton.MaterialButtonType.Text;
        this.btnCancel.UseAccentColor = false;
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblTarih, this.dtpTarih, this.lblCashAccount, this.cmbCashAccount,
            this.lblTutar, this.numTutar, this.grpIslemTipi, this.lblAciklama, this.txtAciklama,
            this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(600, 510);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Kasa İşlemi";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelContent.ResumeLayout(false);
        this.panelContent.PerformLayout();
        this.grpIslemTipi.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.numTutar).EndInit();
        this.ResumeLayout(false);
    }
}

