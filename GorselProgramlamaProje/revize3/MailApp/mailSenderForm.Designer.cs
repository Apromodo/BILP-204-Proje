namespace MailApp
{
    partial class mailSenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailSenderForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGönder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.txtGonderenSifre = new System.Windows.Forms.TextBox();
            this.txtGonderenMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMesajOku = new System.Windows.Forms.Button();
            this.rtxtMesajlar = new System.Windows.Forms.RichTextBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.cmbServerMesajOku = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.cmbServer);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnGönder);
            this.tabPage1.Controls.Add(this.txtMesaj);
            this.tabPage1.Controls.Add(this.txtKonu);
            this.tabPage1.Controls.Add(this.txtKime);
            this.tabPage1.Controls.Add(this.txtGonderenSifre);
            this.tabPage1.Controls.Add(this.txtGonderenMail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mesaj Gönder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Server:";
            // 
            // btnGönder
            // 
            this.btnGönder.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGönder.ImageKey = "Mail-Send-icon.png";
            this.btnGönder.ImageList = this.ımageList1;
            this.btnGönder.Location = new System.Drawing.Point(297, 389);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(93, 40);
            this.btnGönder.TabIndex = 10;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Mail-Send-icon.png");
            this.ımageList1.Images.SetKeyName(1, "34-Open_Letter-512.png");
            // 
            // txtMesaj
            // 
            this.txtMesaj.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.Location = new System.Drawing.Point(18, 240);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(372, 143);
            this.txtMesaj.TabIndex = 9;
            // 
            // txtKonu
            // 
            this.txtKonu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(124, 176);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(266, 21);
            this.txtKonu.TabIndex = 8;
            // 
            // txtKime
            // 
            this.txtKime.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKime.Location = new System.Drawing.Point(124, 139);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(266, 21);
            this.txtKime.TabIndex = 7;
            // 
            // txtGonderenSifre
            // 
            this.txtGonderenSifre.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGonderenSifre.Location = new System.Drawing.Point(124, 99);
            this.txtGonderenSifre.Name = "txtGonderenSifre";
            this.txtGonderenSifre.PasswordChar = '*';
            this.txtGonderenSifre.Size = new System.Drawing.Size(266, 21);
            this.txtGonderenSifre.TabIndex = 6;
            // 
            // txtGonderenMail
            // 
            this.txtGonderenMail.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGonderenMail.Location = new System.Drawing.Point(124, 62);
            this.txtGonderenMail.Name = "txtGonderenMail";
            this.txtGonderenMail.Size = new System.Drawing.Size(266, 21);
            this.txtGonderenMail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifreniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Adresiniz:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage2.Controls.Add(this.cmbServerMesajOku);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtSifre);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnMesajOku);
            this.tabPage2.Controls.Add(this.rtxtMesajlar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mesajlar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Server:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(160, 371);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 21);
            this.txtSifre.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(16, 371);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(157, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // btnMesajOku
            // 
            this.btnMesajOku.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajOku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesajOku.ImageKey = "34-Open_Letter-512.png";
            this.btnMesajOku.ImageList = this.ımageList1;
            this.btnMesajOku.Location = new System.Drawing.Point(278, 364);
            this.btnMesajOku.Name = "btnMesajOku";
            this.btnMesajOku.Size = new System.Drawing.Size(122, 65);
            this.btnMesajOku.TabIndex = 3;
            this.btnMesajOku.Text = "Mesajları Oku";
            this.btnMesajOku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesajOku.UseVisualStyleBackColor = true;
            this.btnMesajOku.Click += new System.EventHandler(this.btnMesajOku_Click);
            // 
            // rtxtMesajlar
            // 
            this.rtxtMesajlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rtxtMesajlar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtMesajlar.Location = new System.Drawing.Point(3, 3);
            this.rtxtMesajlar.Name = "rtxtMesajlar";
            this.rtxtMesajlar.Size = new System.Drawing.Size(398, 345);
            this.rtxtMesajlar.TabIndex = 1;
            this.rtxtMesajlar.Text = "";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "Gmail",
            "Outlook"});
            this.cmbServer.Location = new System.Drawing.Point(124, 14);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(266, 21);
            this.cmbServer.TabIndex = 14;
            // 
            // cmbServerMesajOku
            // 
            this.cmbServerMesajOku.FormattingEnabled = true;
            this.cmbServerMesajOku.Items.AddRange(new object[] {
            "Gmail",
            "Outlook"});
            this.cmbServerMesajOku.Location = new System.Drawing.Point(92, 408);
            this.cmbServerMesajOku.Name = "cmbServerMesajOku";
            this.cmbServerMesajOku.Size = new System.Drawing.Size(168, 21);
            this.cmbServerMesajOku.TabIndex = 19;
            // 
            // mailSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 466);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mailSenderForm";
            this.Text = "Mesajlar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtKime;
        private System.Windows.Forms.TextBox txtGonderenSifre;
        private System.Windows.Forms.TextBox txtGonderenMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMesajOku;
        private System.Windows.Forms.RichTextBox rtxtMesajlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.ComboBox cmbServerMesajOku;
    }
}

