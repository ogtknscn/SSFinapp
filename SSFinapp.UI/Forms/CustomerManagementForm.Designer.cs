namespace SSFinapp.UI.Forms;

partial class CustomerManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgvCustomers;
    private Button btnAdd, btnEdit, btnDelete, btnViewBalance, btnRefresh, btnClose;
    private TextBox txtSearch;
    private Label lblSearch, lblTitle, lblTotalCount;
    private Panel panelTop, panelBottom;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.dgvCustomers = new DataGridView();
        this.btnAdd = new Button();
        this.btnEdit = new Button();
        this.btnDelete = new Button();
        this.btnViewBalance = new Button();
        this.btnRefresh = new Button();
        this.btnClose = new Button();
        this.txtSearch = new TextBox();
        this.lblSearch = new Label();
        this.lblTitle = new Label();
        this.lblTotalCount = new Label();
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
        this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 25);
        this.lblTitle.Text = "Müşteri Yönetimi";
        
        // lblSearch
        this.lblSearch.AutoSize = true;
        this.lblSearch.Font = new Font("Segoe UI", 10F);
        this.lblSearch.ForeColor = Color.White;
        this.lblSearch.Location = new Point(600, 30);
        this.lblSearch.Text = "Ara:";
        
        // txtSearch
        this.txtSearch.Font = new Font("Segoe UI", 10F);
        this.txtSearch.Location = new Point(650, 27);
        this.txtSearch.Size = new Size(300, 25);
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
        this.lblTotalCount.Font = new Font("Segoe UI", 10F);
        this.lblTotalCount.Location = new Point(20, 30);
        this.lblTotalCount.Text = "Toplam: 0 müşteri";
        
        // btnAdd
        this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
        this.btnAdd.FlatStyle = FlatStyle.Flat;
        this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnAdd.ForeColor = Color.White;
        this.btnAdd.Location = new Point(250, 20);
        this.btnAdd.Size = new Size(100, 40);
        this.btnAdd.Text = "➕ Ekle";
        this.btnAdd.Click += btnAdd_Click;
        
        // btnEdit
        this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
        this.btnEdit.FlatStyle = FlatStyle.Flat;
        this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnEdit.ForeColor = Color.White;
        this.btnEdit.Location = new Point(360, 20);
        this.btnEdit.Size = new Size(100, 40);
        this.btnEdit.Text = "✏️ Düzenle";
        this.btnEdit.Click += btnEdit_Click;
        
        // btnDelete
        this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
        this.btnDelete.FlatStyle = FlatStyle.Flat;
        this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnDelete.ForeColor = Color.White;
        this.btnDelete.Location = new Point(470, 20);
        this.btnDelete.Size = new Size(100, 40);
        this.btnDelete.Text = "🗑️ Sil";
        this.btnDelete.Click += btnDelete_Click;
        
        // btnViewBalance
        this.btnViewBalance.BackColor = Color.FromArgb(155, 89, 182);
        this.btnViewBalance.FlatStyle = FlatStyle.Flat;
        this.btnViewBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnViewBalance.ForeColor = Color.White;
        this.btnViewBalance.Location = new Point(580, 20);
        this.btnViewBalance.Size = new Size(120, 40);
        this.btnViewBalance.Text = "💰 Bakiye";
        this.btnViewBalance.Click += btnViewBalance_Click;
        
        // btnRefresh
        this.btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
        this.btnRefresh.FlatStyle = FlatStyle.Flat;
        this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnRefresh.ForeColor = Color.White;
        this.btnRefresh.Location = new Point(710, 20);
        this.btnRefresh.Size = new Size(100, 40);
        this.btnRefresh.Text = "🔄 Yenile";
        this.btnRefresh.Click += btnRefresh_Click;
        
        // btnClose
        this.btnClose.BackColor = Color.FromArgb(127, 140, 141);
        this.btnClose.FlatStyle = FlatStyle.Flat;
        this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnClose.ForeColor = Color.White;
        this.btnClose.Location = new Point(870, 20);
        this.btnClose.Size = new Size(100, 40);
        this.btnClose.Text = "❌ Kapat";
        this.btnClose.Click += btnClose_Click;
        
        // CustomerManagementForm
        this.ClientSize = new Size(1000, 580);
        this.Controls.Add(this.dgvCustomers);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelTop);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Müşteri Yönetimi";
        
        ((System.ComponentModel.ISupportInitialize)this.dgvCustomers).EndInit();
        this.panelTop.ResumeLayout(false);
        this.panelBottom.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}

