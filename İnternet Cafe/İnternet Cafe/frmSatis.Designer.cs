namespace İnternet_Cafe
{
    partial class frmSatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiÇağırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HareketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBosMasalar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonSuresiz = new System.Windows.Forms.RadioButton();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.internetCafe2DataSet = new İnternet_Cafe.InternetCafe2DataSet();
            this.tBLSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLSaatUcretiTableAdapter = new İnternet_Cafe.InternetCafe2DataSetTableAdapters.TBLSaatUcretiTableAdapter();
            this.internetCafe2DataSet1 = new İnternet_Cafe.InternetCafe2DataSet1();
            this.tBLSaatUcretiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLSaatUcretiTableAdapter1 = new İnternet_Cafe.InternetCafe2DataSet1TableAdapters.TBLSaatUcretiTableAdapter();
            this.comboSaatUcreti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMasaDegistir = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafe2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafe2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource1)).BeginInit();
            this.pnlTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "Adsız tasarım.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(3, -21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 104);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "Masa -1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiÇağırToolStripMenuItem,
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(299, 100);
            // 
            // yöneticiÇağırToolStripMenuItem
            // 
            this.yöneticiÇağırToolStripMenuItem.Name = "yöneticiÇağırToolStripMenuItem";
            this.yöneticiÇağırToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.yöneticiÇağırToolStripMenuItem.Text = "Yönetici Çağır";
            this.yöneticiÇağırToolStripMenuItem.Click += new System.EventHandler(this.yöneticiÇağırToolStripMenuItem_Click);
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süresiz Masa Açma İsteği Gönder";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click);
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği Gönder";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem2.Text = "30";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem3.Text = "45";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem4.Text = "60";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem5.Text = "75";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem6.Text = "90";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem7.Text = "105";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem8.Text = "120";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem9.Text = "135";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem10.Text = "150";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem11.Text = "165";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem12.Text = "180";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // masaDeğiştirmeİsteğiGönderToolStripMenuItem
            // 
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Name = "masaDeğiştirmeİsteğiGönderToolStripMenuItem";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Text = "Masa Değiştirme İsteği Gönder";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.masaDeğiştirmeİsteğiGönderToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pc.jpg");
            this.ımageList1.Images.SetKeyName(1, "pc1.png");
            this.ımageList1.Images.SetKeyName(2, "1.jpeg");
            this.ımageList1.Images.SetKeyName(3, "Adsız tasarım.png");
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "Adsız tasarım.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(160, -21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 104);
            this.button2.TabIndex = 0;
            this.button2.Tag = "2"; //sırayla değiştirir misin
            this.button2.Text = "Masa -2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "Adsız tasarım.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(322, -21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 104);
            this.button3.TabIndex = 0;
            this.button3.Tag = "3";
            this.button3.Text = "Masa -3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "Adsız tasarım.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(484, -21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 104);
            this.button4.TabIndex = 0;
            this.button4.Tag = "4";
            this.button4.Text = "Masa -4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button5
            // 
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "Adsız tasarım.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(646, -21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 104);
            this.button5.TabIndex = 0;
            this.button5.Tag = "5";
            this.button5.Text = "Masa -5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button6
            // 
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageKey = "Adsız tasarım.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(808, -21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 104);
            this.button6.TabIndex = 0;
            this.button6.Tag = "6";
            this.button6.Text = "Masa -6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button7
            // 
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageKey = "Adsız tasarım.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(970, -21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 104);
            this.button7.TabIndex = 0;
            this.button7.Tag = "7";
            this.button7.Text = "Masa -7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HareketID,
            this.KullaniciID,
            this.MasaID,
            this.Masa,
            this.IstekTuru,
            this.Aciklama,
            this.Tarih});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1127, 182);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HareketID
            // 
            this.HareketID.Text = "istek ID";
            // 
            // KullaniciID
            // 
            this.KullaniciID.Text = "Kullanici ID";
            // 
            // MasaID
            // 
            this.MasaID.Text = "Masa ID";
            // 
            // Masa
            // 
            this.Masa.Text = "Masa";
            // 
            // IstekTuru
            // 
            this.IstekTuru.Text = "İstek Türü";
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Masa_ID,
            this._Masa,
            this.AcilisTuru,
            this.BaslamaSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this._Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(11, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 325);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SepetID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.HeaderText = "Masa ID";
            this.Masa_ID.MinimumWidth = 6;
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            // 
            // _Masa
            // 
            this._Masa.DataPropertyName = "Masa";
            this._Masa.HeaderText = "Masa";
            this._Masa.MinimumWidth = 6;
            this._Masa.Name = "_Masa";
            this._Masa.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü(dk)";
            this.AcilisTuru.MinimumWidth = 6;
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.MinimumWidth = 6;
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            // 
            // BitisSaati
            // 
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.MinimumWidth = 6;
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre(Saat)";
            this.Sure.MinimumWidth = 6;
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar(TL)";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // _Tarih
            // 
            this._Tarih.DataPropertyName = "Tarih";
            this._Tarih.HeaderText = "Tarih";
            this._Tarih.MinimumWidth = 6;
            this._Tarih.Name = "_Tarih";
            this._Tarih.ReadOnly = true;
            // 
            // Hesapla
            // 
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.MinimumWidth = 6;
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesaplama Yapar";
            this.Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.MinimumWidth = 6;
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa kapat";
            this.MasaKapat.ToolTipText = "Masayı Kapatır";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1145, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boş Masalar";
            // 
            // comboBosMasalar
            // 
            this.comboBosMasalar.FormattingEnabled = true;
            this.comboBosMasalar.Location = new System.Drawing.Point(1145, 370);
            this.comboBosMasalar.Name = "comboBosMasalar";
            this.comboBosMasalar.Size = new System.Drawing.Size(156, 24);
            this.comboBosMasalar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton11);
            this.panel1.Controls.Add(this.radioButton9);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButtonSuresiz);
            this.panel1.Location = new System.Drawing.Point(1148, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 178);
            this.panel1.TabIndex = 5;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(84, 134);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(49, 20);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "180";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(85, 108);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(49, 20);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "150";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(85, 82);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(49, 20);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "120";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(85, 56);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(42, 20);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "90";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(85, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "60";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(3, 134);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(49, 20);
            this.radioButton11.TabIndex = 0;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "165";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(4, 108);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(49, 20);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "135";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(4, 82);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(49, 20);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "105";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(4, 56);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(42, 20);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "75";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "45";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButtonSuresiz
            // 
            this.radioButtonSuresiz.AutoSize = true;
            this.radioButtonSuresiz.Location = new System.Drawing.Point(4, 4);
            this.radioButtonSuresiz.Name = "radioButtonSuresiz";
            this.radioButtonSuresiz.Size = new System.Drawing.Size(72, 20);
            this.radioButtonSuresiz.TabIndex = 0;
            this.radioButtonSuresiz.TabStop = true;
            this.radioButtonSuresiz.Text = "Süresiz";
            this.radioButtonSuresiz.UseVisualStyleBackColor = true;
            this.radioButtonSuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(1145, 584);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(153, 62);
            this.btnMasaAc.TabIndex = 6;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // internetCafe2DataSet
            // 
            this.internetCafe2DataSet.DataSetName = "InternetCafe2DataSet";
            this.internetCafe2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSaatUcretiBindingSource
            // 
            this.tBLSaatUcretiBindingSource.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource.DataSource = this.internetCafe2DataSet;
            // 
            // tBLSaatUcretiTableAdapter
            // 
            this.tBLSaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // internetCafe2DataSet1
            // 
            this.internetCafe2DataSet1.DataSetName = "InternetCafe2DataSet1";
            this.internetCafe2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSaatUcretiBindingSource1
            // 
            this.tBLSaatUcretiBindingSource1.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource1.DataSource = this.internetCafe2DataSet1;
            // 
            // tBLSaatUcretiTableAdapter1
            // 
            this.tBLSaatUcretiTableAdapter1.ClearBeforeFill = true;
            // 
            // comboSaatUcreti
            // 
            this.comboSaatUcreti.DataSource = this.tBLSaatUcretiBindingSource;
            this.comboSaatUcreti.DisplayMember = "SaatUcreti";
            this.comboSaatUcreti.FormattingEnabled = true;
            this.comboSaatUcreti.Location = new System.Drawing.Point(1144, 268);
            this.comboSaatUcreti.Name = "comboSaatUcreti";
            this.comboSaatUcreti.Size = new System.Drawing.Size(156, 24);
            this.comboSaatUcreti.TabIndex = 8;
            this.comboSaatUcreti.ValueMember = "SaatUcretiID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1145, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saat Ücreti";
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.button16);
            this.pnlTables.Controls.Add(this.button8);
            this.pnlTables.Controls.Add(this.button9);
            this.pnlTables.Controls.Add(this.button10);
            this.pnlTables.Controls.Add(this.button1);
            this.pnlTables.Controls.Add(this.button11);
            this.pnlTables.Controls.Add(this.button2);
            this.pnlTables.Controls.Add(this.button12);
            this.pnlTables.Controls.Add(this.button3);
            this.pnlTables.Controls.Add(this.button13);
            this.pnlTables.Controls.Add(this.button4);
            this.pnlTables.Controls.Add(this.button14);
            this.pnlTables.Controls.Add(this.button5);
            this.pnlTables.Controls.Add(this.button15);
            this.pnlTables.Controls.Add(this.button6);
            this.pnlTables.Controls.Add(this.button7);
            this.pnlTables.Location = new System.Drawing.Point(13, 12);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1294, 196);
            this.pnlTables.TabIndex = 9;
            // 
            // button16
            // 
            this.button16.ContextMenuStrip = this.contextMenuStrip1;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ImageKey = "Adsız tasarım.png";
            this.button16.ImageList = this.ımageList1;
            this.button16.Location = new System.Drawing.Point(1131, 82);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(156, 104);
            this.button16.TabIndex = 2;
            this.button16.Tag = "Masa-16";
            this.button16.Text = "Masa -16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ImageKey = "Adsız tasarım.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(1131, -21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 104);
            this.button8.TabIndex = 1;
            this.button8.Tag = "8";
            this.button8.Text = "Masa -8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ImageKey = "Adsız tasarım.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(3, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 104);
            this.button9.TabIndex = 0;
            this.button9.Tag = "9";
            this.button9.Text = "Masa -9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageKey = "Adsız tasarım.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(160, 82);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(156, 104);
            this.button10.TabIndex = 0;
            this.button10.Tag = "10";
            this.button10.Text = "Masa -10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImageKey = "Adsız tasarım.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(322, 82);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 104);
            this.button11.TabIndex = 0;
            this.button11.Tag = "11";
            this.button11.Text = "Masa -11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ImageKey = "Adsız tasarım.png";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(484, 82);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(156, 104);
            this.button12.TabIndex = 0;
            this.button12.Tag = "12";
            this.button12.Text = "Masa -12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.ContextMenuStrip = this.contextMenuStrip1;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ImageKey = "Adsız tasarım.png";
            this.button13.ImageList = this.ımageList1;
            this.button13.Location = new System.Drawing.Point(655, 82);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(156, 104);
            this.button13.TabIndex = 0;
            this.button13.Tag = "13";
            this.button13.Text = "Masa -13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.ContextMenuStrip = this.contextMenuStrip1;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ImageKey = "Adsız tasarım.png";
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(808, 82);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(156, 104);
            this.button14.TabIndex = 0;
            this.button14.Tag = "14";
            this.button14.Text = "Masa -14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.ContextMenuStrip = this.contextMenuStrip1;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ImageKey = "Adsız tasarım.png";
            this.button15.ImageList = this.ımageList1;
            this.button15.Location = new System.Drawing.Point(970, 82);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(156, 104);
            this.button15.TabIndex = 0;
            this.button15.Tag = "15";
            this.button15.Text = "Masa -15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMasaDegistir
            // 
            this.btnMasaDegistir.Location = new System.Drawing.Point(1144, 653);
            this.btnMasaDegistir.Name = "btnMasaDegistir";
            this.btnMasaDegistir.Size = new System.Drawing.Size(153, 62);
            this.btnMasaDegistir.TabIndex = 6;
            this.btnMasaDegistir.Text = "Masa Değiştir";
            this.btnMasaDegistir.UseVisualStyleBackColor = true;
            this.btnMasaDegistir.Click += new System.EventHandler(this.btnMasaDegistir_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(1144, 721);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(153, 62);
            this.btnGeriAl.TabIndex = 6;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 802);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.comboSaatUcreti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnMasaDegistir);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBosMasalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Name = "frmSatis";
            this.Text = "Satış Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSatis_FormClosing);
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafe2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafe2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource1)).EndInit();
            this.pnlTables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBosMasalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonSuresiz;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiÇağırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem masaDeğiştirmeİsteğiGönderToolStripMenuItem;
        private InternetCafe2DataSet internetCafe2DataSet;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource;
        private InternetCafe2DataSetTableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter;
        private InternetCafe2DataSet1 internetCafe2DataSet1;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource1;
        private InternetCafe2DataSet1TableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter1;
        private System.Windows.Forms.ComboBox comboSaatUcreti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColumnHeader HareketID;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.ColumnHeader MasaID;
        private System.Windows.Forms.ColumnHeader Masa;
        private System.Windows.Forms.ColumnHeader IstekTuru;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasaDegistir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
        private System.Windows.Forms.Button btnGeriAl;
    }
}

