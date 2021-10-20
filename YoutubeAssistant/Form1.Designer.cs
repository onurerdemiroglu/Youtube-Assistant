namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslik = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.TextBox();
            this.videoyeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kanallar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.yenile = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.ListBox();
            this.toplamvideo = new System.Windows.Forms.TextBox();
            this.Gönder = new DevExpress.XtraEditors.SimpleButton();
            this.kanallink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.kod1 = new System.Windows.Forms.TextBox();
            this.kod2 = new System.Windows.Forms.TextBox();
            this.kanalismi = new System.Windows.Forms.TextBox();
            this.indirmelinki = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.aciklama2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.etiket2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.baslik2 = new System.Windows.Forms.TextBox();
            this.indirlink = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.Yenilekanal = new DevExpress.XtraEditors.SimpleButton();
            this.ApiKanal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ApiAl = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.yenile2 = new DevExpress.XtraEditors.SimpleButton();
            this.Kanallar2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.tags = new System.Windows.Forms.ListBox();
            this.apikey = new System.Windows.Forms.TextBox();
            this.videoid = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Dosyayaz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Kanallar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApiKanal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanallar2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(138, 74);
            this.baslik.Multiline = true;
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(266, 30);
            this.baslik.TabIndex = 1;
            // 
            // aciklama
            // 
            this.aciklama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama.Location = new System.Drawing.Point(138, 125);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(266, 135);
            this.aciklama.TabIndex = 2;
            // 
            // tag
            // 
            this.tag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tag.Location = new System.Drawing.Point(138, 278);
            this.tag.Multiline = true;
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(266, 30);
            this.tag.TabIndex = 3;
            // 
            // videoyeri
            // 
            this.videoyeri.Location = new System.Drawing.Point(1105, 66);
            this.videoyeri.Multiline = true;
            this.videoyeri.Name = "videoyeri";
            this.videoyeri.Size = new System.Drawing.Size(266, 30);
            this.videoyeri.TabIndex = 5;
            this.videoyeri.Text = "videoyeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Etiket:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Başlık:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kanallar:";
            // 
            // Kanallar
            // 
            this.Kanallar.Location = new System.Drawing.Point(138, 27);
            this.Kanallar.Name = "Kanallar";
            // 
            // 
            // 
            this.Kanallar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kanallar.Properties.Appearance.Options.UseFont = true;
            this.Kanallar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Kanallar.Properties.Items.AddRange(new object[] {
            "eq",
            "qwe"});
            this.Kanallar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Kanallar.Size = new System.Drawing.Size(266, 26);
            this.Kanallar.TabIndex = 17;
            this.Kanallar.SelectedIndexChanged += new System.EventHandler(this.Kanallar_SelectedIndexChanged);
            // 
            // yenile
            // 
            this.yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yenile.ImageOptions.Image")));
            this.yenile.Location = new System.Drawing.Point(417, 33);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(22, 19);
            this.yenile.TabIndex = 18;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1105, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 264);
            this.listBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(448, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Atılabilir videolar:";
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.Location = new System.Drawing.Point(10, 511);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(1070, 121);
            this.Log.TabIndex = 25;
            // 
            // toplamvideo
            // 
            this.toplamvideo.Location = new System.Drawing.Point(1105, 40);
            this.toplamvideo.Name = "toplamvideo";
            this.toplamvideo.Size = new System.Drawing.Size(146, 20);
            this.toplamvideo.TabIndex = 22;
            this.toplamvideo.Text = "toplamvideo";
            // 
            // Gönder
            // 
            this.Gönder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Gönder.ImageOptions.Image")));
            this.Gönder.Location = new System.Drawing.Point(223, 314);
            this.Gönder.Name = "Gönder";
            this.Gönder.Size = new System.Drawing.Size(79, 43);
            this.Gönder.TabIndex = 27;
            this.Gönder.Text = "Gönder";
            this.Gönder.Click += new System.EventHandler(this.Gönder_Click);
            // 
            // kanallink
            // 
            this.kanallink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanallink.Location = new System.Drawing.Point(227, 77);
            this.kanallink.Name = "kanallink";
            this.kanallink.Size = new System.Drawing.Size(334, 27);
            this.kanallink.TabIndex = 28;
            this.kanallink.Text = "https://www.youtube.com/channel/UCFKr-F5_pYpn92-H0M8jmLg/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kanal Link:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(646, 77);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 43);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "İndir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // kod1
            // 
            this.kod1.Location = new System.Drawing.Point(1105, 113);
            this.kod1.Name = "kod1";
            this.kod1.Size = new System.Drawing.Size(334, 20);
            this.kod1.TabIndex = 33;
            this.kod1.Text = "youtube-dl --verbose --ignore-errors --playlist-start=1 -o \"";
            // 
            // kod2
            // 
            this.kod2.Location = new System.Drawing.Point(1105, 139);
            this.kod2.Name = "kod2";
            this.kod2.Size = new System.Drawing.Size(334, 20);
            this.kod2.TabIndex = 34;
            this.kod2.Text = "%(title)s.%(ext)s\" ";
            // 
            // kanalismi
            // 
            this.kanalismi.Location = new System.Drawing.Point(1105, 165);
            this.kanalismi.Name = "kanalismi";
            this.kanalismi.Size = new System.Drawing.Size(100, 20);
            this.kanalismi.TabIndex = 36;
            this.kanalismi.Text = "kanalismi";
            // 
            // indirmelinki
            // 
            this.indirmelinki.Location = new System.Drawing.Point(1105, 191);
            this.indirmelinki.Name = "indirmelinki";
            this.indirmelinki.Size = new System.Drawing.Size(100, 20);
            this.indirmelinki.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Log:";
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(452, 60);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(339, 251);
            this.listBox3.TabIndex = 28;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1070, 473);
            this.xtraTabControl1.TabIndex = 29;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.listBox3);
            this.xtraTabPage1.Controls.Add(this.aciklama);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.baslik);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.tag);
            this.xtraTabPage1.Controls.Add(this.yenile);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.Kanallar);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.Gönder);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Enabled = true;
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(938, 467);
            this.xtraTabPage1.Text = "    Upload";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.aciklama2);
            this.xtraTabPage2.Controls.Add(this.progressBar1);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.etiket2);
            this.xtraTabPage2.Controls.Add(this.label11);
            this.xtraTabPage2.Controls.Add(this.baslik2);
            this.xtraTabPage2.Controls.Add(this.indirlink);
            this.xtraTabPage2.Controls.Add(this.button3);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Enabled = true;
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(938, 467);
            this.xtraTabPage2.Text = "   Download";
            // 
            // aciklama2
            // 
            this.aciklama2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama2.Location = new System.Drawing.Point(180, 108);
            this.aciklama2.Multiline = true;
            this.aciklama2.Name = "aciklama2";
            this.aciklama2.Size = new System.Drawing.Size(559, 184);
            this.aciklama2.TabIndex = 44;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(275, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(354, 44);
            this.progressBar1.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(21, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "Video Etiketleri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Video Başlığı:";
            // 
            // etiket2
            // 
            this.etiket2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket2.Location = new System.Drawing.Point(180, 308);
            this.etiket2.Multiline = true;
            this.etiket2.Name = "etiket2";
            this.etiket2.Size = new System.Drawing.Size(559, 39);
            this.etiket2.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 18);
            this.label11.TabIndex = 48;
            this.label11.Text = "Video Açıklaması:";
            // 
            // baslik2
            // 
            this.baslik2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik2.Location = new System.Drawing.Point(180, 72);
            this.baslik2.Name = "baslik2";
            this.baslik2.Size = new System.Drawing.Size(559, 27);
            this.baslik2.TabIndex = 43;
            // 
            // indirlink
            // 
            this.indirlink.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indirlink.Location = new System.Drawing.Point(180, 39);
            this.indirlink.Name = "indirlink";
            this.indirlink.Size = new System.Drawing.Size(559, 27);
            this.indirlink.TabIndex = 49;
            this.indirlink.Text = "https://www.youtube.com/watch?v=4ufUNyhkhuM";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 42);
            this.button3.TabIndex = 42;
            this.button3.Text = "Verileri Çek";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(114, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "Link:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Controls.Add(this.Yenilekanal);
            this.xtraTabPage3.Controls.Add(this.ApiKanal);
            this.xtraTabPage3.Controls.Add(this.ApiAl);
            this.xtraTabPage3.Enabled = true;
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(938, 467);
            this.xtraTabPage3.Text = "    Api";
            // 
            // Yenilekanal
            // 
            this.Yenilekanal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Yenilekanal.ImageOptions.Image")));
            this.Yenilekanal.Location = new System.Drawing.Point(367, 14);
            this.Yenilekanal.Name = "Yenilekanal";
            this.Yenilekanal.Size = new System.Drawing.Size(22, 19);
            this.Yenilekanal.TabIndex = 42;
            this.Yenilekanal.Click += new System.EventHandler(this.Yenilekanal_Click);
            // 
            // ApiKanal
            // 
            this.ApiKanal.Location = new System.Drawing.Point(175, 9);
            this.ApiKanal.Name = "ApiKanal";
            // 
            // 
            // 
            this.ApiKanal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ApiKanal.Properties.Appearance.Options.UseFont = true;
            this.ApiKanal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApiKanal.Size = new System.Drawing.Size(177, 26);
            this.ApiKanal.TabIndex = 1;
            this.ApiKanal.SelectedIndexChanged += new System.EventHandler(this.ApiKanal_SelectedIndexChanged);
            // 
            // ApiAl
            // 
            this.ApiAl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ApiAl.Appearance.Options.UseFont = true;
            this.ApiAl.Location = new System.Drawing.Point(16, 3);
            this.ApiAl.Name = "ApiAl";
            this.ApiAl.Size = new System.Drawing.Size(144, 37);
            this.ApiAl.TabIndex = 0;
            this.ApiAl.Text = "Api";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.yenile2);
            this.xtraTabPage5.Controls.Add(this.Kanallar2);
            this.xtraTabPage5.Controls.Add(this.label8);
            this.xtraTabPage5.Controls.Add(this.label2);
            this.xtraTabPage5.Controls.Add(this.kanallink);
            this.xtraTabPage5.Controls.Add(this.simpleButton1);
            this.xtraTabPage5.Enabled = true;
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(938, 467);
            this.xtraTabPage5.Text = "    Toplu İndirme";
            // 
            // yenile2
            // 
            this.yenile2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yenile2.ImageOptions.Image")));
            this.yenile2.Location = new System.Drawing.Point(567, 42);
            this.yenile2.Name = "yenile2";
            this.yenile2.Size = new System.Drawing.Size(22, 19);
            this.yenile2.TabIndex = 29;
            this.yenile2.Click += new System.EventHandler(this.yenile2_Click);
            // 
            // Kanallar2
            // 
            this.Kanallar2.Location = new System.Drawing.Point(227, 39);
            this.Kanallar2.Name = "Kanallar2";
            // 
            // 
            // 
            this.Kanallar2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kanallar2.Properties.Appearance.Options.UseFont = true;
            this.Kanallar2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Kanallar2.Size = new System.Drawing.Size(334, 26);
            this.Kanallar2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(86, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kanallar:";
            // 
            // tags
            // 
            this.tags.FormattingEnabled = true;
            this.tags.Location = new System.Drawing.Point(1211, 228);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(98, 82);
            this.tags.TabIndex = 50;
            // 
            // apikey
            // 
            this.apikey.Location = new System.Drawing.Point(1105, 602);
            this.apikey.Multiline = true;
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(214, 19);
            this.apikey.TabIndex = 44;
            this.apikey.Text = "AIzaSyCnLqF4F6SQH9Wx7h9d3a8_iEZvm6qHfdU";
            // 
            // videoid
            // 
            this.videoid.Location = new System.Drawing.Point(1105, 575);
            this.videoid.Name = "videoid";
            this.videoid.Size = new System.Drawing.Size(214, 20);
            this.videoid.TabIndex = 43;
            this.videoid.Text = "4ufUNyhkhuM";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(1211, 191);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(62, 20);
            this.sifre.TabIndex = 4;
            this.sifre.Text = "sifre";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(1211, 164);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(62, 20);
            this.mail.TabIndex = 3;
            this.mail.Text = "mail";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(1105, 489);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(100, 69);
            this.listBox4.TabIndex = 39;
            // 
            // Dosyayaz
            // 
            this.Dosyayaz.Interval = 8000;
            this.Dosyayaz.Tick += new System.EventHandler(this.Dosyayaz_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 636);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.apikey);
            this.Controls.Add(this.indirmelinki);
            this.Controls.Add(this.videoid);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.kanalismi);
            this.Controls.Add(this.kod2);
            this.Controls.Add(this.kod1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.toplamvideo);
            this.Controls.Add(this.videoyeri);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Youtube Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kanallar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApiKanal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanallar2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.TextBox videoyeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit Kanallar;
        private DevExpress.XtraEditors.SimpleButton yenile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.TextBox toplamvideo;
        private DevExpress.XtraEditors.SimpleButton Gönder;
        private System.Windows.Forms.TextBox kanallink;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox kod1;
        private System.Windows.Forms.TextBox kod2;
        private System.Windows.Forms.TextBox kanalismi;
        private System.Windows.Forms.TextBox indirmelinki;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit Kanallar2;
        private DevExpress.XtraEditors.SimpleButton yenile2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3; 
        private DevExpress.XtraEditors.ComboBoxEdit ApiKanal;
        private DevExpress.XtraEditors.SimpleButton ApiAl;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox mail;
        private DevExpress.XtraEditors.SimpleButton Yenilekanal; 
        private System.Windows.Forms.TextBox apikey;
        private System.Windows.Forms.TextBox videoid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox tags;
        private System.Windows.Forms.TextBox etiket2;
        private System.Windows.Forms.TextBox aciklama2;
        private System.Windows.Forms.TextBox baslik2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox indirlink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.ProgressBar progressBar1; 
        private System.Windows.Forms.Timer Dosyayaz;
    }
}

