namespace SSFinapp.UI.Forms;

partial class CurrentAccountTransactionEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle, lblTarih, lblCustomer, lblMalzeme, lblTutar, lblAlinan, lblVerilen, lblIslemTipi, lblAciklama;
    private DateTimePicker dtpTarih;
    private ComboBox cmbCustomer;
    private TextBox txtMalzeme, txtAciklama;
    private NumericUpDown numTutar, numAlinan, numVerilen;
    private RadioButton rdbPara, rdbMal;
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
        this.lblCustomer = new Label();
        this.cmbCustomer = new ComboBox();
        this.lblMalzeme = new Label();
        this.txtMalzeme = new TextBox();
        this.lblTutar = new Label();
        this.numTutar = new NumericUpDown();
        this.lblAlinan = new Label();
        this.numAlinan = new NumericUpDown();
        this.lblVerilen = new Label();
        this.numVerilen = new NumericUpDown();
        this.grpIslemTipi = new GroupBox();
        this.rdbPara = new RadioButton();
        this.rdbMal = new RadioButton();
        this.lblAciklama = new Label();
        this.txtAciklama = new TextBox();
        this.btnSave = new Button();
        this.btnCancel = new Button();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.grpIslemTipi.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.numTutar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numAlinan).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numVerilen).BeginInit();
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
        this.lblTitle.Text = "Yeni Cari İşlem";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // Form elements (simplified for space)
        this.lblTarih.AutoSize = true;
        this.lblTarih.Font = new Font("Segoe UI", 10F);
        this.lblTarih.Location = new Point(30, 20);
        this.lblTarih.Text = "Tarih:";
        
        this.dtpTarih.Font = new Font("Segoe UI", 11F);
        this.dtpTarih.Format = DateTimePickerFormat.Custom;
        this.dtpTarih.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dtpTarih.Location = new Point(30, 45);
        this.dtpTarih.Size = new Size(200, 27);
        
        this.lblCustomer.AutoSize = true;
        this.lblCustomer.Font = new Font("Segoe UI", 10F);
        this.lblCustomer.Location = new Point(30, 85);
        this.lblCustomer.Text = "Müşteri:";
        
        this.cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCustomer.Font = new Font("Segoe UI", 11F);
        this.cmbCustomer.Location = new Point(30, 110);
        this.cmbCustomer.Size = new Size(500, 28);
        
        this.lblMalzeme.AutoSize = true;
        this.lblMalzeme.Font = new Font("Segoe UI", 10F);
        this.lblMalzeme.Location = new Point(30, 150);
        this.lblMalzeme.Text = "Malzeme/Açıklama:";
        
        this.txtMalzeme.Font = new Font("Segoe UI", 11F);
        this.txtMalzeme.Location = new Point(30, 175);
        this.txtMalzeme.Size = new Size(500, 27);
        
        this.lblTutar.AutoSize = true;
        this.lblTutar.Font = new Font("Segoe UI", 10F);
        this.lblTutar.Location = new Point(30, 215);
        this.lblTutar.Text = "Tutar:";
        
        this.numTutar.DecimalPlaces = 2;
        this.numTutar.Font = new Font("Segoe UI", 11F);
        this.numTutar.Location = new Point(30, 240);
        this.numTutar.Maximum = 999999;
        this.numTutar.Size = new Size(150, 27);
        
        this.lblAlinan.AutoSize = true;
        this.lblAlinan.Font = new Font("Segoe UI", 10F);
        this.lblAlinan.Location = new Point(200, 215);
        this.lblAlinan.Text = "Alınan:";
        
        this.numAlinan.DecimalPlaces = 2;
        this.numAlinan.Font = new Font("Segoe UI", 11F);
        this.numAlinan.Location = new Point(200, 240);
        this.numAlinan.Maximum = 999999;
        this.numAlinan.Size = new Size(150, 27);
        
        this.lblVerilen.AutoSize = true;
        this.lblVerilen.Font = new Font("Segoe UI", 10F);
        this.lblVerilen.Location = new Point(370, 215);
        this.lblVerilen.Text = "Verilen:";
        
        this.numVerilen.DecimalPlaces = 2;
        this.numVerilen.Font = new Font("Segoe UI", 11F);
        this.numVerilen.Location = new Point(370, 240);
        this.numVerilen.Maximum = 999999;
        this.numVerilen.Size = new Size(150, 27);
        
        this.grpIslemTipi.Font = new Font("Segoe UI", 10F);
        this.grpIslemTipi.Location = new Point(30, 280);
        this.grpIslemTipi.Size = new Size(220, 60);
        this.grpIslemTipi.Text = "İşlem Tipi";
        
        this.rdbPara.AutoSize = true;
        this.rdbPara.Checked = true;
        this.rdbPara.Font = new Font("Segoe UI", 10F);
        this.rdbPara.Location = new Point(20, 25);
        this.rdbPara.Text = "💵 Para";
        this.rdbPara.TabStop = true;
        
        this.rdbMal.AutoSize = true;
        this.rdbMal.Font = new Font("Segoe UI", 10F);
        this.rdbMal.Location = new Point(120, 25);
        this.rdbMal.Text = "📦 Mal";
        
        this.grpIslemTipi.Controls.AddRange(new Control[] { this.rdbPara, this.rdbMal });
        
        this.lblAciklama.AutoSize = true;
        this.lblAciklama.Font = new Font("Segoe UI", 10F);
        this.lblAciklama.Location = new Point(30, 355);
        this.lblAciklama.Text = "Açıklama:";
        
        this.txtAciklama.Font = new Font("Segoe UI", 10F);
        this.txtAciklama.Location = new Point(30, 380);
        this.txtAciklama.Multiline = true;
        this.txtAciklama.Size = new Size(500, 60);
        
        this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
        this.btnSave.FlatStyle = FlatStyle.Flat;
        this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnSave.ForeColor = Color.White;
        this.btnSave.Location = new Point(310, 460);
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.Click += btnSave_Click;
        
        this.btnCancel.BackColor = Color.FromArgb(149, 165, 166);
        this.btnCancel.FlatStyle = FlatStyle.Flat;
        this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnCancel.ForeColor = Color.White;
        this.btnCancel.Location = new Point(430, 460);
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblTarih, this.dtpTarih, this.lblCustomer, this.cmbCustomer,
            this.lblMalzeme, this.txtMalzeme, this.lblTutar, this.numTutar,
            this.lblAlinan, this.numAlinan, this.lblVerilen, this.numVerilen,
            this.grpIslemTipi, this.lblAciklama, this.txtAciklama,
            this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(600, 560);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Cari İşlem";
        
        this.panelTop.ResumeLayout(false);
        this.panelContent.ResumeLayout(false);
        this.grpIslemTipi.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.numTutar).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numAlinan).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numVerilen).EndInit();
        this.ResumeLayout(false);
    }
}

