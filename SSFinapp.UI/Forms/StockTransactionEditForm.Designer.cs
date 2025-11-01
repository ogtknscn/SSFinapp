namespace SSFinapp.UI.Forms;

partial class StockTransactionEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle, lblTarih, lblProduct, lblMiktar, lblBirim, lblIslemTipi, lblAciklama;
    private DateTimePicker dtpTarih;
    private ComboBox cmbProduct;
    private NumericUpDown numMiktar;
    private RadioButton rdbGiris, rdbCikis;
    private TextBox txtAciklama;
    private Button btnSave, btnCancel;
    private Panel panelTop, panelContent;
    private GroupBox grpIslemTipi;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    
    private void InitializeComponent()
    {
        this.panelTop = new Panel();
        this.lblTitle = new Label();
        this.panelContent = new Panel();
        this.lblTarih = new Label();
        this.dtpTarih = new DateTimePicker();
        this.lblProduct = new Label();
        this.cmbProduct = new ComboBox();
        this.grpIslemTipi = new GroupBox();
        this.rdbGiris = new RadioButton();
        this.rdbCikis = new RadioButton();
        this.lblMiktar = new Label();
        this.numMiktar = new NumericUpDown();
        this.lblBirim = new Label();
        this.lblAciklama = new Label();
        this.txtAciklama = new TextBox();
        this.btnSave = new Button();
        this.btnCancel = new Button();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.grpIslemTipi.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.numMiktar).BeginInit();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(600, 60);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.Text = "Yeni Stok İşlemi";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // lblTarih
        this.lblTarih.AutoSize = true;
        this.lblTarih.Font = new Font("Segoe UI", 10F);
        this.lblTarih.Location = new Point(30, 30);
        this.lblTarih.Text = "Tarih:";
        
        // dtpTarih
        this.dtpTarih.Font = new Font("Segoe UI", 11F);
        this.dtpTarih.Format = DateTimePickerFormat.Custom;
        this.dtpTarih.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dtpTarih.Location = new Point(30, 55);
        this.dtpTarih.Size = new Size(200, 27);
        
        // lblProduct
        this.lblProduct.AutoSize = true;
        this.lblProduct.Font = new Font("Segoe UI", 10F);
        this.lblProduct.Location = new Point(30, 95);
        this.lblProduct.Text = "Ürün:";
        
        // cmbProduct
        this.cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbProduct.Font = new Font("Segoe UI", 11F);
        this.cmbProduct.Location = new Point(30, 120);
        this.cmbProduct.Size = new Size(500, 28);
        this.cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
        
        // grpIslemTipi
        this.grpIslemTipi.Font = new Font("Segoe UI", 10F);
        this.grpIslemTipi.Location = new Point(30, 160);
        this.grpIslemTipi.Size = new Size(250, 70);
        this.grpIslemTipi.Text = "İşlem Tipi";
        this.grpIslemTipi.Controls.AddRange(new Control[] { this.rdbGiris, this.rdbCikis });
        
        // rdbGiris
        this.rdbGiris.AutoSize = true;
        this.rdbGiris.Checked = true;
        this.rdbGiris.Font = new Font("Segoe UI", 10F);
        this.rdbGiris.Location = new Point(20, 30);
        this.rdbGiris.Text = "📥 Giriş";
        this.rdbGiris.TabStop = true;
        
        // rdbCikis
        this.rdbCikis.AutoSize = true;
        this.rdbCikis.Font = new Font("Segoe UI", 10F);
        this.rdbCikis.Location = new Point(130, 30);
        this.rdbCikis.Text = "📤 Çıkış";
        
        // lblMiktar
        this.lblMiktar.AutoSize = true;
        this.lblMiktar.Font = new Font("Segoe UI", 10F);
        this.lblMiktar.Location = new Point(300, 170);
        this.lblMiktar.Text = "Miktar:";
        
        // numMiktar
        this.numMiktar.DecimalPlaces = 2;
        this.numMiktar.Font = new Font("Segoe UI", 11F);
        this.numMiktar.Location = new Point(300, 195);
        this.numMiktar.Maximum = 999999;
        this.numMiktar.Size = new Size(150, 27);
        
        // lblBirim
        this.lblBirim.AutoSize = true;
        this.lblBirim.Font = new Font("Segoe UI", 10F);
        this.lblBirim.Location = new Point(465, 197);
        this.lblBirim.Text = "Birim: -";
        
        // lblAciklama
        this.lblAciklama.AutoSize = true;
        this.lblAciklama.Font = new Font("Segoe UI", 10F);
        this.lblAciklama.Location = new Point(30, 245);
        this.lblAciklama.Text = "Açıklama:";
        
        // txtAciklama
        this.txtAciklama.Font = new Font("Segoe UI", 10F);
        this.txtAciklama.Location = new Point(30, 270);
        this.txtAciklama.Multiline = true;
        this.txtAciklama.Size = new Size(500, 60);
        
        // btnSave
        this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
        this.btnSave.FlatStyle = FlatStyle.Flat;
        this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnSave.ForeColor = Color.White;
        this.btnSave.Location = new Point(310, 350);
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.Click += btnSave_Click;
        
        // btnCancel
        this.btnCancel.BackColor = Color.FromArgb(149, 165, 166);
        this.btnCancel.FlatStyle = FlatStyle.Flat;
        this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnCancel.ForeColor = Color.White;
        this.btnCancel.Location = new Point(430, 350);
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblTarih, this.dtpTarih, this.lblProduct, this.cmbProduct, this.grpIslemTipi,
            this.lblMiktar, this.numMiktar, this.lblBirim, this.lblAciklama, this.txtAciklama,
            this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(600, 450);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Stok İşlemi";
        
        this.panelTop.ResumeLayout(false);
        this.panelContent.ResumeLayout(false);
        this.grpIslemTipi.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.numMiktar).EndInit();
        this.ResumeLayout(false);
    }
}

