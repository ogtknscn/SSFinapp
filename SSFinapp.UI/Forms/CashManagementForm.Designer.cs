using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class CashManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvTransactions;
    private MaterialButton btnAdd, btnEdit, btnDelete, btnRefresh, btnClose;
    private MaterialComboBox cmbCashAccountFilter, cmbTypeFilter;
    private MaterialLabel lblCashAccountFilter, lblTypeFilter, lblTitle, lblTotalCount;
    private Panel panelTop, panelBottom;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.dgvTransactions = new DataGridView();
        this.btnAdd = new MaterialButton();
        this.btnEdit = new MaterialButton();
        this.btnDelete = new MaterialButton();
        this.btnRefresh = new MaterialButton();
        this.btnClose = new MaterialButton();
        this.cmbCashAccountFilter = new MaterialComboBox();
        this.cmbTypeFilter = new MaterialComboBox();
        this.lblCashAccountFilter = new MaterialLabel();
        this.lblTypeFilter = new MaterialLabel();
        this.lblTitle = new MaterialLabel();
        this.lblTotalCount = new MaterialLabel();
        this.panelTop = new Panel();
        this.panelBottom = new Panel();
        
        ((System.ComponentModel.ISupportInitialize)this.dgvTransactions).BeginInit();
        this.panelTop.SuspendLayout();
        this.panelBottom.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.AddRange(new Control[] {
            this.lblTitle, this.lblCashAccountFilter, this.cmbCashAccountFilter,
            this.lblTypeFilter, this.cmbTypeFilter
        });
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(1200, 80);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Text = "Kasa İşlemleri";
        
        // lblCashAccountFilter
        this.lblCashAccountFilter.AutoSize = true;
        this.lblCashAccountFilter.Depth = 0;
        this.lblCashAccountFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblCashAccountFilter.FontType = MaterialSkinManager.fontType.Body1;
        this.lblCashAccountFilter.ForeColor = Color.White;
        this.lblCashAccountFilter.Location = new Point(450, 30);
        this.lblCashAccountFilter.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblCashAccountFilter.Text = "Kasa:";
        
        // cmbCashAccountFilter
        this.cmbCashAccountFilter.AutoResize = false;
        this.cmbCashAccountFilter.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbCashAccountFilter.Depth = 0;
        this.cmbCashAccountFilter.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbCashAccountFilter.DropDownHeight = 174;
        this.cmbCashAccountFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCashAccountFilter.DropDownWidth = 121;
        this.cmbCashAccountFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbCashAccountFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbCashAccountFilter.FormattingEnabled = true;
        this.cmbCashAccountFilter.Hint = "";
        this.cmbCashAccountFilter.IntegralHeight = false;
        this.cmbCashAccountFilter.ItemHeight = 43;
        this.cmbCashAccountFilter.Location = new Point(520, 27);
        this.cmbCashAccountFilter.MaxDropDownItems = 4;
        this.cmbCashAccountFilter.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbCashAccountFilter.Size = new Size(280, 49);
        this.cmbCashAccountFilter.StartIndex = 0;
        this.cmbCashAccountFilter.SelectedIndexChanged += cmbCashAccountFilter_SelectedIndexChanged;
        
        // lblTypeFilter
        this.lblTypeFilter.AutoSize = true;
        this.lblTypeFilter.Depth = 0;
        this.lblTypeFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTypeFilter.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTypeFilter.ForeColor = Color.White;
        this.lblTypeFilter.Location = new Point(820, 30);
        this.lblTypeFilter.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTypeFilter.Text = "Tip:";
        
        // cmbTypeFilter
        this.cmbTypeFilter.AutoResize = false;
        this.cmbTypeFilter.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbTypeFilter.Depth = 0;
        this.cmbTypeFilter.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbTypeFilter.DropDownHeight = 174;
        this.cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbTypeFilter.DropDownWidth = 121;
        this.cmbTypeFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbTypeFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbTypeFilter.FormattingEnabled = true;
        this.cmbTypeFilter.Hint = "";
        this.cmbTypeFilter.IntegralHeight = false;
        this.cmbTypeFilter.ItemHeight = 43;
        this.cmbTypeFilter.Items.AddRange(new object[] { "Tümü", "Giriş", "Çıkış", "Transfer" });
        this.cmbTypeFilter.Location = new Point(865, 27);
        this.cmbTypeFilter.MaxDropDownItems = 4;
        this.cmbTypeFilter.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbTypeFilter.SelectedIndex = 0;
        this.cmbTypeFilter.Size = new Size(150, 49);
        this.cmbTypeFilter.StartIndex = 0;
        this.cmbTypeFilter.SelectedIndexChanged += cmbTypeFilter_SelectedIndexChanged;
        
        // dgvTransactions
        this.dgvTransactions.AllowUserToAddRows = false;
        this.dgvTransactions.AllowUserToDeleteRows = false;
        this.dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTransactions.BackgroundColor = Color.White;
        this.dgvTransactions.Dock = DockStyle.Fill;
        this.dgvTransactions.Location = new Point(0, 80);
        this.dgvTransactions.MultiSelect = false;
        this.dgvTransactions.ReadOnly = true;
        this.dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvTransactions.Size = new Size(1200, 420);
        
        // panelBottom
        this.panelBottom.BackColor = Color.WhiteSmoke;
        this.panelBottom.Controls.AddRange(new Control[] {
            this.lblTotalCount, this.btnAdd, this.btnEdit, this.btnDelete,
            this.btnRefresh, this.btnClose
        });
        this.panelBottom.Dock = DockStyle.Bottom;
        this.panelBottom.Size = new Size(1200, 80);
        
        // lblTotalCount
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Depth = 0;
        this.lblTotalCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTotalCount.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTotalCount.Text = "Toplam: 0 işlem";
        
        // btnAdd
        this.btnAdd.AutoSize = false;
        this.btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnAdd.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnAdd.Depth = 0;
        this.btnAdd.HighEmphasis = true;
        this.btnAdd.Icon = null;
        this.btnAdd.Location = new Point(650, 20);
        this.btnAdd.Margin = new Padding(4, 6, 4, 6);
        this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAdd.Size = new Size(120, 40);
        this.btnAdd.Text = "➕ Yeni İşlem";
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
        this.btnEdit.Location = new Point(780, 20);
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
        this.btnDelete.Location = new Point(890, 20);
        this.btnDelete.Margin = new Padding(4, 6, 4, 6);
        this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnDelete.UseAccentColor = true;
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += btnDelete_Click;
        
        // btnRefresh
        this.btnRefresh.AutoSize = false;
        this.btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnRefresh.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnRefresh.Depth = 0;
        this.btnRefresh.HighEmphasis = false;
        this.btnRefresh.Icon = null;
        this.btnRefresh.Location = new Point(1000, 20);
        this.btnRefresh.Margin = new Padding(4, 6, 4, 6);
        this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnRefresh.Size = new Size(80, 40);
        this.btnRefresh.Text = "🔄";
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
        this.btnClose.Location = new Point(1090, 20);
        this.btnClose.Margin = new Padding(4, 6, 4, 6);
        this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnClose.Size = new Size(80, 40);
        this.btnClose.Text = "❌";
        this.btnClose.Type = MaterialButton.MaterialButtonType.Text;
        this.btnClose.UseAccentColor = false;
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += btnClose_Click;
        
        // CashManagementForm
        this.ClientSize = new Size(1200, 580);
        this.Controls.Add(this.dgvTransactions);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Kasa İşlemleri";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        
        ((System.ComponentModel.ISupportInitialize)this.dgvTransactions).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.panelBottom.PerformLayout();
        this.ResumeLayout(false);
    }
}

