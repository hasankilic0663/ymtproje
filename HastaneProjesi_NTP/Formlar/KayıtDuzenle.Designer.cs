namespace HastaneProjesi_NTP.Formlar
{
    partial class KayıtDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtDuzenle));
            this.btnguncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdogumtarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.mskTC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtadsoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mskTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTCbilgiGetir = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBilgiGetir = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lblcancel = new System.Windows.Forms.Label();
            this.tik = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Animated = true;
            this.btnguncelle.AutoRoundedCorners = true;
            this.btnguncelle.BorderRadius = 21;
            this.btnguncelle.CheckedState.Parent = this.btnguncelle;
            this.btnguncelle.CustomImages.Parent = this.btnguncelle;
            this.btnguncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguncelle.FillColor2 = System.Drawing.Color.Lime;
            this.btnguncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnguncelle.ForeColor = System.Drawing.Color.Black;
            this.btnguncelle.HoverState.Parent = this.btnguncelle;
            this.btnguncelle.Location = new System.Drawing.Point(355, 451);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.ShadowDecoration.Parent = this.btnguncelle;
            this.btnguncelle.Size = new System.Drawing.Size(180, 45);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(197, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(209, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(231, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(205, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // txtdogumtarihi
            // 
            this.txtdogumtarihi.Animated = true;
            this.txtdogumtarihi.AutoRoundedCorners = true;
            this.txtdogumtarihi.BackColor = System.Drawing.Color.Transparent;
            this.txtdogumtarihi.BorderRadius = 21;
            this.txtdogumtarihi.CheckedState.Parent = this.txtdogumtarihi;
            this.txtdogumtarihi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.txtdogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdogumtarihi.HoverState.Parent = this.txtdogumtarihi;
            this.txtdogumtarihi.Location = new System.Drawing.Point(317, 388);
            this.txtdogumtarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdogumtarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdogumtarihi.Name = "txtdogumtarihi";
            this.txtdogumtarihi.ShadowDecoration.Parent = this.txtdogumtarihi;
            this.txtdogumtarihi.Size = new System.Drawing.Size(263, 45);
            this.txtdogumtarihi.TabIndex = 7;
            this.txtdogumtarihi.UseTransparentBackground = true;
            this.txtdogumtarihi.Value = new System.DateTime(2022, 12, 28, 18, 5, 34, 503);
            this.txtdogumtarihi.ValueChanged += new System.EventHandler(this.txtdogumtarihi_ValueChanged);
            // 
            // mskTC
            // 
            this.mskTC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.mskTC.BorderRadius = 8;
            this.mskTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskTC.DefaultText = "";
            this.mskTC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mskTC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mskTC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTC.DisabledState.Parent = this.mskTC;
            this.mskTC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.mskTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTC.FocusedState.Parent = this.mskTC;
            this.mskTC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.ForeColor = System.Drawing.Color.Black;
            this.mskTC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTC.HoverState.Parent = this.mskTC;
            this.mskTC.IconLeft = ((System.Drawing.Image)(resources.GetObject("mskTC.IconLeft")));
            this.mskTC.Location = new System.Drawing.Point(317, 214);
            this.mskTC.Name = "mskTC";
            this.mskTC.PasswordChar = '\0';
            this.mskTC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.mskTC.PlaceholderText = "TC KİMLİK NO";
            this.mskTC.SelectedText = "";
            this.mskTC.ShadowDecoration.Parent = this.mskTC;
            this.mskTC.Size = new System.Drawing.Size(263, 43);
            this.mskTC.TabIndex = 4;
            this.mskTC.TextChanged += new System.EventHandler(this.mskTC_TextChanged);
            this.mskTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTC_KeyPress);
            this.mskTC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mskTC_MouseClick);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.txtadsoyad.BorderRadius = 8;
            this.txtadsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadsoyad.DefaultText = "";
            this.txtadsoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadsoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadsoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadsoyad.DisabledState.Parent = this.txtadsoyad;
            this.txtadsoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadsoyad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.txtadsoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadsoyad.FocusedState.Parent = this.txtadsoyad;
            this.txtadsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.ForeColor = System.Drawing.Color.Black;
            this.txtadsoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadsoyad.HoverState.Parent = this.txtadsoyad;
            this.txtadsoyad.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtadsoyad.IconLeft")));
            this.txtadsoyad.Location = new System.Drawing.Point(317, 153);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.PasswordChar = '\0';
            this.txtadsoyad.PlaceholderForeColor = System.Drawing.Color.DarkRed;
            this.txtadsoyad.PlaceholderText = "AD SOYAD";
            this.txtadsoyad.SelectedText = "";
            this.txtadsoyad.ShadowDecoration.Parent = this.txtadsoyad;
            this.txtadsoyad.Size = new System.Drawing.Size(263, 43);
            this.txtadsoyad.TabIndex = 3;
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.Animated = true;
            this.txtcinsiyet.AutoRoundedCorners = true;
            this.txtcinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.txtcinsiyet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.txtcinsiyet.BorderRadius = 17;
            this.txtcinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcinsiyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.txtcinsiyet.FocusedColor = System.Drawing.Color.Empty;
            this.txtcinsiyet.FocusedState.Parent = this.txtcinsiyet;
            this.txtcinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txtcinsiyet.FormattingEnabled = true;
            this.txtcinsiyet.HoverState.Parent = this.txtcinsiyet;
            this.txtcinsiyet.ItemHeight = 30;
            this.txtcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KIZ"});
            this.txtcinsiyet.ItemsAppearance.Parent = this.txtcinsiyet;
            this.txtcinsiyet.Location = new System.Drawing.Point(317, 337);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.ShadowDecoration.Parent = this.txtcinsiyet;
            this.txtcinsiyet.Size = new System.Drawing.Size(263, 36);
            this.txtcinsiyet.TabIndex = 6;
            // 
            // mskTelefon
            // 
            this.mskTelefon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.mskTelefon.BorderRadius = 8;
            this.mskTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskTelefon.DefaultText = "";
            this.mskTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mskTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mskTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTelefon.DisabledState.Parent = this.mskTelefon;
            this.mskTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTelefon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.mskTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTelefon.FocusedState.Parent = this.mskTelefon;
            this.mskTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.ForeColor = System.Drawing.Color.Black;
            this.mskTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTelefon.HoverState.Parent = this.mskTelefon;
            this.mskTelefon.IconLeft = ((System.Drawing.Image)(resources.GetObject("mskTelefon.IconLeft")));
            this.mskTelefon.Location = new System.Drawing.Point(317, 276);
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.PasswordChar = '\0';
            this.mskTelefon.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.mskTelefon.PlaceholderText = "TELEFON NUMARASI";
            this.mskTelefon.SelectedText = "";
            this.mskTelefon.ShadowDecoration.Parent = this.mskTelefon;
            this.mskTelefon.Size = new System.Drawing.Size(263, 43);
            this.mskTelefon.TabIndex = 5;
            this.mskTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bilgilerini Getirmek İstediğiniz Hastanın TC Nosunu Giriniz :";
            // 
            // mskTCbilgiGetir
            // 
            this.mskTCbilgiGetir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTCbilgiGetir.BorderRadius = 8;
            this.mskTCbilgiGetir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskTCbilgiGetir.DefaultText = "";
            this.mskTCbilgiGetir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mskTCbilgiGetir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mskTCbilgiGetir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTCbilgiGetir.DisabledState.Parent = this.mskTCbilgiGetir;
            this.mskTCbilgiGetir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskTCbilgiGetir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTCbilgiGetir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTCbilgiGetir.FocusedState.Parent = this.mskTCbilgiGetir;
            this.mskTCbilgiGetir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCbilgiGetir.ForeColor = System.Drawing.Color.Black;
            this.mskTCbilgiGetir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskTCbilgiGetir.HoverState.Parent = this.mskTCbilgiGetir;
            this.mskTCbilgiGetir.IconLeft = ((System.Drawing.Image)(resources.GetObject("mskTCbilgiGetir.IconLeft")));
            this.mskTCbilgiGetir.Location = new System.Drawing.Point(477, 77);
            this.mskTCbilgiGetir.MaxLength = 11;
            this.mskTCbilgiGetir.Name = "mskTCbilgiGetir";
            this.mskTCbilgiGetir.PasswordChar = '\0';
            this.mskTCbilgiGetir.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.mskTCbilgiGetir.PlaceholderText = "TC KİMLİK NO";
            this.mskTCbilgiGetir.SelectedText = "";
            this.mskTCbilgiGetir.ShadowDecoration.Parent = this.mskTCbilgiGetir;
            this.mskTCbilgiGetir.Size = new System.Drawing.Size(263, 43);
            this.mskTCbilgiGetir.TabIndex = 1;
            this.mskTCbilgiGetir.TextChanged += new System.EventHandler(this.mskTCbilgiGetir_TextChanged);
            this.mskTCbilgiGetir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTCbilgiGetir_KeyPress);
            // 
            // btnBilgiGetir
            // 
            this.btnBilgiGetir.CheckedState.Parent = this.btnBilgiGetir;
            this.btnBilgiGetir.CustomImages.Parent = this.btnBilgiGetir;
            this.btnBilgiGetir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBilgiGetir.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.btnBilgiGetir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBilgiGetir.ForeColor = System.Drawing.Color.Black;
            this.btnBilgiGetir.HoverState.Parent = this.btnBilgiGetir;
            this.btnBilgiGetir.Location = new System.Drawing.Point(762, 66);
            this.btnBilgiGetir.Name = "btnBilgiGetir";
            this.btnBilgiGetir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBilgiGetir.ShadowDecoration.Parent = this.btnBilgiGetir;
            this.btnBilgiGetir.Size = new System.Drawing.Size(69, 63);
            this.btnBilgiGetir.TabIndex = 2;
            this.btnBilgiGetir.Text = "SORGULA";
            this.btnBilgiGetir.Click += new System.EventHandler(this.btnBilgiGetir_Click);
            // 
            // lblcancel
            // 
            this.lblcancel.AutoSize = true;
            this.lblcancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcancel.Location = new System.Drawing.Point(610, 462);
            this.lblcancel.Name = "lblcancel";
            this.lblcancel.Size = new System.Drawing.Size(210, 21);
            this.lblcancel.TabIndex = 56;
            this.lblcancel.Text = "BAŞARIYLA GÜNCELLENDİ .";
            // 
            // tik
            // 
            this.tik.Image = ((System.Drawing.Image)(resources.GetObject("tik.Image")));
            this.tik.Location = new System.Drawing.Point(563, 453);
            this.tik.Name = "tik";
            this.tik.ShadowDecoration.Parent = this.tik;
            this.tik.Size = new System.Drawing.Size(41, 39);
            this.tik.TabIndex = 55;
            this.tik.TabStop = false;
            this.tik.Click += new System.EventHandler(this.tik_Click);
            // 
            // KayıtDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 539);
            this.Controls.Add(this.lblcancel);
            this.Controls.Add(this.tik);
            this.Controls.Add(this.btnBilgiGetir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTCbilgiGetir);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdogumtarihi);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtcinsiyet);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayıtDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtDuzenle";
            ((System.ComponentModel.ISupportInitialize)(this.tik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnguncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdogumtarihi;
        private Guna.UI2.WinForms.Guna2TextBox mskTC;
        private Guna.UI2.WinForms.Guna2ComboBox txtcinsiyet;
        private Guna.UI2.WinForms.Guna2TextBox mskTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox mskTCbilgiGetir;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnBilgiGetir;
        private Guna.UI2.WinForms.Guna2TextBox txtadsoyad;
        private System.Windows.Forms.Label lblcancel;
        private Guna.UI2.WinForms.Guna2PictureBox tik;
    }
}