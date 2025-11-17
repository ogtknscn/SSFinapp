using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class StockTransactionForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvTransactions;
    private MaterialButton btnAdd;
    private MaterialButton btnEdit;
    private MaterialButton btnDelete;
    private MaterialButton btnRefresh;
    private MaterialButton btnClose;
    private MaterialComboBox cmbProductFilter;
    private MaterialComboBox cmbTypeFilter;
    private MaterialLabel lblProductFilter;
    private MaterialLabel lblTypeFilter;
    private MaterialLabel lblTitle;
    private MaterialLabel lblTotalCount;
    private Panel panelTop;
    private Panel panelBottom;
    
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
        this.dgvTransactions = new DataGridView();
        this.btnAdd = new MaterialButton();
        this.btnEdit = new MaterialButton();
        this.btnDelete = new MaterialButton();
        this.btnRefresh = new MaterialButton();
        this.btnClose = new MaterialButton();
        this.cmbProductFilter = new MaterialComboBox();
        this.cmbTypeFilter = new MaterialComboBox();
        this.lblProductFilter = new MaterialLabel();
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
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Controls.Add(this.lblProductFilter);
        this.panelTop.Controls.Add(this.cmbProductFilter);
        this.panelTop.Controls.Add(this.lblTypeFilter);
        this.panelTop.Controls.Add(this.cmbTypeFilter);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(1200, 80);
        this.panelTop.TabIndex = 0;
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(130, 19);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Stok Hareketleri";
        
        // lblProductFilter
        this.lblProductFilter.AutoSize = true;
        this.lblProductFilter.Depth = 0;
        this.lblProductFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblProductFilter.FontType = MaterialSkinManager.fontType.Body1;
        this.lblProductFilter.ForeColor = Color.White;
        this.lblProductFilter.Location = new Point(450, 30);
        this.lblProductFilter.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblProductFilter.Name = "lblProductFilter";
        this.lblProductFilter.Size = new Size(35, 19);
        this.lblProductFilter.TabIndex = 1;
        this.lblProductFilter.Text = "Ürün:";
        
        // cmbProductFilter
        this.cmbProductFilter.AutoResize = false;
        this.cmbProductFilter.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbProductFilter.Depth = 0;
        this.cmbProductFilter.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbProductFilter.DropDownHeight = 174;
        this.cmbProductFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbProductFilter.DropDownWidth = 250;
        this.cmbProductFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbProductFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbProductFilter.FormattingEnabled = true;
        this.cmbProductFilter.Hint = "";
        this.cmbProductFilter.IntegralHeight = false;
        this.cmbProductFilter.ItemHeight = 43;
        this.cmbProductFilter.Location = new Point(505, 25);
        this.cmbProductFilter.MaxDropDownItems = 4;
        this.cmbProductFilter.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbProductFilter.Name = "cmbProductFilter";
        this.cmbProductFilter.Size = new Size(250, 49);
        this.cmbProductFilter.StartIndex = 0;
        this.cmbProductFilter.TabIndex = 2;
        this.cmbProductFilter.SelectedIndexChanged += new EventHandler(this.cmbProductFilter_SelectedIndexChanged);
        
        // lblTypeFilter
        this.lblTypeFilter.AutoSize = true;
        this.lblTypeFilter.Depth = 0;
        this.lblTypeFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTypeFilter.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTypeFilter.ForeColor = Color.White;
        this.lblTypeFilter.Location = new Point(780, 30);
        this.lblTypeFilter.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTypeFilter.Name = "lblTypeFilter";
        this.lblTypeFilter.Size = new Size(70, 19);
        this.lblTypeFilter.TabIndex = 3;
        this.lblTypeFilter.Text = "İşlem Tipi:";
        
        // cmbTypeFilter
        this.cmbTypeFilter.AutoResize = false;
        this.cmbTypeFilter.BackColor = Color.FromArgb(255, 255, 255);
        this.cmbTypeFilter.Depth = 0;
        this.cmbTypeFilter.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbTypeFilter.DropDownHeight = 174;
        this.cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbTypeFilter.DropDownWidth = 150;
        this.cmbTypeFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.cmbTypeFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
        this.cmbTypeFilter.FormattingEnabled = true;
        this.cmbTypeFilter.Hint = "";
        this.cmbTypeFilter.IntegralHeight = false;
        this.cmbTypeFilter.ItemHeight = 43;
        this.cmbTypeFilter.Items.AddRange(new object[] { "Tümü", "Giriş", "Çıkış" });
        this.cmbTypeFilter.Location = new Point(865, 25);
        this.cmbTypeFilter.MaxDropDownItems = 4;
        this.cmbTypeFilter.MouseState = MaterialSkin.MouseState.OUT;
        this.cmbTypeFilter.Name = "cmbTypeFilter";
        this.cmbTypeFilter.SelectedIndex = 0;
        this.cmbTypeFilter.Size = new Size(150, 49);
        this.cmbTypeFilter.StartIndex = 0;
        this.cmbTypeFilter.TabIndex = 4;
        this.cmbTypeFilter.SelectedIndexChanged += new EventHandler(this.cmbTypeFilter_SelectedIndexChanged);
        
        // dgvTransactions
        this.dgvTransactions.AllowUserToAddRows = false;
        this.dgvTransactions.AllowUserToDeleteRows = false;
        this.dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTransactions.BackgroundColor = Color.White;
        this.dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvTransactions.Dock = DockStyle.Fill;
        this.dgvTransactions.Location = new Point(0, 80);
        this.dgvTransactions.MultiSelect = false;
        this.dgvTransactions.Name = "dgvTransactions";
        this.dgvTransactions.ReadOnly = true;
        this.dgvTransactions.RowHeadersWidth = 51;
        this.dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvTransactions.Size = new Size(1200, 420);
        this.dgvTransactions.TabIndex = 1;
        
        // panelBottom
        this.panelBottom.BackColor = Color.WhiteSmoke;
        this.panelBottom.Controls.Add(this.lblTotalCount);
        this.panelBottom.Controls.Add(this.btnAdd);
        this.panelBottom.Controls.Add(this.btnEdit);
        this.panelBottom.Controls.Add(this.btnDelete);
        this.panelBottom.Controls.Add(this.btnRefresh);
        this.panelBottom.Controls.Add(this.btnClose);
        this.panelBottom.Dock = DockStyle.Bottom;
        this.panelBottom.Location = new Point(0, 500);
        this.panelBottom.Name = "panelBottom";
        this.panelBottom.Size = new Size(1200, 80);
        this.panelBottom.TabIndex = 2;
        
        // lblTotalCount
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Depth = 0;
        this.lblTotalCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTotalCount.FontType = MaterialSkinManager.fontType.Body1;
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new Size(100, 19);
        this.lblTotalCount.TabIndex = 0;
        this.lblTotalCount.Text = "Toplam: 0 işlem";
        
        // btnAdd
        this.btnAdd.AutoSize = false;
        this.btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnAdd.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnAdd.Depth = 0;
        this.btnAdd.HighEmphasis = true;
        this.btnAdd.Icon = null;
        this.btnAdd.Location = new Point(600, 20);
        this.btnAdd.Margin = new Padding(4, 6, 4, 6);
        this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.NoAccentTextColor = Color.Empty;
        this.btnAdd.Size = new Size(120, 40);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "➕ Yeni İşlem";
        this.btnAdd.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnAdd.UseAccentColor = false;
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
        
        // btnEdit
        this.btnEdit.AutoSize = false;
        this.btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnEdit.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnEdit.Depth = 0;
        this.btnEdit.HighEmphasis = true;
        this.btnEdit.Icon = null;
        this.btnEdit.Location = new Point(730, 20);
        this.btnEdit.Margin = new Padding(4, 6, 4, 6);
        this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.NoAccentTextColor = Color.Empty;
        this.btnEdit.Size = new Size(100, 40);
        this.btnEdit.TabIndex = 2;
        this.btnEdit.Text = "✏️ Düzenle";
        this.btnEdit.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnEdit.UseAccentColor = false;
        this.btnEdit.UseVisualStyleBackColor = true;
        this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
        
        // btnDelete
        this.btnDelete.AutoSize = false;
        this.btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnDelete.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnDelete.Depth = 0;
        this.btnDelete.HighEmphasis = true;
        this.btnDelete.Icon = null;
        this.btnDelete.Location = new Point(840, 20);
        this.btnDelete.Margin = new Padding(4, 6, 4, 6);
        this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.NoAccentTextColor = Color.Empty;
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.TabIndex = 3;
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnDelete.UseAccentColor = true;
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
        
        // btnRefresh
        this.btnRefresh.AutoSize = false;
        this.btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnRefresh.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnRefresh.Depth = 0;
        this.btnRefresh.HighEmphasis = false;
        this.btnRefresh.Icon = null;
        this.btnRefresh.Location = new Point(950, 20);
        this.btnRefresh.Margin = new Padding(4, 6, 4, 6);
        this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.NoAccentTextColor = Color.Empty;
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.TabIndex = 4;
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.Type = MaterialButton.MaterialButtonType.Text;
        this.btnRefresh.UseAccentColor = false;
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
        
        // btnClose
        this.btnClose.AutoSize = false;
        this.btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnClose.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnClose.Depth = 0;
        this.btnClose.HighEmphasis = false;
        this.btnClose.Icon = null;
        this.btnClose.Location = new Point(1060, 20);
        this.btnClose.Margin = new Padding(4, 6, 4, 6);
        this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnClose.Name = "btnClose";
        this.btnClose.NoAccentTextColor = Color.Empty;
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.TabIndex = 5;
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.Type = MaterialButton.MaterialButtonType.Text;
        this.btnClose.UseAccentColor = false;
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new EventHandler(this.btnClose_Click);
        
        // StockTransactionForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1200, 580);
        this.Controls.Add(this.dgvTransactions);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.Name = "StockTransactionForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Stok Hareketleri";
        
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

