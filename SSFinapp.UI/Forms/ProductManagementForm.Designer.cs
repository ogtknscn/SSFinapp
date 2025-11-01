namespace SSFinapp.UI.Forms;

partial class ProductManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvProducts;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Button btnRefresh;
    private Button btnClose;
    private Button btnViewStock;
    private Button btnExport;
    private TextBox txtSearch;
    private Label lblSearch;
    private Label lblTitle;
    private Label lblTotalCount;
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
        this.btnAdd = new Button();
        this.btnEdit = new Button();
        this.btnDelete = new Button();
        this.btnRefresh = new Button();
        this.btnExport = new Button();
        this.btnClose = new Button();
        this.btnViewStock = new Button();
        this.txtSearch = new TextBox();
        this.lblSearch = new Label();
        this.lblTitle = new Label();
        this.lblTotalCount = new Label();
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
        this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(180, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Ürün Yönetimi";
        
        // lblSearch
        this.lblSearch.AutoSize = true;
        this.lblSearch.Font = new Font("Segoe UI", 10F);
        this.lblSearch.ForeColor = Color.White;
        this.lblSearch.Location = new Point(600, 25);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new Size(40, 19);
        this.lblSearch.TabIndex = 1;
        this.lblSearch.Text = "Ara:";
        
        // txtSearch
        this.txtSearch.Font = new Font("Segoe UI", 10F);
        this.txtSearch.Location = new Point(650, 22);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(300, 25);
        this.txtSearch.TabIndex = 2;
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
        this.lblTotalCount.Font = new Font("Segoe UI", 10F);
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new Size(100, 19);
        this.lblTotalCount.TabIndex = 0;
        this.lblTotalCount.Text = "Toplam: 0 ürün";
        
        // btnAdd
        this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
        this.btnAdd.FlatStyle = FlatStyle.Flat;
        this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnAdd.ForeColor = Color.White;
        this.btnAdd.Location = new Point(390, 20);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new Size(100, 40);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "➕ Ekle";
        this.btnAdd.UseVisualStyleBackColor = false;
        this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
        
        // btnEdit
        this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
        this.btnEdit.FlatStyle = FlatStyle.Flat;
        this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnEdit.ForeColor = Color.White;
        this.btnEdit.Location = new Point(500, 20);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new Size(100, 40);
        this.btnEdit.TabIndex = 2;
        this.btnEdit.Text = "✏️ Düzenle";
        this.btnEdit.UseVisualStyleBackColor = false;
        this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
        
        // btnDelete
        this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
        this.btnDelete.FlatStyle = FlatStyle.Flat;
        this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnDelete.ForeColor = Color.White;
        this.btnDelete.Location = new Point(610, 20);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.TabIndex = 3;
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.UseVisualStyleBackColor = false;
        this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
        
        // btnViewStock
        this.btnViewStock.BackColor = Color.FromArgb(155, 89, 182);
        this.btnViewStock.FlatStyle = FlatStyle.Flat;
        this.btnViewStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnViewStock.ForeColor = Color.White;
        this.btnViewStock.Location = new Point(580, 20);
        this.btnViewStock.Name = "btnViewStock";
        this.btnViewStock.Size = new Size(120, 40);
        this.btnViewStock.TabIndex = 4;
        this.btnViewStock.Text = "📦 Stok Bilgisi";
        this.btnViewStock.UseVisualStyleBackColor = false;
        this.btnViewStock.Click += new EventHandler(this.btnViewStock_Click);
        
        // btnRefresh
        this.btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
        this.btnRefresh.FlatStyle = FlatStyle.Flat;
        this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnRefresh.ForeColor = Color.White;
        this.btnRefresh.Location = new Point(710, 20);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.TabIndex = 5;
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.UseVisualStyleBackColor = false;
        this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
        
        // btnExport
        this.btnExport.BackColor = Color.FromArgb(39, 174, 96);
        this.btnExport.FlatStyle = FlatStyle.Flat;
        this.btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnExport.ForeColor = Color.White;
        this.btnExport.Location = new Point(250, 20);
        this.btnExport.Name = "btnExport";
        this.btnExport.Size = new Size(130, 40);
        this.btnExport.TabIndex = 7;
        this.btnExport.Text = "📊 Excel'e Aktar";
        this.btnExport.UseVisualStyleBackColor = false;
        this.btnExport.Click += new EventHandler(this.btnExport_Click);
        
        // btnClose
        this.btnClose.BackColor = Color.FromArgb(127, 140, 141);
        this.btnClose.FlatStyle = FlatStyle.Flat;
        this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnClose.ForeColor = Color.White;
        this.btnClose.Location = new Point(870, 20);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.UseVisualStyleBackColor = false;
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
        ((System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.panelBottom.PerformLayout();
        this.ResumeLayout(false);
    }
}

