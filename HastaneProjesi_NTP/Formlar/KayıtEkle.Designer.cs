namespace HastaneProjesi_NTP.Formlar
{
    partial class KayıtEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.MskTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbCinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.MskTC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKaydet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblcancel = new System.Windows.Forms.Label();
            this.tik = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // MskTelefon
            // 
            this.MskTelefon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTelefon.BorderRadius = 8;
            this.MskTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MskTelefon.DefaultText = "";
            this.MskTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MskTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MskTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MskTelefon.DisabledState.Parent = this.MskTelefon;
            this.MskTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MskTelefon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MskTelefon.FocusedState.Parent = this.MskTelefon;
            this.MskTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.ForeColor = System.Drawing.Color.Black;
            this.MskTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MskTelefon.HoverState.Parent = this.MskTelefon;
            this.MskTelefon.IconLeft = ((System.Drawing.Image)(resources.GetObject("MskTelefon.IconLeft")));
            this.MskTelefon.Location = new System.Drawing.Point(187, 192);
            this.MskTelefon.MaxLength = 11;
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.PasswordChar = '\0';
            this.MskTelefon.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTelefon.PlaceholderText = "TELEFON NUMARASI";
            this.MskTelefon.SelectedText = "";
            this.MskTelefon.ShadowDecoration.Parent = this.MskTelefon;
            this.MskTelefon.Size = new System.Drawing.Size(263, 43);
            this.MskTelefon.TabIndex = 3;
            this.MskTelefon.TextChanged += new System.EventHandler(this.MskTelefon_TextChanged);
            this.MskTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTelefon_KeyPress);
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.Animated = true;
            this.CbCinsiyet.AutoRoundedCorners = true;
            this.CbCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.CbCinsiyet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.CbCinsiyet.BorderRadius = 17;
            this.CbCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCinsiyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.CbCinsiyet.FocusedColor = System.Drawing.Color.Empty;
            this.CbCinsiyet.FocusedState.Parent = this.CbCinsiyet;
            this.CbCinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.HoverState.Parent = this.CbCinsiyet;
            this.CbCinsiyet.ItemHeight = 30;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KIZ"});
            this.CbCinsiyet.ItemsAppearance.Parent = this.CbCinsiyet;
            this.CbCinsiyet.Location = new System.Drawing.Point(187, 253);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.ShadowDecoration.Parent = this.CbCinsiyet;
            this.CbCinsiyet.Size = new System.Drawing.Size(263, 36);
            this.CbCinsiyet.TabIndex = 4;
            // 
            // TxtAd
            // 
            this.TxtAd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.TxtAd.BorderRadius = 8;
            this.TxtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAd.DefaultText = "";
            this.TxtAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAd.DisabledState.Parent = this.TxtAd;
            this.TxtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.TxtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAd.FocusedState.Parent = this.TxtAd;
            this.TxtAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.ForeColor = System.Drawing.Color.Black;
            this.TxtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAd.HoverState.Parent = this.TxtAd;
            this.TxtAd.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAd.IconLeft")));
            this.TxtAd.Location = new System.Drawing.Point(187, 69);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.PasswordChar = '\0';
            this.TxtAd.PlaceholderForeColor = System.Drawing.Color.DarkRed;
            this.TxtAd.PlaceholderText = "AD SOYAD";
            this.TxtAd.SelectedText = "";
            this.TxtAd.ShadowDecoration.Parent = this.TxtAd;
            this.TxtAd.Size = new System.Drawing.Size(263, 43);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTC
            // 
            this.MskTC.AcceptsReturn = true;
            this.MskTC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTC.BorderRadius = 8;
            this.MskTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MskTC.DefaultText = "";
            this.MskTC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MskTC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MskTC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MskTC.DisabledState.Parent = this.MskTC;
            this.MskTC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MskTC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MskTC.FocusedState.Parent = this.MskTC;
            this.MskTC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.ForeColor = System.Drawing.Color.Black;
            this.MskTC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MskTC.HoverState.Parent = this.MskTC;
            this.MskTC.IconLeft = ((System.Drawing.Image)(resources.GetObject("MskTC.IconLeft")));
            this.MskTC.Location = new System.Drawing.Point(187, 130);
            this.MskTC.MaxLength = 11;
            this.MskTC.Name = "MskTC";
            this.MskTC.PasswordChar = '\0';
            this.MskTC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.MskTC.PlaceholderText = "TC KİMLİK NO";
            this.MskTC.SelectedText = "";
            this.MskTC.ShadowDecoration.Parent = this.MskTC;
            this.MskTC.Size = new System.Drawing.Size(263, 43);
            this.MskTC.TabIndex = 2;
            this.MskTC.TextChanged += new System.EventHandler(this.MskTC_TextChanged);
            this.MskTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "TC Kimlik No:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Animated = true;
            this.BtnKaydet.AutoRoundedCorners = true;
            this.BtnKaydet.BorderRadius = 21;
            this.BtnKaydet.CheckedState.Parent = this.BtnKaydet;
            this.BtnKaydet.CustomImages.Parent = this.BtnKaydet;
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnKaydet.ForeColor = System.Drawing.Color.White;
            this.BtnKaydet.HoverState.Parent = this.BtnKaydet;
            this.BtnKaydet.Location = new System.Drawing.Point(225, 367);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.ShadowDecoration.Parent = this.BtnKaydet;
            this.BtnKaydet.Size = new System.Drawing.Size(180, 45);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(534, 16);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(393, 348);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 26;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(497, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Lütfen Bilgileri Eksiksiz Giriniz !";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cancel
            // 
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(443, 373);
            this.cancel.Name = "cancel";
            this.cancel.ShadowDecoration.Parent = this.cancel;
            this.cancel.Size = new System.Drawing.Size(48, 48);
            this.cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cancel.TabIndex = 55;
            this.cancel.TabStop = false;
            // 
            // lblcancel
            // 
            this.lblcancel.AutoSize = true;
            this.lblcancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcancel.Location = new System.Drawing.Point(490, 391);
            this.lblcancel.Name = "lblcancel";
            this.lblcancel.Size = new System.Drawing.Size(109, 21);
            this.lblcancel.TabIndex = 54;
            this.lblcancel.Text = "Kayıt Başarılı .";
            this.lblcancel.Click += new System.EventHandler(this.lblcancel_Click);
            // 
            // tik
            // 
            this.tik.Image = ((System.Drawing.Image)(resources.GetObject("tik.Image")));
            this.tik.Location = new System.Drawing.Point(443, 382);
            this.tik.Name = "tik";
            this.tik.ShadowDecoration.Parent = this.tik;
            this.tik.Size = new System.Drawing.Size(41, 39);
            this.tik.TabIndex = 53;
            this.tik.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Animated = true;
            this.dateTimePicker1.AutoRoundedCorners = true;
            this.dateTimePicker1.BorderRadius = 21;
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoverState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 304);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 45);
            this.dateTimePicker1.TabIndex = 57;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 28, 21, 58, 1, 559);
            // 
            // KayıtEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 585);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.lblcancel);
            this.Controls.Add(this.tik);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayıtEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtEkle";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox MskTelefon;
        private Guna.UI2.WinForms.Guna2ComboBox CbCinsiyet;
        private Guna.UI2.WinForms.Guna2TextBox TxtAd;
        private Guna.UI2.WinForms.Guna2TextBox MskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton BtnKaydet;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox cancel;
        private System.Windows.Forms.Label lblcancel;
        private Guna.UI2.WinForms.Guna2PictureBox tik;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
    }
}