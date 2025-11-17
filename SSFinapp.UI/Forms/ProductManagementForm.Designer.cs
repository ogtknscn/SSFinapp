using MaterialSkin.Controls;

namespace SSFinapp.UI.Forms;

partial class ProductManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvProducts;
    private MaterialButton btnAdd;
    private MaterialButton btnEdit;
    private MaterialButton btnDelete;
    private MaterialButton btnRefresh;
    private MaterialButton btnClose;
    private MaterialButton btnViewStock;
    private MaterialButton btnExport;
    private MaterialTextBox txtSearch;
    private MaterialLabel lblSearch;
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
        this.dgvProducts = new DataGridView();
        this.btnAdd = new MaterialButton();
        this.btnEdit = new MaterialButton();
        this.btnDelete = new MaterialButton();
        this.btnRefresh = new MaterialButton();
        this.btnExport = new MaterialButton();
        this.btnClose = new MaterialButton();
        this.btnViewStock = new MaterialButton();
        this.txtSearch = new MaterialTextBox();
        this.lblSearch = new MaterialLabel();
        this.lblTitle = new MaterialLabel();
        this.lblTotalCount = new MaterialLabel();
        this.panelTop = new Panel();
        this.panelBottom = new Panel();
        
        ((System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
        this.panelTop.SuspendLayout();
        this.panelBottom.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Controls.Add(this.lblSearch);
        this.panelTop.Controls.Add(this.txtSearch);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(1000, 80);
        this.panelTop.TabIndex = 0;
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 15);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(130, 19);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Ürün Yönetimi";
        
        // lblSearch
        this.lblSearch.AutoSize = true;
        this.lblSearch.Depth = 0;
        this.lblSearch.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblSearch.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblSearch.ForeColor = Color.White;
        this.lblSearch.Location = new Point(600, 25);
        this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new Size(30, 19);
        this.lblSearch.TabIndex = 1;
        this.lblSearch.Text = "Ara:";
        
        // txtSearch
        this.txtSearch.AnimateReadOnly = false;
        this.txtSearch.BorderStyle = BorderStyle.None;
        this.txtSearch.Depth = 0;
        this.txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.txtSearch.Hint = "Ürün adı veya birim ile ara...";
        this.txtSearch.LeadingIcon = null;
        this.txtSearch.Location = new Point(650, 20);
        this.txtSearch.MaxLength = 32767;
        this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
        this.txtSearch.Multiline = false;
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(300, 50);
        this.txtSearch.TabIndex = 2;
        this.txtSearch.Text = "";
        this.txtSearch.TrailingIcon = null;
        this.txtSearch.UseAccent = false;
        this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
        
        // dgvProducts
        this.dgvProducts.AllowUserToAddRows = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.BackgroundColor = Color.White;
        this.dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvProducts.Dock = DockStyle.Fill;
        this.dgvProducts.Location = new Point(0, 80);
        this.dgvProducts.MultiSelect = false;
        this.dgvProducts.Name = "dgvProducts";
        this.dgvProducts.ReadOnly = true;
        this.dgvProducts.RowHeadersWidth = 51;
        this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.Size = new Size(1000, 420);
        this.dgvProducts.TabIndex = 1;
        
        // panelBottom
        this.panelBottom.BackColor = Color.WhiteSmoke;
        this.panelBottom.Controls.Add(this.lblTotalCount);
        this.panelBottom.Controls.Add(this.lblTotalCount);
        this.panelBottom.Controls.Add(this.btnExport);
        this.panelBottom.Controls.Add(this.btnAdd);
        this.panelBottom.Controls.Add(this.btnEdit);
        this.panelBottom.Controls.Add(this.btnDelete);
        this.panelBottom.Controls.Add(this.btnViewStock);
        this.panelBottom.Controls.Add(this.btnRefresh);
        this.panelBottom.Controls.Add(this.btnClose);
        this.panelBottom.Dock = DockStyle.Bottom;
        this.panelBottom.Location = new Point(0, 500);
        this.panelBottom.Name = "panelBottom";
        this.panelBottom.Size = new Size(1000, 80);
        this.panelBottom.TabIndex = 2;
        
        // lblTotalCount
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Depth = 0;
        this.lblTotalCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblTotalCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new Size(100, 19);
        this.lblTotalCount.TabIndex = 0;
        this.lblTotalCount.Text = "Toplam: 0 ürün";
        
        // btnAdd
        this.btnAdd.AutoSize = false;
        this.btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnAdd.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnAdd.Depth = 0;
        this.btnAdd.HighEmphasis = true;
        this.btnAdd.Icon = null;
        this.btnAdd.Location = new Point(390, 20);
        this.btnAdd.Margin = new Padding(4, 6, 4, 6);
        this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.NoAccentTextColor = Color.Empty;
        this.btnAdd.Size = new Size(100, 40);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "➕ Ekle";
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
        this.btnEdit.Location = new Point(500, 20);
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
        this.btnDelete.Location = new Point(610, 20);
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
        
        // btnViewStock
        this.btnViewStock.AutoSize = false;
        this.btnViewStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnViewStock.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnViewStock.Depth = 0;
        this.btnViewStock.HighEmphasis = false;
        this.btnViewStock.Icon = null;
        this.btnViewStock.Location = new Point(250, 20);
        this.btnViewStock.Margin = new Padding(4, 6, 4, 6);
        this.btnViewStock.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnViewStock.Name = "btnViewStock";
        this.btnViewStock.NoAccentTextColor = Color.Empty;
        this.btnViewStock.Size = new Size(120, 40);
        this.btnViewStock.TabIndex = 4;
        this.btnViewStock.Text = "📦 Stok Bilgisi";
        this.btnViewStock.Type = MaterialButton.MaterialButtonType.Outlined;
        this.btnViewStock.UseAccentColor = false;
        this.btnViewStock.UseVisualStyleBackColor = true;
        this.btnViewStock.Click += new EventHandler(this.btnViewStock_Click);
        
        // btnRefresh
        this.btnRefresh.AutoSize = false;
        this.btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnRefresh.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnRefresh.Depth = 0;
        this.btnRefresh.HighEmphasis = false;
        this.btnRefresh.Icon = null;
        this.btnRefresh.Location = new Point(720, 20);
        this.btnRefresh.Margin = new Padding(4, 6, 4, 6);
        this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.NoAccentTextColor = Color.Empty;
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.TabIndex = 5;
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.Type = MaterialButton.MaterialButtonType.Text;
        this.btnRefresh.UseAccentColor = false;
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
        
        // btnExport
        this.btnExport.AutoSize = false;
        this.btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnExport.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnExport.Depth = 0;
        this.btnExport.HighEmphasis = false;
        this.btnExport.Icon = null;
        this.btnExport.Location = new Point(120, 20);
        this.btnExport.Margin = new Padding(4, 6, 4, 6);
        this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnExport.Name = "btnExport";
        this.btnExport.NoAccentTextColor = Color.Empty;
        this.btnExport.Size = new Size(120, 40);
        this.btnExport.TabIndex = 7;
        this.btnExport.Text = "📊 Excel'e Aktar";
        this.btnExport.Type = MaterialButton.MaterialButtonType.Outlined;
        this.btnExport.UseAccentColor = false;
        this.btnExport.UseVisualStyleBackColor = true;
        this.btnExport.Click += new EventHandler(this.btnExport_Click);
        
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
        this.btnClose.Name = "btnClose";
        this.btnClose.NoAccentTextColor = Color.Empty;
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.Type = MaterialButton.MaterialButtonType.Text;
        this.btnClose.UseAccentColor = false;
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new EventHandler(this.btnClose_Click);
        
        // ProductManagementForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1000, 580);
        this.Controls.Add(this.dgvProducts);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.Name = "ProductManagementForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Ürün Yönetimi";
        
        // MaterialSkin Manager
        var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Blue200, MaterialSkin.TextShade.WHITE);
        
        ((System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.panelBottom.PerformLayout();
        this.ResumeLayout(false);
    }
}

