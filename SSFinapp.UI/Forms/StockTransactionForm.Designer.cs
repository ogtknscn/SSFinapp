namespace SSFinapp.UI.Forms;

partial class StockTransactionForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvTransactions;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Button btnRefresh;
    private Button btnClose;
    private ComboBox cmbProductFilter;
    private ComboBox cmbTypeFilter;
    private Label lblProductFilter;
    private Label lblTypeFilter;
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
        this.dgvTransactions = new DataGridView();
        this.btnAdd = new Button();
        this.btnEdit = new Button();
        this.btnDelete = new Button();
        this.btnRefresh = new Button();
        this.btnClose = new Button();
        this.cmbProductFilter = new ComboBox();
        this.cmbTypeFilter = new ComboBox();
        this.lblProductFilter = new Label();
        this.lblTypeFilter = new Label();
        this.lblTitle = new Label();
        this.lblTotalCount = new Label();
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
        this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(180, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Stok Hareketleri";
        
        // lblProductFilter
        this.lblProductFilter.AutoSize = true;
        this.lblProductFilter.Font = new Font("Segoe UI", 10F);
        this.lblProductFilter.ForeColor = Color.White;
        this.lblProductFilter.Location = new Point(450, 30);
        this.lblProductFilter.Name = "lblProductFilter";
        this.lblProductFilter.Size = new Size(45, 19);
        this.lblProductFilter.TabIndex = 1;
        this.lblProductFilter.Text = "Ürün:";
        
        // cmbProductFilter
        this.cmbProductFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbProductFilter.Font = new Font("Segoe UI", 10F);
        this.cmbProductFilter.Location = new Point(505, 27);
        this.cmbProductFilter.Name = "cmbProductFilter";
        this.cmbProductFilter.Size = new Size(250, 25);
        this.cmbProductFilter.TabIndex = 2;
        this.cmbProductFilter.SelectedIndexChanged += new EventHandler(this.cmbProductFilter_SelectedIndexChanged);
        
        // lblTypeFilter
        this.lblTypeFilter.AutoSize = true;
        this.lblTypeFilter.Font = new Font("Segoe UI", 10F);
        this.lblTypeFilter.ForeColor = Color.White;
        this.lblTypeFilter.Location = new Point(780, 30);
        this.lblTypeFilter.Name = "lblTypeFilter";
        this.lblTypeFilter.Size = new Size(77, 19);
        this.lblTypeFilter.TabIndex = 3;
        this.lblTypeFilter.Text = "İşlem Tipi:";
        
        // cmbTypeFilter
        this.cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbTypeFilter.Font = new Font("Segoe UI", 10F);
        this.cmbTypeFilter.Items.AddRange(new object[] { "Tümü", "Giriş", "Çıkış" });
        this.cmbTypeFilter.Location = new Point(865, 27);
        this.cmbTypeFilter.Name = "cmbTypeFilter";
        this.cmbTypeFilter.SelectedIndex = 0;
        this.cmbTypeFilter.Size = new Size(150, 25);
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
        this.lblTotalCount.Font = new Font("Segoe UI", 10F);
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new Size(110, 19);
        this.lblTotalCount.TabIndex = 0;
        this.lblTotalCount.Text = "Toplam: 0 işlem";
        
        // btnAdd
        this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
        this.btnAdd.FlatStyle = FlatStyle.Flat;
        this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnAdd.ForeColor = Color.White;
        this.btnAdd.Location = new Point(600, 20);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new Size(120, 40);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "➕ Yeni İşlem";
        this.btnAdd.UseVisualStyleBackColor = false;
        this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
        
        // btnEdit
        this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
        this.btnEdit.FlatStyle = FlatStyle.Flat;
        this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnEdit.ForeColor = Color.White;
        this.btnEdit.Location = new Point(730, 20);
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
        this.btnDelete.Location = new Point(840, 20);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.TabIndex = 3;
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.UseVisualStyleBackColor = false;
        this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
        
        // btnRefresh
        this.btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
        this.btnRefresh.FlatStyle = FlatStyle.Flat;
        this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnRefresh.ForeColor = Color.White;
        this.btnRefresh.Location = new Point(950, 20);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.TabIndex = 4;
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.UseVisualStyleBackColor = false;
        this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
        
        // btnClose
        this.btnClose.BackColor = Color.FromArgb(127, 140, 141);
        this.btnClose.FlatStyle = FlatStyle.Flat;
        this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnClose.ForeColor = Color.White;
        this.btnClose.Location = new Point(1060, 20);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.TabIndex = 5;
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.UseVisualStyleBackColor = false;
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
        ((System.ComponentModel.ISupportInitialize)this.dgvTransactions).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.panelBottom.PerformLayout();
        this.ResumeLayout(false);
    }
}

