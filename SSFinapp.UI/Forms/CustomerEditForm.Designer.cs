namespace SSFinapp.UI.Forms;

partial class CustomerEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle, lblAd, lblTelefon, lblEmail, lblAdres;
    private TextBox txtAd, txtTelefon, txtEmail, txtAdres;
    private CheckBox chkAktif;
    private Button btnSave, btnCancel;
    private Panel panelTop, panelContent;
    
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
        this.lblAd = new Label();
        this.txtAd = new TextBox();
        this.lblTelefon = new Label();
        this.txtTelefon = new TextBox();
        this.lblEmail = new Label();
        this.txtEmail = new TextBox();
        this.lblAdres = new Label();
        this.txtAdres = new TextBox();
        this.chkAktif = new CheckBox();
        this.btnSave = new Button();
        this.btnCancel = new Button();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Size = new Size(550, 60);
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.Text = "Yeni Müşteri Ekle";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Padding = new Padding(20);
        
        // lblAd
        this.lblAd.AutoSize = true;
        this.lblAd.Font = new Font("Segoe UI", 10F);
        this.lblAd.Location = new Point(30, 30);
        this.lblAd.Text = "Müşteri Adı:";
        
        // txtAd
        this.txtAd.Font = new Font("Segoe UI", 11F);
        this.txtAd.Location = new Point(30, 55);
        this.txtAd.Size = new Size(480, 27);
        
        // lblTelefon
        this.lblTelefon.AutoSize = true;
        this.lblTelefon.Font = new Font("Segoe UI", 10F);
        this.lblTelefon.Location = new Point(30, 95);
        this.lblTelefon.Text = "Telefon:";
        
        // txtTelefon
        this.txtTelefon.Font = new Font("Segoe UI", 11F);
        this.txtTelefon.Location = new Point(30, 120);
        this.txtTelefon.Size = new Size(230, 27);
        
        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new Font("Segoe UI", 10F);
        this.lblEmail.Location = new Point(280, 95);
        this.lblEmail.Text = "Email:";
        
        // txtEmail
        this.txtEmail.Font = new Font("Segoe UI", 11F);
        this.txtEmail.Location = new Point(280, 120);
        this.txtEmail.Size = new Size(230, 27);
        
        // lblAdres
        this.lblAdres.AutoSize = true;
        this.lblAdres.Font = new Font("Segoe UI", 10F);
        this.lblAdres.Location = new Point(30, 160);
        this.lblAdres.Text = "Adres:";
        
        // txtAdres
        this.txtAdres.Font = new Font("Segoe UI", 10F);
        this.txtAdres.Location = new Point(30, 185);
        this.txtAdres.Multiline = true;
        this.txtAdres.Size = new Size(480, 80);
        
        // chkAktif
        this.chkAktif.AutoSize = true;
        this.chkAktif.Checked = true;
        this.chkAktif.CheckState = CheckState.Checked;
        this.chkAktif.Font = new Font("Segoe UI", 10F);
        this.chkAktif.Location = new Point(30, 280);
        this.chkAktif.Text = "Aktif";
        
        // btnSave
        this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
        this.btnSave.FlatStyle = FlatStyle.Flat;
        this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnSave.ForeColor = Color.White;
        this.btnSave.Location = new Point(290, 320);
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.Click += btnSave_Click;
        
        // btnCancel
        this.btnCancel.BackColor = Color.FromArgb(149, 165, 166);
        this.btnCancel.FlatStyle = FlatStyle.Flat;
        this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnCancel.ForeColor = Color.White;
        this.btnCancel.Location = new Point(410, 320);
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.Click += btnCancel_Click;
        
        this.panelContent.Controls.AddRange(new Control[] {
            this.lblAd, this.txtAd, this.lblTelefon, this.txtTelefon,
            this.lblEmail, this.txtEmail, this.lblAdres, this.txtAdres,
            this.chkAktif, this.btnSave, this.btnCancel
        });
        
        // Form
        this.ClientSize = new Size(550, 420);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Müşteri Ekle";
        
        this.panelTop.ResumeLayout(false);
        this.panelContent.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}

