namespace SSFinapp.UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblProductCount;
    private Label lblCustomerCount;
    private Button btnStockManagement;
    private Button btnCurrentAccount;
    private Button btnProducts;
    private Button btnCustomers;
    private Panel panelDashboard;
    private Panel panelMenu;
    
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
        this.lblTitle = new Label();
        this.lblProductCount = new Label();
        this.lblCustomerCount = new Label();
        this.btnStockManagement = new Button();
        this.btnCurrentAccount = new Button();
        this.btnProducts = new Button();
        this.btnCustomers = new Button();
        this.panelDashboard = new Panel();
        this.panelMenu = new Panel();
        
        this.panelDashboard.SuspendLayout();
        this.panelMenu.SuspendLayout();
        this.SuspendLayout();
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        this.lblTitle.Location = new Point(20, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(250, 32);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "S&S Finans Uygulaması";
        
        // lblProductCount
        this.lblProductCount.AutoSize = true;
        this.lblProductCount.Font = new Font("Segoe UI", 12F);
        this.lblProductCount.Location = new Point(20, 70);
        this.lblProductCount.Name = "lblProductCount";
        this.lblProductCount.Size = new Size(150, 21);
        this.lblProductCount.TabIndex = 1;
        this.lblProductCount.Text = "Toplam Ürün: 0";
        
        // lblCustomerCount
        this.lblCustomerCount.AutoSize = true;
        this.lblCustomerCount.Font = new Font("Segoe UI", 12F);
        this.lblCustomerCount.Location = new Point(20, 100);
        this.lblCustomerCount.Name = "lblCustomerCount";
        this.lblCustomerCount.Size = new Size(150, 21);
        this.lblCustomerCount.TabIndex = 2;
        this.lblCustomerCount.Text = "Toplam Müşteri: 0";
        
        // panelDashboard
        this.panelDashboard.BackColor = Color.WhiteSmoke;
        this.panelDashboard.Controls.Add(this.lblTitle);
        this.panelDashboard.Controls.Add(this.lblProductCount);
        this.panelDashboard.Controls.Add(this.lblCustomerCount);
        this.panelDashboard.Dock = DockStyle.Top;
        this.panelDashboard.Location = new Point(0, 0);
        this.panelDashboard.Name = "panelDashboard";
        this.panelDashboard.Size = new Size(800, 150);
        this.panelDashboard.TabIndex = 3;
        
        // btnStockManagement
        this.btnStockManagement.BackColor = Color.FromArgb(52, 152, 219);
        this.btnStockManagement.FlatStyle = FlatStyle.Flat;
        this.btnStockManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.btnStockManagement.ForeColor = Color.White;
        this.btnStockManagement.Location = new Point(20, 20);
        this.btnStockManagement.Name = "btnStockManagement";
        this.btnStockManagement.Size = new Size(200, 80);
        this.btnStockManagement.TabIndex = 0;
        this.btnStockManagement.Text = "Stok Yönetimi";
        this.btnStockManagement.UseVisualStyleBackColor = false;
        this.btnStockManagement.Click += new EventHandler(this.btnStockManagement_Click);
        
        // btnCurrentAccount
        this.btnCurrentAccount.BackColor = Color.FromArgb(46, 204, 113);
        this.btnCurrentAccount.FlatStyle = FlatStyle.Flat;
        this.btnCurrentAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.btnCurrentAccount.ForeColor = Color.White;
        this.btnCurrentAccount.Location = new Point(240, 20);
        this.btnCurrentAccount.Name = "btnCurrentAccount";
        this.btnCurrentAccount.Size = new Size(200, 80);
        this.btnCurrentAccount.TabIndex = 1;
        this.btnCurrentAccount.Text = "Cari Hesap";
        this.btnCurrentAccount.UseVisualStyleBackColor = false;
        this.btnCurrentAccount.Click += new EventHandler(this.btnCurrentAccount_Click);
        
        // btnProducts
        this.btnProducts.BackColor = Color.FromArgb(155, 89, 182);
        this.btnProducts.FlatStyle = FlatStyle.Flat;
        this.btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.btnProducts.ForeColor = Color.White;
        this.btnProducts.Location = new Point(20, 120);
        this.btnProducts.Name = "btnProducts";
        this.btnProducts.Size = new Size(200, 80);
        this.btnProducts.TabIndex = 2;
        this.btnProducts.Text = "Ürünler";
        this.btnProducts.UseVisualStyleBackColor = false;
        this.btnProducts.Click += new EventHandler(this.btnProducts_Click);
        
        // btnCustomers
        this.btnCustomers.BackColor = Color.FromArgb(230, 126, 34);
        this.btnCustomers.FlatStyle = FlatStyle.Flat;
        this.btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.btnCustomers.ForeColor = Color.White;
        this.btnCustomers.Location = new Point(240, 120);
        this.btnCustomers.Name = "btnCustomers";
        this.btnCustomers.Size = new Size(200, 80);
        this.btnCustomers.TabIndex = 3;
        this.btnCustomers.Text = "Müşteriler";
        this.btnCustomers.UseVisualStyleBackColor = false;
        this.btnCustomers.Click += new EventHandler(this.btnCustomers_Click);
        
        // panelMenu
        this.panelMenu.BackColor = Color.White;
        this.panelMenu.Controls.Add(this.btnStockManagement);
        this.panelMenu.Controls.Add(this.btnCurrentAccount);
        this.panelMenu.Controls.Add(this.btnProducts);
        this.panelMenu.Controls.Add(this.btnCustomers);
        this.panelMenu.Dock = DockStyle.Fill;
        this.panelMenu.Location = new Point(0, 150);
        this.panelMenu.Name = "panelMenu";
        this.panelMenu.Size = new Size(800, 300);
        this.panelMenu.TabIndex = 4;
        
        // MainForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panelMenu);
        this.Controls.Add(this.panelDashboard);
        this.Name = "MainForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "S&S Finans Uygulaması";
        this.panelDashboard.ResumeLayout(false);
        this.panelDashboard.PerformLayout();
        this.panelMenu.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}

