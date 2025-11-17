using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle;
    private MaterialLabel lblTheme;
    private MaterialRadioButton rdbLight;
    private MaterialRadioButton rdbDark;
    private MaterialButton btnSave;
    private MaterialButton btnCancel;
    private Panel panelTop;
    private Panel panelContent;
    private GroupBox grpTheme;
    
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
        this.grpTheme = new GroupBox();
        this.rdbLight = new MaterialRadioButton();
        this.rdbDark = new MaterialRadioButton();
        this.lblTheme = new MaterialLabel();
        this.btnSave = new MaterialButton();
        this.btnCancel = new MaterialButton();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.grpTheme.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(450, 60);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Text = "Ayarlar";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // lblTheme
        this.lblTheme.AutoSize = true;
        this.lblTheme.Depth = 0;
        this.lblTheme.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTheme.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTheme.Location = new Point(30, 30);
        this.lblTheme.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTheme.Text = "Tema:";
        
        // grpTheme
        this.grpTheme.Font = new Font("Segoe UI", 10F);
        this.grpTheme.Location = new Point(30, 60);
        this.grpTheme.Size = new Size(380, 100);
        this.grpTheme.Text = "Görünüm Teması";
        this.grpTheme.Controls.Add(this.rdbLight);
        this.grpTheme.Controls.Add(this.rdbDark);
        
        // rdbLight
        this.rdbLight.AutoSize = true;
        this.rdbLight.Checked = true;
        this.rdbLight.Depth = 0;
        this.rdbLight.Location = new Point(20, 30);
        this.rdbLight.Margin = new Padding(0);
        this.rdbLight.MouseLocation = new Point(-1, -1);
        this.rdbLight.MouseState = MaterialSkin.MouseState.HOVER;
        this.rdbLight.Name = "rdbLight";
        this.rdbLight.Ripple = true;
        this.rdbLight.Size = new Size(58, 37);
        this.rdbLight.TabIndex = 0;
        this.rdbLight.TabStop = true;
        this.rdbLight.Text = "Açık Tema (Light)";
        this.rdbLight.UseVisualStyleBackColor = true;
        
        // rdbDark
        this.rdbDark.AutoSize = true;
        this.rdbDark.Depth = 0;
        this.rdbDark.Location = new Point(20, 70);
        this.rdbDark.Margin = new Padding(0);
        this.rdbDark.MouseLocation = new Point(-1, -1);
        this.rdbDark.MouseState = MaterialSkin.MouseState.HOVER;
        this.rdbDark.Name = "rdbDark";
        this.rdbDark.Ripple = true;
        this.rdbDark.Size = new Size(58, 37);
        this.rdbDark.TabIndex = 1;
        this.rdbDark.Text = "Koyu Tema (Dark)";
        this.rdbDark.UseVisualStyleBackColor = true;
        
        // btnSave
        this.btnSave.AutoSize = false;
        this.btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnSave.Depth = 0;
        this.btnSave.HighEmphasis = true;
        this.btnSave.Icon = null;
        this.btnSave.Location = new Point(200, 180);
        this.btnSave.Margin = new Padding(4, 6, 4, 6);
        this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnSave.Size = new Size(100, 40);
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
        this.btnCancel.Location = new Point(310, 180);
        this.btnCancel.Margin = new Padding(4, 6, 4, 6);
        this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCancel.Size = new Size(100, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Type = MaterialButton.MaterialButtonType.Text;
        this.btnCancel.UseAccentColor = false;
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblTheme, this.grpTheme, this.btnSave, this.btnCancel
        });
        
        // SettingsForm
        this.ClientSize = new Size(450, 280);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Ayarlar";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelContent.ResumeLayout(false);
        this.panelContent.PerformLayout();
        this.grpTheme.ResumeLayout(false);
        this.grpTheme.PerformLayout();
        this.ResumeLayout(false);
    }
}

