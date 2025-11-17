using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class CustomerManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvCustomers;
    private MaterialButton btnAdd, btnEdit, btnDelete, btnViewBalance, btnRefresh, btnClose;
    private MaterialTextBox txtSearch;
    private MaterialLabel lblSearch, lblTitle, lblTotalCount;
    private Panel panelTop, panelBottom;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.dgvCustomers = new DataGridView();
        this.btnAdd = new MaterialButton();
        this.btnEdit = new MaterialButton();
        this.btnDelete = new MaterialButton();
        this.btnViewBalance = new MaterialButton();
        this.btnRefresh = new MaterialButton();
        this.btnClose = new MaterialButton();
        this.txtSearch = new MaterialTextBox();
        this.lblSearch = new MaterialLabel();
        this.lblTitle = new MaterialLabel();
        this.lblTotalCount = new MaterialLabel();
        this.panelTop = new Panel();
        this.panelBottom = new Panel();
        
        ((System.ComponentModel.ISupportInitialize)this.dgvCustomers).BeginInit();
        this.panelTop.SuspendLayout();
        this.panelBottom.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Controls.Add(this.lblSearch);
        this.panelTop.Controls.Add(this.txtSearch);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(1000, 80);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Text = "Müşteri Yönetimi";
        
        // lblSearch
        this.lblSearch.AutoSize = true;
        this.lblSearch.Depth = 0;
        this.lblSearch.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblSearch.FontType = MaterialSkinManager.fontType.Body1;
        this.lblSearch.ForeColor = Color.White;
        this.lblSearch.Location = new Point(600, 30);
        this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblSearch.Text = "Ara:";
        
        // txtSearch
        this.txtSearch.AnimateReadOnly = false;
        this.txtSearch.BorderStyle = BorderStyle.None;
        this.txtSearch.Depth = 0;
        this.txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtSearch.Hint = "";
        this.txtSearch.LeadingIcon = null;
        this.txtSearch.Location = new Point(650, 27);
        this.txtSearch.MaxLength = 32767;
        this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
        this.txtSearch.Multiline = false;
        this.txtSearch.Size = new Size(300, 50);
        this.txtSearch.Text = "";
        this.txtSearch.TrailingIcon = null;
        this.txtSearch.UseAccent = false;
        this.txtSearch.TextChanged += txtSearch_TextChanged;
        
        // dgvCustomers
        this.dgvCustomers.AllowUserToAddRows = false;
        this.dgvCustomers.AllowUserToDeleteRows = false;
        this.dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvCustomers.BackgroundColor = Color.White;
        this.dgvCustomers.Dock = DockStyle.Fill;
        this.dgvCustomers.Location = new Point(0, 80);
        this.dgvCustomers.MultiSelect = false;
        this.dgvCustomers.ReadOnly = true;
        this.dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvCustomers.Size = new Size(1000, 420);
        
        // panelBottom
        this.panelBottom.BackColor = Color.WhiteSmoke;
        this.panelBottom.Controls.Add(this.lblTotalCount);
        this.panelBottom.Controls.Add(this.btnAdd);
        this.panelBottom.Controls.Add(this.btnEdit);
        this.panelBottom.Controls.Add(this.btnDelete);
        this.panelBottom.Controls.Add(this.btnViewBalance);
        this.panelBottom.Controls.Add(this.btnRefresh);
        this.panelBottom.Controls.Add(this.btnClose);
        this.panelBottom.Dock = DockStyle.Bottom;
        this.panelBottom.Size = new Size(1000, 80);
        
        // lblTotalCount
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Depth = 0;
        this.lblTotalCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTotalCount.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTotalCount.Text = "Toplam: 0 müşteri";
        
        // btnAdd
        this.btnAdd.AutoSize = false;
        this.btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnAdd.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnAdd.Depth = 0;
        this.btnAdd.HighEmphasis = true;
        this.btnAdd.Icon = null;
        this.btnAdd.Location = new Point(250, 20);
        this.btnAdd.Margin = new Padding(4, 6, 4, 6);
        this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAdd.Size = new Size(100, 40);
        this.btnAdd.Text = "➕ Ekle";
        this.btnAdd.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnAdd.UseAccentColor = false;
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += btnAdd_Click;
        
        // btnEdit
        this.btnEdit.AutoSize = false;
        this.btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnEdit.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnEdit.Depth = 0;
        this.btnEdit.HighEmphasis = true;
        this.btnEdit.Icon = null;
        this.btnEdit.Location = new Point(360, 20);
        this.btnEdit.Margin = new Padding(4, 6, 4, 6);
        this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnEdit.Size = new Size(100, 40);
        this.btnEdit.Text = "✏️ Düzenle";
        this.btnEdit.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnEdit.UseAccentColor = false;
        this.btnEdit.UseVisualStyleBackColor = true;
        this.btnEdit.Click += btnEdit_Click;
        
        // btnDelete
        this.btnDelete.AutoSize = false;
        this.btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnDelete.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnDelete.Depth = 0;
        this.btnDelete.HighEmphasis = true;
        this.btnDelete.Icon = null;
        this.btnDelete.Location = new Point(470, 20);
        this.btnDelete.Margin = new Padding(4, 6, 4, 6);
        this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnDelete.UseAccentColor = true;
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += btnDelete_Click;
        
        // btnViewBalance
        this.btnViewBalance.AutoSize = false;
        this.btnViewBalance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnViewBalance.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnViewBalance.Depth = 0;
        this.btnViewBalance.HighEmphasis = true;
        this.btnViewBalance.Icon = null;
        this.btnViewBalance.Location = new Point(580, 20);
        this.btnViewBalance.Margin = new Padding(4, 6, 4, 6);
        this.btnViewBalance.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnViewBalance.Size = new Size(120, 40);
        this.btnViewBalance.Text = "💰 Bakiye";
        this.btnViewBalance.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnViewBalance.UseAccentColor = false;
        this.btnViewBalance.UseVisualStyleBackColor = true;
        this.btnViewBalance.Click += btnViewBalance_Click;
        
        // btnRefresh
        this.btnRefresh.AutoSize = false;
        this.btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnRefresh.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnRefresh.Depth = 0;
        this.btnRefresh.HighEmphasis = false;
        this.btnRefresh.Icon = null;
        this.btnRefresh.Location = new Point(710, 20);
        this.btnRefresh.Margin = new Padding(4, 6, 4, 6);
        this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.Type = MaterialButton.MaterialButtonType.Text;
        this.btnRefresh.UseAccentColor = false;
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += btnRefresh_Click;
        
        // btnClose
        this.btnClose.AutoSize = false;
        this.btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnClose.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnClose.Depth = 0;
        this.btnClose.HighEmphasis = false;
        this.btnClose.Icon = null;
        this.btnClose.Location = new Point(870, 20);
        this.btnClose.Margin = new Padding(4, 6, 4, 6);
        this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.Type = MaterialButton.MaterialButtonType.Text;
        this.btnClose.UseAccentColor = false;
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += btnClose_Click;
        
        // CustomerManagementForm
        this.ClientSize = new Size(1000, 580);
        this.Controls.Add(this.dgvCustomers);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Müşteri Yönetimi";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        
        ((System.ComponentModel.ISupportInitialize)this.dgvCustomers).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.panelBottom.PerformLayout();
        this.ResumeLayout(false);
    }
}
