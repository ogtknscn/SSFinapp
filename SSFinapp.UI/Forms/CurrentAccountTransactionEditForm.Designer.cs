using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class CurrentAccountTransactionEditForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle, lblTarih, lblCustomer, lblMalzeme, lblTutar, lblAlinan, lblVerilen, lblIslemTipi, lblAciklama;
    private DateTimePicker dtpTarih;
    private MaterialComboBox cmbCustomer;
    private MaterialButton btnQuickAddCustomer;
    private MaterialTextBox txtMalzeme;
    private MaterialMultiLineTextBox txtAciklama;
    private NumericUpDown numTutar, numAlinan, numVerilen;
    private RadioButton rdbPara, rdbMal;
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
        this.lblCustomer = new MaterialLabel();
        this.cmbCustomer = new MaterialComboBox();
        this.lblMalzeme = new MaterialLabel();
        this.txtMalzeme = new MaterialTextBox();
        this.lblTutar = new MaterialLabel();
        this.numTutar = new NumericUpDown();
        this.lblAlinan = new MaterialLabel();
        this.numAlinan = new NumericUpDown();
        this.lblVerilen = new MaterialLabel();
        this.numVerilen = new NumericUpDown();
        this.grpIslemTipi = new GroupBox();
        this.rdbPara = new RadioButton();
        this.rdbMal = new RadioButton();
        this.lblAciklama = new MaterialLabel();
        this.txtAciklama = new MaterialMultiLineTextBox();
        this.btnSave = new MaterialButton();
        this.btnCancel = new MaterialButton();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.grpIslemTipi.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.numTutar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numAlinan).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numVerilen).BeginInit();
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
        this.lblTitle.Text = "Yeni Cari İşlem";
        
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
        
        // lblCustomer
        this.lblCustomer.AutoSize = true;
        this.lblCustomer.Depth = 0;
        this.lblCustomer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblCustomer.FontType = MaterialSkinManager.fontType.Body1;
        this.lblCustomer.Location = new Point(30, 85);
        this.lblCustomer.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblCustomer.Text = "Müşteri:";
        
        // cmbCustomer
        this.cmbCustomer.AutoResize = false;
        this.cmbCustomer.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbCustomer.Depth = 0;
        this.cmbCustomer.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbCustomer.DropDownHeight = 174;
        this.cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCustomer.DropDownWidth = 121;
        this.cmbCustomer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbCustomer.FormattingEnabled = true;
        this.cmbCustomer.Hint = "";
        this.cmbCustomer.IntegralHeight = false;
        this.cmbCustomer.ItemHeight = 43;
        this.cmbCustomer.Location = new Point(30, 110);
        this.cmbCustomer.MaxDropDownItems = 4;
        this.cmbCustomer.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbCustomer.Size = new Size(450, 49);
        this.cmbCustomer.StartIndex = 0;
        
        // btnQuickAddCustomer
        this.btnQuickAddCustomer = new MaterialButton();
        this.btnQuickAddCustomer.AutoSize = false;
        this.btnQuickAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnQuickAddCustomer.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnQuickAddCustomer.Depth = 0;
        this.btnQuickAddCustomer.HighEmphasis = true;
        this.btnQuickAddCustomer.Icon = null;
        this.btnQuickAddCustomer.Location = new Point(490, 110);
        this.btnQuickAddCustomer.Margin = new Padding(4, 6, 4, 6);
        this.btnQuickAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnQuickAddCustomer.Size = new Size(40, 49);
        this.btnQuickAddCustomer.Text = "+";
        this.btnQuickAddCustomer.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnQuickAddCustomer.UseAccentColor = true;
        this.btnQuickAddCustomer.UseVisualStyleBackColor = true;
        this.btnQuickAddCustomer.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        
        // lblMalzeme
        this.lblMalzeme.AutoSize = true;
        this.lblMalzeme.Depth = 0;
        this.lblMalzeme.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblMalzeme.FontType = MaterialSkinManager.fontType.Body1;
        this.lblMalzeme.Location = new Point(30, 150);
        this.lblMalzeme.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblMalzeme.Text = "Malzeme/Açıklama:";
        
        // txtMalzeme
        this.txtMalzeme.AnimateReadOnly = false;
        this.txtMalzeme.BorderStyle = BorderStyle.None;
        this.txtMalzeme.Depth = 0;
        this.txtMalzeme.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtMalzeme.Hint = "";
        this.txtMalzeme.LeadingIcon = null;
        this.txtMalzeme.Location = new Point(30, 175);
        this.txtMalzeme.MaxLength = 32767;
        this.txtMalzeme.MouseState = MaterialSkin.MouseState.OUT;
        this.txtMalzeme.Multiline = false;
        this.txtMalzeme.Size = new Size(500, 50);
        this.txtMalzeme.Text = "";
        this.txtMalzeme.TrailingIcon = null;
        this.txtMalzeme.UseAccent = false;
        
        // lblTutar
        this.lblTutar.AutoSize = true;
        this.lblTutar.Depth = 0;
        this.lblTutar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTutar.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTutar.Location = new Point(30, 215);
        this.lblTutar.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTutar.Text = "Tutar:";
        
        // numTutar
        this.numTutar.DecimalPlaces = 2;
        this.numTutar.Font = new Font("Segoe UI", 11F);
        this.numTutar.Location = new Point(30, 240);
        this.numTutar.Maximum = 999999;
        this.numTutar.Size = new Size(150, 27);
        
        // lblAlinan
        this.lblAlinan.AutoSize = true;
        this.lblAlinan.Depth = 0;
        this.lblAlinan.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAlinan.FontType = MaterialSkinManager.fontType.Body1;
        this.lblAlinan.Location = new Point(200, 215);
        this.lblAlinan.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAlinan.Text = "Alınan:";
        
        // numAlinan
        this.numAlinan.DecimalPlaces = 2;
        this.numAlinan.Font = new Font("Segoe UI", 11F);
        this.numAlinan.Location = new Point(200, 240);
        this.numAlinan.Maximum = 999999;
        this.numAlinan.Size = new Size(150, 27);
        
        // lblVerilen
        this.lblVerilen.AutoSize = true;
        this.lblVerilen.Depth = 0;
        this.lblVerilen.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblVerilen.FontType = MaterialSkinManager.fontType.Body1;
        this.lblVerilen.Location = new Point(370, 215);
        this.lblVerilen.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblVerilen.Text = "Verilen:";
        
        // numVerilen
        this.numVerilen.DecimalPlaces = 2;
        this.numVerilen.Font = new Font("Segoe UI", 11F);
        this.numVerilen.Location = new Point(370, 240);
        this.numVerilen.Maximum = 999999;
        this.numVerilen.Size = new Size(150, 27);
        
        // grpIslemTipi
        this.grpIslemTipi.Font = new Font("Segoe UI", 10F);
        this.grpIslemTipi.Location = new Point(30, 280);
        this.grpIslemTipi.Size = new Size(220, 60);
        this.grpIslemTipi.Text = "İşlem Tipi";
        
        // rdbPara
        this.rdbPara.AutoSize = true;
        this.rdbPara.Checked = true;
        this.rdbPara.Font = new Font("Segoe UI", 10F);
        this.rdbPara.Location = new Point(20, 25);
        this.rdbPara.Text = "💵 Para";
        this.rdbPara.TabStop = true;
        
        // rdbMal
        this.rdbMal.AutoSize = true;
        this.rdbMal.Font = new Font("Segoe UI", 10F);
        this.rdbMal.Location = new Point(120, 25);
        this.rdbMal.Text = "📦 Mal";
        
        this.grpIslemTipi.Controls.AddRange(new Control[] { this.rdbPara, this.rdbMal });
        
        // lblAciklama
        this.lblAciklama.AutoSize = true;
        this.lblAciklama.Depth = 0;
        this.lblAciklama.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAciklama.FontType = MaterialSkinManager.fontType.Body1;
        this.lblAciklama.Location = new Point(30, 355);
        this.lblAciklama.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAciklama.Text = "Açıklama:";
        
        // txtAciklama
        this.txtAciklama.BackgroundImageLayout = ImageLayout.None;
        this.txtAciklama.Depth = 0;
        this.txtAciklama.HideSelection = true;
        this.txtAciklama.Location = new Point(30, 380);
        this.txtAciklama.MouseState = MaterialSkin.MouseState.OUT;
        this.txtAciklama.Name = "txtAciklama";
        this.txtAciklama.ScrollBars = RichTextBoxScrollBars.None;
        this.txtAciklama.SelectedText = "";
        this.txtAciklama.SelectionLength = 0;
        this.txtAciklama.SelectionStart = 0;
        this.txtAciklama.ShortcutsEnabled = true;
        this.txtAciklama.Size = new Size(500, 60);
        this.txtAciklama.TabIndex = 0;
        this.txtAciklama.Text = "";
        
        // btnSave
        this.btnSave.AutoSize = false;
        this.btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnSave.Depth = 0;
        this.btnSave.HighEmphasis = true;
        this.btnSave.Icon = null;
        this.btnSave.Location = new Point(310, 460);
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
        this.btnCancel.Location = new Point(430, 460);
        this.btnCancel.Margin = new Padding(4, 6, 4, 6);
        this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Type = MaterialButton.MaterialButtonType.Text;
        this.btnCancel.UseAccentColor = false;
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblTarih, this.dtpTarih, this.lblCustomer, this.cmbCustomer, this.btnQuickAddCustomer,
            this.lblMalzeme, this.txtMalzeme, this.lblTutar, this.numTutar,
            this.lblAlinan, this.numAlinan, this.lblVerilen, this.numVerilen,
            this.grpIslemTipi, this.lblAciklama, this.txtAciklama,
            this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(600, 560);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Cari İşlem";
        
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
        ((System.ComponentModel.ISupportInitialize)this.numAlinan).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numVerilen).EndInit();
        this.ResumeLayout(false);
    }
}
