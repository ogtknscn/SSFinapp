namespace SSFinapp.UI.Forms;

partial class CurrentAccountForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvTransactions;
    private Button btnAdd, btnEdit, btnDelete, btnRefresh, btnClose;
    private ComboBox cmbCustomerFilter, cmbTypeFilter;
    private Label lblCustomerFilter, lblTypeFilter, lblTitle, lblTotalCount;
    private Panel panelTop, panelBottom;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
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
        this.cmbCustomerFilter = new ComboBox();
        this.cmbTypeFilter = new ComboBox();
        this.lblCustomerFilter = new Label();
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
        this.panelTop.Controls.AddRange(new Control[] {
            this.lblTitle, this.lblCustomerFilter, this.cmbCustomerFilter,
            this.lblTypeFilter, this.cmbTypeFilter
        });
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(1200, 80);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.Text = "Cari Hesap İşlemleri";
        
        // lblCustomerFilter
        this.lblCustomerFilter.AutoSize = true;
        this.lblCustomerFilter.Font = new Font("Segoe UI", 10F);
        this.lblCustomerFilter.ForeColor = Color.White;
        this.lblCustomerFilter.Location = new Point(450, 30);
        this.lblCustomerFilter.Text = "Müşteri:";
        
        // cmbCustomerFilter
        this.cmbCustomerFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCustomerFilter.Font = new Font("Segoe UI", 10F);
        this.cmbCustomerFilter.Location = new Point(520, 27);
        this.cmbCustomerFilter.Size = new Size(280, 25);
        this.cmbCustomerFilter.SelectedIndexChanged += cmbCustomerFilter_SelectedIndexChanged;
        
        // lblTypeFilter
        this.lblTypeFilter.AutoSize = true;
        this.lblTypeFilter.Font = new Font("Segoe UI", 10F);
        this.lblTypeFilter.ForeColor = Color.White;
        this.lblTypeFilter.Location = new Point(820, 30);
        this.lblTypeFilter.Text = "Tip:";
        
        // cmbTypeFilter
        this.cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbTypeFilter.Font = new Font("Segoe UI", 10F);
        this.cmbTypeFilter.Items.AddRange(new object[] { "Tümü", "Para", "Mal" });
        this.cmbTypeFilter.Location = new Point(865, 27);
        this.cmbTypeFilter.SelectedIndex = 0;
        this.cmbTypeFilter.Size = new Size(150, 25);
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
        this.lblTotalCount.Font = new Font("Segoe UI", 10F);
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.Text = "Toplam: 0 işlem";
        
        // btnAdd
        this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
        this.btnAdd.FlatStyle = FlatStyle.Flat;
        this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnAdd.ForeColor = Color.White;
        this.btnAdd.Location = new Point(650, 20);
        this.btnAdd.Size = new Size(120, 40);
        this.btnAdd.Text = "➕ Yeni İşlem";
        this.btnAdd.Click += btnAdd_Click;
        
        // btnEdit
        this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
        this.btnEdit.FlatStyle = FlatStyle.Flat;
        this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnEdit.ForeColor = Color.White;
        this.btnEdit.Location = new Point(780, 20);
        this.btnEdit.Size = new Size(100, 40);
        this.btnEdit.Text = "✏️ Düzenle";
        this.btnEdit.Click += btnEdit_Click;
        
        // btnDelete
        this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
        this.btnDelete.FlatStyle = FlatStyle.Flat;
        this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnDelete.ForeColor = Color.White;
        this.btnDelete.Location = new Point(890, 20);
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.Click += btnDelete_Click;
        
        // btnRefresh
        this.btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
        this.btnRefresh.FlatStyle = FlatStyle.Flat;
        this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnRefresh.ForeColor = Color.White;
        this.btnRefresh.Location = new Point(1000, 20);
        this.btnRefresh.Size = new Size(80, 40);
        this.btnRefresh.Text = "🔄";
        this.btnRefresh.Click += btnRefresh_Click;
        
        // btnClose
        this.btnClose.BackColor = Color.FromArgb(127, 140, 141);
        this.btnClose.FlatStyle = FlatStyle.Flat;
        this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnClose.ForeColor = Color.White;
        this.btnClose.Location = new Point(1090, 20);
        this.btnClose.Size = new Size(80, 40);
        this.btnClose.Text = "❌";
        this.btnClose.Click += btnClose_Click;
        
        // CurrentAccountForm
        this.ClientSize = new Size(1200, 580);
        this.Controls.Add(this.dgvTransactions);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Cari Hesap İşlemleri";
        
        ((System.ComponentModel.ISupportInitialize)this.dgvTransactions).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelBottom.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}

