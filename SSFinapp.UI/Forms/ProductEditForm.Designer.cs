using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class ProductEditForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle;
    private MaterialLabel lblAd;
    private MaterialLabel lblBirim;
    private MaterialTextBox txtAd;
    private MaterialComboBox cmbBirim;
    private MaterialCheckbox chkAktif;
    private MaterialButton btnSave;
    private MaterialButton btnCancel;
    private Panel panelTop;
    private Panel panelContent;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.lblTitle = new MaterialLabel();
        this.lblAd = new MaterialLabel();
        this.lblBirim = new MaterialLabel();
        this.txtAd = new MaterialTextBox();
        this.cmbBirim = new MaterialComboBox();
        this.chkAktif = new MaterialCheckbox();
        this.btnSave = new MaterialButton();
        this.btnCancel = new MaterialButton();
        this.panelTop = new Panel();
        this.panelContent = new Panel();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(500, 60);
        this.panelTop.TabIndex = 0;
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(130, 19);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Yeni Ürün Ekle";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Controls.Add(this.lblAd);
        this.panelContent.Controls.Add(this.txtAd);
        this.panelContent.Controls.Add(this.lblBirim);
        this.panelContent.Controls.Add(this.cmbBirim);
        this.panelContent.Controls.Add(this.chkAktif);
        this.panelContent.Controls.Add(this.btnSave);
        this.panelContent.Controls.Add(this.btnCancel);
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Name = "panelContent";
        this.panelContent.Padding = new Padding(20);
        this.panelContent.Size = new Size(500, 250);
        this.panelContent.TabIndex = 1;
        
        // lblAd
        this.lblAd.AutoSize = true;
        this.lblAd.Depth = 0;
        this.lblAd.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblAd.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblAd.Location = new Point(30, 30);
        this.lblAd.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblAd.Name = "lblAd";
        this.lblAd.Size = new Size(70, 19);
        this.lblAd.TabIndex = 0;
        this.lblAd.Text = "Ürün Adı:";
        
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
        this.txtAd.Name = "txtAd";
        this.txtAd.Size = new Size(440, 50);
        this.txtAd.TabIndex = 1;
        this.txtAd.Text = "";
        this.txtAd.TrailingIcon = null;
        this.txtAd.UseAccent = false;
        
        // lblBirim
        this.lblBirim.AutoSize = true;
        this.lblBirim.Depth = 0;
        this.lblBirim.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblBirim.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblBirim.Location = new Point(30, 95);
        this.lblBirim.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblBirim.Name = "lblBirim";
        this.lblBirim.Size = new Size(46, 19);
        this.lblBirim.TabIndex = 2;
        this.lblBirim.Text = "Birim:";
        
        // cmbBirim
        this.cmbBirim.AutoResize = false;
        this.cmbBirim.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbBirim.Depth = 0;
        this.cmbBirim.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbBirim.DropDownHeight = 174;
        this.cmbBirim.DropDownStyle = ComboBoxStyle.DropDown;
        this.cmbBirim.DropDownWidth = 121;
        this.cmbBirim.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbBirim.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbBirim.FormattingEnabled = true;
        this.cmbBirim.Hint = "";
        this.cmbBirim.IntegralHeight = false;
        this.cmbBirim.ItemHeight = 43;
        this.cmbBirim.Location = new Point(30, 120);
        this.cmbBirim.MaxDropDownItems = 4;
        this.cmbBirim.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbBirim.Name = "cmbBirim";
        this.cmbBirim.Size = new Size(200, 49);
        this.cmbBirim.StartIndex = 0;
        this.cmbBirim.TabIndex = 3;
        
        // chkAktif
        this.chkAktif.AutoSize = true;
        this.chkAktif.Depth = 0;
        this.chkAktif.Location = new Point(30, 165);
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
        this.btnSave.Location = new Point(240, 195);
        this.btnSave.Margin = new Padding(4, 6, 4, 6);
        this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnSave.Name = "btnSave";
        this.btnSave.NoAccentTextColor = Color.Empty;
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.TabIndex = 5;
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnSave.UseAccentColor = false;
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.btnSave_Click);
        
        // btnCancel
        this.btnCancel.AutoSize = false;
        this.btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnCancel.Depth = 0;
        this.btnCancel.HighEmphasis = false;
        this.btnCancel.Icon = null;
        this.btnCancel.Location = new Point(360, 195);
        this.btnCancel.Margin = new Padding(4, 6, 4, 6);
        this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.NoAccentTextColor = Color.Empty;
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.TabIndex = 6;
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Type = MaterialButton.MaterialButtonType.Text;
        this.btnCancel.UseAccentColor = false;
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
        
        // ProductEditForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(500, 310);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "ProductEditForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Ürün Ekle";
        
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

