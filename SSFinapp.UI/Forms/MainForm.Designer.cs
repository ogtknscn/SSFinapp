using MaterialSkin;
using MaterialSkin.Controls;

namespace SSFinapp.UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private MaterialLabel lblTitle;
    private MaterialLabel lblProductCount;
    private MaterialLabel lblCustomerCount;
    private MaterialButton btnStockManagement;
    private MaterialButton btnCurrentAccount;
    private MaterialButton btnCashManagement;
    private MaterialButton btnProducts;
    private MaterialButton btnCustomers;
    private MaterialButton btnSettings;
    private Panel panelDashboard;
    private Panel panelMenu;
    private Panel panelWidgets;
    private Panel widgetCollections;
    private Panel widgetOverdue;
    private Panel widgetCriticalStock;
    private Panel widgetCash;
    private MaterialLabel lblWidgetCollectionsTitle;
    private MaterialLabel lblWidgetCollections;
    private MaterialLabel lblWidgetOverdueTitle;
    private MaterialLabel lblWidgetOverdue;
    private MaterialLabel lblWidgetCriticalStockTitle;
    private MaterialLabel lblWidgetCriticalStock;
    private MaterialLabel lblWidgetCashTitle;
    private MaterialLabel lblWidgetCash;
    
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
        this.lblTitle = new MaterialLabel();
        this.lblProductCount = new MaterialLabel();
        this.lblCustomerCount = new MaterialLabel();
        this.btnStockManagement = new MaterialButton();
        this.btnCurrentAccount = new MaterialButton();
        this.btnCashManagement = new MaterialButton();
        this.btnProducts = new MaterialButton();
        this.btnCustomers = new MaterialButton();
        this.btnSettings = new MaterialButton();
        this.panelDashboard = new Panel();
        this.panelWidgets = new Panel();
        this.panelMenu = new Panel();
        
        this.panelDashboard.SuspendLayout();
        this.panelWidgets.SuspendLayout();
        this.panelMenu.SuspendLayout();
        this.SuspendLayout();
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Depth = 0;
        this.lblTitle.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblTitle.Location = new Point(20, 20);
        this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(250, 24);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "S&S Finans Uygulaması";
        
        // lblProductCount
        this.lblProductCount.AutoSize = true;
        this.lblProductCount.Depth = 0;
        this.lblProductCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblProductCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblProductCount.Location = new Point(20, 70);
        this.lblProductCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblProductCount.Name = "lblProductCount";
        this.lblProductCount.Size = new Size(120, 19);
        this.lblProductCount.TabIndex = 1;
        this.lblProductCount.Text = "Toplam Ürün: 0";
        
        // lblCustomerCount
        this.lblCustomerCount.AutoSize = true;
        this.lblCustomerCount.Depth = 0;
        this.lblCustomerCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblCustomerCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblCustomerCount.Location = new Point(20, 100);
        this.lblCustomerCount.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblCustomerCount.Name = "lblCustomerCount";
        this.lblCustomerCount.Size = new Size(140, 19);
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
        this.panelDashboard.Size = new Size(800, 100);
        this.panelDashboard.TabIndex = 3;
        
        // btnStockManagement
        this.btnStockManagement.AutoSize = false;
        this.btnStockManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnStockManagement.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnStockManagement.Depth = 0;
        this.btnStockManagement.HighEmphasis = true;
        this.btnStockManagement.Icon = null;
        this.btnStockManagement.Location = new Point(20, 20);
        this.btnStockManagement.Margin = new Padding(4, 6, 4, 6);
        this.btnStockManagement.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnStockManagement.Name = "btnStockManagement";
        this.btnStockManagement.NoAccentTextColor = Color.Empty;
        this.btnStockManagement.Size = new Size(200, 80);
        this.btnStockManagement.TabIndex = 0;
        this.btnStockManagement.Text = "Stok Yönetimi";
        this.btnStockManagement.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnStockManagement.UseAccentColor = false;
        this.btnStockManagement.UseVisualStyleBackColor = true;
        this.btnStockManagement.Click += new EventHandler(this.btnStockManagement_Click);
        
        // btnCurrentAccount
        this.btnCurrentAccount.AutoSize = false;
        this.btnCurrentAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnCurrentAccount.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnCurrentAccount.Depth = 0;
        this.btnCurrentAccount.HighEmphasis = true;
        this.btnCurrentAccount.Icon = null;
        this.btnCurrentAccount.Location = new Point(240, 20);
        this.btnCurrentAccount.Margin = new Padding(4, 6, 4, 6);
        this.btnCurrentAccount.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCurrentAccount.Name = "btnCurrentAccount";
        this.btnCurrentAccount.NoAccentTextColor = Color.Empty;
        this.btnCurrentAccount.Size = new Size(200, 80);
        this.btnCurrentAccount.TabIndex = 1;
        this.btnCurrentAccount.Text = "Cari Hesap";
        this.btnCurrentAccount.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnCurrentAccount.UseAccentColor = false;
        this.btnCurrentAccount.UseVisualStyleBackColor = true;
        this.btnCurrentAccount.Click += new EventHandler(this.btnCurrentAccount_Click);
        
        // btnCashManagement
        this.btnCashManagement.AutoSize = false;
        this.btnCashManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnCashManagement.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnCashManagement.Depth = 0;
        this.btnCashManagement.HighEmphasis = true;
        this.btnCashManagement.Icon = null;
        this.btnCashManagement.Location = new Point(460, 20);
        this.btnCashManagement.Margin = new Padding(4, 6, 4, 6);
        this.btnCashManagement.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCashManagement.Name = "btnCashManagement";
        this.btnCashManagement.NoAccentTextColor = Color.Empty;
        this.btnCashManagement.Size = new Size(200, 80);
        this.btnCashManagement.TabIndex = 5;
        this.btnCashManagement.Text = "💰 Kasa Yönetimi";
        this.btnCashManagement.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnCashManagement.UseAccentColor = false;
        this.btnCashManagement.UseVisualStyleBackColor = true;
        this.btnCashManagement.Click += new EventHandler(this.btnCashManagement_Click);
        
        // btnProducts
        this.btnProducts.AutoSize = false;
        this.btnProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnProducts.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnProducts.Depth = 0;
        this.btnProducts.HighEmphasis = true;
        this.btnProducts.Icon = null;
        this.btnProducts.Location = new Point(20, 120);
        this.btnProducts.Margin = new Padding(4, 6, 4, 6);
        this.btnProducts.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnProducts.Name = "btnProducts";
        this.btnProducts.NoAccentTextColor = Color.Empty;
        this.btnProducts.Size = new Size(200, 80);
        this.btnProducts.TabIndex = 2;
        this.btnProducts.Text = "Ürünler";
        this.btnProducts.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnProducts.UseAccentColor = false;
        this.btnProducts.UseVisualStyleBackColor = true;
        this.btnProducts.Click += new EventHandler(this.btnProducts_Click);
        
        // btnCustomers
        this.btnCustomers.AutoSize = false;
        this.btnCustomers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnCustomers.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnCustomers.Depth = 0;
        this.btnCustomers.HighEmphasis = true;
        this.btnCustomers.Icon = null;
        this.btnCustomers.Location = new Point(240, 120);
        this.btnCustomers.Margin = new Padding(4, 6, 4, 6);
        this.btnCustomers.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCustomers.Name = "btnCustomers";
        this.btnCustomers.NoAccentTextColor = Color.Empty;
        this.btnCustomers.Size = new Size(200, 80);
        this.btnCustomers.TabIndex = 3;
        this.btnCustomers.Text = "Müşteriler";
        this.btnCustomers.Type = MaterialButton.MaterialButtonType.Contained;
        this.btnCustomers.UseAccentColor = false;
        this.btnCustomers.UseVisualStyleBackColor = true;
        this.btnCustomers.Click += new EventHandler(this.btnCustomers_Click);
        
        // btnSettings
        this.btnSettings.AutoSize = false;
        this.btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.btnSettings.Density = MaterialButton.MaterialButtonDensity.Default;
        this.btnSettings.Depth = 0;
        this.btnSettings.HighEmphasis = false;
        this.btnSettings.Icon = null;
        this.btnSettings.Location = new Point(460, 120);
        this.btnSettings.Margin = new Padding(4, 6, 4, 6);
        this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnSettings.Name = "btnSettings";
        this.btnSettings.NoAccentTextColor = Color.Empty;
        this.btnSettings.Size = new Size(120, 40);
        this.btnSettings.TabIndex = 4;
        this.btnSettings.Text = "⚙️ Ayarlar";
        this.btnSettings.Type = MaterialButton.MaterialButtonType.Text;
        this.btnSettings.UseAccentColor = false;
        this.btnSettings.UseVisualStyleBackColor = true;
        this.btnSettings.Click += new EventHandler(this.btnSettings_Click);
        
        // Widget Collections
        this.widgetCollections = new Panel();
        this.widgetCollections.BackColor = Color.FromArgb(33, 150, 243); // Blue
        this.widgetCollections.Location = new Point(20, 20);
        this.widgetCollections.Size = new Size(180, 120);
        this.widgetCollections.Padding = new Padding(15);
        this.lblWidgetCollectionsTitle = new MaterialLabel();
        this.lblWidgetCollectionsTitle.AutoSize = true;
        this.lblWidgetCollectionsTitle.Depth = 0;
        this.lblWidgetCollectionsTitle.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblWidgetCollectionsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
        this.lblWidgetCollectionsTitle.ForeColor = Color.White;
        this.lblWidgetCollectionsTitle.Location = new Point(15, 15);
        this.lblWidgetCollectionsTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCollectionsTitle.Text = "Bu Ay Tahsilatlar";
        this.lblWidgetCollections = new MaterialLabel();
        this.lblWidgetCollections.AutoSize = false;
        this.lblWidgetCollections.Depth = 0;
        this.lblWidgetCollections.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblWidgetCollections.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblWidgetCollections.ForeColor = Color.White;
        this.lblWidgetCollections.Location = new Point(15, 45);
        this.lblWidgetCollections.Size = new Size(150, 60);
        this.lblWidgetCollections.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCollections.Text = "0,00 ₺";
        this.lblWidgetCollections.TextAlign = ContentAlignment.MiddleLeft;
        this.widgetCollections.Controls.Add(this.lblWidgetCollectionsTitle);
        this.widgetCollections.Controls.Add(this.lblWidgetCollections);
        
        // Widget Overdue
        this.widgetOverdue = new Panel();
        this.widgetOverdue.BackColor = Color.FromArgb(244, 67, 54); // Red
        this.widgetOverdue.Location = new Point(220, 20);
        this.widgetOverdue.Size = new Size(180, 120);
        this.widgetOverdue.Padding = new Padding(15);
        this.lblWidgetOverdueTitle = new MaterialLabel();
        this.lblWidgetOverdueTitle.AutoSize = true;
        this.lblWidgetOverdueTitle.Depth = 0;
        this.lblWidgetOverdueTitle.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblWidgetOverdueTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
        this.lblWidgetOverdueTitle.ForeColor = Color.White;
        this.lblWidgetOverdueTitle.Location = new Point(15, 15);
        this.lblWidgetOverdueTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetOverdueTitle.Text = "Vadesi Geçen Alacaklar";
        this.lblWidgetOverdue = new MaterialLabel();
        this.lblWidgetOverdue.AutoSize = false;
        this.lblWidgetOverdue.Depth = 0;
        this.lblWidgetOverdue.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblWidgetOverdue.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblWidgetOverdue.ForeColor = Color.White;
        this.lblWidgetOverdue.Location = new Point(15, 45);
        this.lblWidgetOverdue.Size = new Size(150, 60);
        this.lblWidgetOverdue.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetOverdue.Text = "0 Müşteri\n0,00 ₺";
        this.lblWidgetOverdue.TextAlign = ContentAlignment.MiddleLeft;
        this.widgetOverdue.Controls.Add(this.lblWidgetOverdueTitle);
        this.widgetOverdue.Controls.Add(this.lblWidgetOverdue);
        
        // Widget Critical Stock
        this.widgetCriticalStock = new Panel();
        this.widgetCriticalStock.BackColor = Color.FromArgb(255, 152, 0); // Orange
        this.widgetCriticalStock.Location = new Point(420, 20);
        this.widgetCriticalStock.Size = new Size(180, 120);
        this.widgetCriticalStock.Padding = new Padding(15);
        this.lblWidgetCriticalStockTitle = new MaterialLabel();
        this.lblWidgetCriticalStockTitle.AutoSize = true;
        this.lblWidgetCriticalStockTitle.Depth = 0;
        this.lblWidgetCriticalStockTitle.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblWidgetCriticalStockTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
        this.lblWidgetCriticalStockTitle.ForeColor = Color.White;
        this.lblWidgetCriticalStockTitle.Location = new Point(15, 15);
        this.lblWidgetCriticalStockTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCriticalStockTitle.Text = "Kritik Stok";
        this.lblWidgetCriticalStock = new MaterialLabel();
        this.lblWidgetCriticalStock.AutoSize = false;
        this.lblWidgetCriticalStock.Depth = 0;
        this.lblWidgetCriticalStock.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblWidgetCriticalStock.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblWidgetCriticalStock.ForeColor = Color.White;
        this.lblWidgetCriticalStock.Location = new Point(15, 45);
        this.lblWidgetCriticalStock.Size = new Size(150, 60);
        this.lblWidgetCriticalStock.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCriticalStock.Text = "0 Ürün";
        this.lblWidgetCriticalStock.TextAlign = ContentAlignment.MiddleLeft;
        this.widgetCriticalStock.Controls.Add(this.lblWidgetCriticalStockTitle);
        this.widgetCriticalStock.Controls.Add(this.lblWidgetCriticalStock);
        
        // Widget Cash
        this.widgetCash = new Panel();
        this.widgetCash.BackColor = Color.FromArgb(76, 175, 80); // Green
        this.widgetCash.Location = new Point(620, 20);
        this.widgetCash.Size = new Size(180, 120);
        this.widgetCash.Padding = new Padding(15);
        this.lblWidgetCashTitle = new MaterialLabel();
        this.lblWidgetCashTitle.AutoSize = true;
        this.lblWidgetCashTitle.Depth = 0;
        this.lblWidgetCashTitle.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.lblWidgetCashTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
        this.lblWidgetCashTitle.ForeColor = Color.White;
        this.lblWidgetCashTitle.Location = new Point(15, 15);
        this.lblWidgetCashTitle.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCashTitle.Text = "Kasa Bakiyeleri";
        this.lblWidgetCash = new MaterialLabel();
        this.lblWidgetCash.AutoSize = false;
        this.lblWidgetCash.Depth = 0;
        this.lblWidgetCash.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
        this.lblWidgetCash.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        this.lblWidgetCash.ForeColor = Color.White;
        this.lblWidgetCash.Location = new Point(15, 45);
        this.lblWidgetCash.Size = new Size(150, 60);
        this.lblWidgetCash.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblWidgetCash.Text = "0,00 ₺";
        this.lblWidgetCash.TextAlign = ContentAlignment.MiddleLeft;
        this.widgetCash.Controls.Add(this.lblWidgetCashTitle);
        this.widgetCash.Controls.Add(this.lblWidgetCash);
        
        // panelWidgets
        this.panelWidgets = new Panel();
        this.panelWidgets.BackColor = Color.WhiteSmoke;
        this.panelWidgets.Controls.Add(this.widgetCollections);
        this.panelWidgets.Controls.Add(this.widgetOverdue);
        this.panelWidgets.Controls.Add(this.widgetCriticalStock);
        this.panelWidgets.Controls.Add(this.widgetCash);
        this.panelWidgets.Dock = DockStyle.Top;
        this.panelWidgets.Location = new Point(0, 100);
        this.panelWidgets.Name = "panelWidgets";
        this.panelWidgets.Size = new Size(800, 170);
        this.panelWidgets.TabIndex = 5;
        
        // panelMenu
        this.panelMenu.BackColor = Color.White;
        this.panelMenu.Controls.Add(this.btnStockManagement);
        this.panelMenu.Controls.Add(this.btnCurrentAccount);
        this.panelMenu.Controls.Add(this.btnCashManagement);
        this.panelMenu.Controls.Add(this.btnProducts);
        this.panelMenu.Controls.Add(this.btnCustomers);
        this.panelMenu.Controls.Add(this.btnSettings);
        this.panelMenu.Dock = DockStyle.Fill;
        this.panelMenu.Location = new Point(0, 270);
        this.panelMenu.Name = "panelMenu";
        this.panelMenu.Size = new Size(800, 180);
        this.panelMenu.TabIndex = 4;
        
        // MainForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panelMenu);
        this.Controls.Add(this.panelWidgets);
        this.Controls.Add(this.panelDashboard);
        this.Name = "MainForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "S&S Finans Uygulaması";
        
        // MaterialSkin Manager - ThemeHelper tarafından yönetiliyor
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        this.panelDashboard.ResumeLayout(false);
        this.panelDashboard.PerformLayout();
        this.panelWidgets.ResumeLayout(false);
        this.panelMenu.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}

