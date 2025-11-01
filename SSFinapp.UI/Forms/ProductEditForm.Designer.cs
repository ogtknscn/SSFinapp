namespace SSFinapp.UI.Forms;

partial class ProductEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblAd;
    private Label lblBirim;
    private TextBox txtAd;
    private ComboBox cmbBirim;
    private CheckBox chkAktif;
    private Button btnSave;
    private Button btnCancel;
    private Panel panelTop;
    private Panel panelContent;
    
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
        this.lblAd = new Label();
        this.lblBirim = new Label();
        this.txtAd = new TextBox();
        this.cmbBirim = new ComboBox();
        this.chkAktif = new CheckBox();
        this.btnSave = new Button();
        this.btnCancel = new Button();
        this.panelTop = new Panel();
        this.panelContent = new Panel();
        
        this.panelTop.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.SuspendLayout();
        
        // panelTop
        this.panelTop.BackColor = Color.FromArgb(52, 73, 94);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(500, 60);
        this.panelTop.TabIndex = 0;
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Location = new Point(20, 18);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(130, 25);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Yeni Ürün Ekle";
        
        // panelContent
        this.panelContent.BackColor = Color.White;
        this.panelContent.Controls.Add(this.lblAd);
        this.panelContent.Controls.Add(this.txtAd);
        this.panelContent.Controls.Add(this.lblBirim);
        this.panelContent.Controls.Add(this.cmbBirim);
        this.panelContent.Controls.Add(this.chkAktif);
        this.panelContent.Controls.Add(this.btnSave);
        this.panelContent.Controls.Add(this.btnCancel);
        this.panelContent.Dock = DockStyle.Fill;
        this.panelContent.Location = new Point(0, 60);
        this.panelContent.Name = "panelContent";
        this.panelContent.Padding = new Padding(20);
        this.panelContent.Size = new Size(500, 250);
        this.panelContent.TabIndex = 1;
        
        // lblAd
        this.lblAd.AutoSize = true;
        this.lblAd.Font = new Font("Segoe UI", 10F);
        this.lblAd.Location = new Point(30, 30);
        this.lblAd.Name = "lblAd";
        this.lblAd.Size = new Size(70, 19);
        this.lblAd.TabIndex = 0;
        this.lblAd.Text = "Ürün Adı:";
        
        // txtAd
        this.txtAd.Font = new Font("Segoe UI", 11F);
        this.txtAd.Location = new Point(30, 55);
        this.txtAd.Name = "txtAd";
        this.txtAd.Size = new Size(440, 27);
        this.txtAd.TabIndex = 1;
        
        // lblBirim
        this.lblBirim.AutoSize = true;
        this.lblBirim.Font = new Font("Segoe UI", 10F);
        this.lblBirim.Location = new Point(30, 95);
        this.lblBirim.Name = "lblBirim";
        this.lblBirim.Size = new Size(46, 19);
        this.lblBirim.TabIndex = 2;
        this.lblBirim.Text = "Birim:";
        
        // cmbBirim
        this.cmbBirim.DropDownStyle = ComboBoxStyle.DropDown;
        this.cmbBirim.Font = new Font("Segoe UI", 11F);
        this.cmbBirim.Location = new Point(30, 120);
        this.cmbBirim.Name = "cmbBirim";
        this.cmbBirim.Size = new Size(200, 28);
        this.cmbBirim.TabIndex = 3;
        
        // chkAktif
        this.chkAktif.AutoSize = true;
        this.chkAktif.Checked = true;
        this.chkAktif.CheckState = CheckState.Checked;
        this.chkAktif.Font = new Font("Segoe UI", 10F);
        this.chkAktif.Location = new Point(30, 165);
        this.chkAktif.Name = "chkAktif";
        this.chkAktif.Size = new Size(58, 23);
        this.chkAktif.TabIndex = 4;
        this.chkAktif.Text = "Aktif";
        this.chkAktif.UseVisualStyleBackColor = true;
        
        // btnSave
        this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
        this.btnSave.FlatStyle = FlatStyle.Flat;
        this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnSave.ForeColor = Color.White;
        this.btnSave.Location = new Point(240, 195);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new Size(110, 40);
        this.btnSave.TabIndex = 5;
        this.btnSave.Text = "💾 Kaydet";
        this.btnSave.UseVisualStyleBackColor = false;
        this.btnSave.Click += new EventHandler(this.btnSave_Click);
        
        // btnCancel
        this.btnCancel.BackColor = Color.FromArgb(149, 165, 166);
        this.btnCancel.FlatStyle = FlatStyle.Flat;
        this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnCancel.ForeColor = Color.White;
        this.btnCancel.Location = new Point(360, 195);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(110, 40);
        this.btnCancel.TabIndex = 6;
        this.btnCancel.Text = "❌ İptal";
        this.btnCancel.UseVisualStyleBackColor = false;
        this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
        
        // ProductEditForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(500, 310);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "ProductEditForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Yeni Ürün Ekle";
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.panelContent.ResumeLayout(false);
        this.panelContent.PerformLayout();
        this.ResumeLayout(false);
    }
}

