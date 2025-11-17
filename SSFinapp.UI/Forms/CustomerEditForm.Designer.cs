using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class CustomerEditForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle, lblAd, lblTelefon, lblEmail, lblAdres;
    private MaterialTextBox txtAd, txtTelefon, txtEmail;
    private MaterialMultiLineTextBox txtAdres;
    private MaterialCheckbox chkAktif;
    private MaterialButton btnSave, btnCancel;
    private Panel panelTop, panelContent;
    
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
        this.lblAd = new MaterialLabel();
        this.txtAd = new MaterialTextBox();
        this.lblTelefon = new MaterialLabel();
        this.txtTelefon = new MaterialTextBox();
        this.lblEmail = new MaterialLabel();
        this.txtEmail = new MaterialTextBox();
        this.lblAdres = new MaterialLabel();
        this.txtAdres = new MaterialMultiLineTextBox();
        this.chkAktif = new MaterialCheckbox();
        this.btnSave = new MaterialButton();
        this.btnCancel = new MaterialButton();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(550, 60);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Text = "Yeni Müşteri Ekle";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // lblAd
        this.lblAd.AutoSize = true;
        this.lblAd.Depth = 0;
        this.lblAd.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAd.FontType = MaterialSkinManager.fontType.Body1;
        this.lblAd.Location = new Point(30, 30);
        this.lblAd.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAd.Text = "Müşteri Adı:";
        
        // txtAd
        this.txtAd.AnimateReadOnly = false;
        this.txtAd.BorderStyle = BorderStyle.None;
        this.txtAd.Depth = 0;
        this.txtAd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtAd.Hint = "";
        this.txtAd.LeadingIcon = null;
        this.txtAd.Location = new Point(30, 55);
        this.txtAd.MaxLength = 32767;
        this.txtAd.MouseState = MaterialSkin.MouseState.OUT;
        this.txtAd.Multiline = false;
        this.txtAd.Size = new Size(480, 50);
        this.txtAd.Text = "";
        this.txtAd.TrailingIcon = null;
        this.txtAd.UseAccent = false;
        
        // lblTelefon
        this.lblTelefon.AutoSize = true;
        this.lblTelefon.Depth = 0;
        this.lblTelefon.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTelefon.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTelefon.Location = new Point(30, 95);
        this.lblTelefon.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTelefon.Text = "Telefon:";
        
        // txtTelefon
        this.txtTelefon.AnimateReadOnly = false;
        this.txtTelefon.BorderStyle = BorderStyle.None;
        this.txtTelefon.Depth = 0;
        this.txtTelefon.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtTelefon.Hint = "";
        this.txtTelefon.LeadingIcon = null;
        this.txtTelefon.Location = new Point(30, 120);
        this.txtTelefon.MaxLength = 32767;
        this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
        this.txtTelefon.Multiline = false;
        this.txtTelefon.Size = new Size(230, 50);
        this.txtTelefon.Text = "";
        this.txtTelefon.TrailingIcon = null;
        this.txtTelefon.UseAccent = false;
        
        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Depth = 0;
        this.lblEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblEmail.FontType = MaterialSkinManager.fontType.Body1;
        this.lblEmail.Location = new Point(280, 95);
        this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblEmail.Text = "Email:";
        
        // txtEmail
        this.txtEmail.AnimateReadOnly = false;
        this.txtEmail.BorderStyle = BorderStyle.None;
        this.txtEmail.Depth = 0;
        this.txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtEmail.Hint = "";
        this.txtEmail.LeadingIcon = null;
        this.txtEmail.Location = new Point(280, 120);
        this.txtEmail.MaxLength = 32767;
        this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
        this.txtEmail.Multiline = false;
        this.txtEmail.Size = new Size(230, 50);
        this.txtEmail.Text = "";
        this.txtEmail.TrailingIcon = null;
        this.txtEmail.UseAccent = false;
        
        // lblAdres
        this.lblAdres.AutoSize = true;
        this.lblAdres.Depth = 0;
        this.lblAdres.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAdres.FontType = MaterialSkinManager.fontType.Body1;
        this.lblAdres.Location = new Point(30, 160);
        this.lblAdres.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAdres.Text = "Adres:";
        
        // txtAdres
        this.txtAdres.BackgroundImageLayout = ImageLayout.None;
        this.txtAdres.Depth = 0;
        this.txtAdres.HideSelection = true;
        this.txtAdres.Location = new Point(30, 185);
        this.txtAdres.MouseState = MaterialSkin.MouseState.OUT;
        this.txtAdres.Name = "txtAdres";
        this.txtAdres.ScrollBars = RichTextBoxScrollBars.None;
        this.txtAdres.SelectedText = "";
        this.txtAdres.SelectionLength = 0;
        this.txtAdres.SelectionStart = 0;
        this.txtAdres.ShortcutsEnabled = true;
        this.txtAdres.Size = new Size(480, 80);
        this.txtAdres.TabIndex = 0;
        this.txtAdres.Text = "";
        
        // chkAktif
        this.chkAktif.AutoSize = true;
        this.chkAktif.Depth = 0;
        this.chkAktif.Location = new Point(30, 280);
        this.chkAktif.Margin = new Padding(0);
        this.chkAktif.MouseLocation = new Point(-1, -1);
        this.chkAktif.MouseState = MaterialSkin.MouseState.HOVER;
        this.chkAktif.Name = "chkAktif";
        this.chkAktif.Ripple = true;
        this.chkAktif.Size = new Size(58, 37);
        this.chkAktif.TabIndex = 4;
        this.chkAktif.Text = "Aktif";
        this.chkAktif.UseVisualStyleBackColor = true;
        this.chkAktif.Checked = true;
        
        // btnSave
        this.btnSave.AutoSize = false;
        this.btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnSave.Depth = 0;
        this.btnSave.HighEmphasis = true;
        this.btnSave.Icon = null;
        this.btnSave.Location = new Point(290, 320);
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
        this.btnCancel.Location = new Point(410, 320);
        this.btnCancel.Margin = new Padding(4, 6, 4, 6);
        this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Type = MaterialButton.MaterialButtonType.Text;
        this.btnCancel.UseAccentColor = false;
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblAd, this.txtAd, this.lblTelefon, this.txtTelefon,
            this.lblEmail, this.txtEmail, this.lblAdres, this.txtAdres,
            this.chkAktif, this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(550, 420);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Müşteri Ekle";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelContent.ResumeLayout(false);
        this.panelContent.PerformLayout();
        this.ResumeLayout(false);
    }
}
