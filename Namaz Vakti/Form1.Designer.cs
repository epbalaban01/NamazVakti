namespace Namaz_Vakti
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSehir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblyatsi = new System.Windows.Forms.Label();
            this.lblaksam = new System.Windows.Forms.Label();
            this.lblikindi = new System.Windows.Forms.Label();
            this.lblogle = new System.Windows.Forms.Label();
            this.lblgunes = new System.Windows.Forms.Label();
            this.lblimsak = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblKalanSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrVakit = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uygulamayıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.diniGünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ezanıDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUlke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.ForeColor = System.Drawing.Color.White;
            this.lblSehir.Location = new System.Drawing.Point(3, 26);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(49, 19);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Sehir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yatsı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Akşam";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "İkindi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Güneş";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "İmsak";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblyatsi
            // 
            this.lblyatsi.AutoSize = true;
            this.lblyatsi.BackColor = System.Drawing.Color.Transparent;
            this.lblyatsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyatsi.ForeColor = System.Drawing.Color.White;
            this.lblyatsi.Location = new System.Drawing.Point(155, 158);
            this.lblyatsi.Name = "lblyatsi";
            this.lblyatsi.Size = new System.Drawing.Size(46, 15);
            this.lblyatsi.TabIndex = 0;
            this.lblyatsi.Text = "[HH:ss]";
            this.lblyatsi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblaksam
            // 
            this.lblaksam.AutoSize = true;
            this.lblaksam.BackColor = System.Drawing.Color.Transparent;
            this.lblaksam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaksam.ForeColor = System.Drawing.Color.White;
            this.lblaksam.Location = new System.Drawing.Point(155, 132);
            this.lblaksam.Name = "lblaksam";
            this.lblaksam.Size = new System.Drawing.Size(46, 15);
            this.lblaksam.TabIndex = 0;
            this.lblaksam.Text = "[HH:ss]";
            this.lblaksam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblikindi
            // 
            this.lblikindi.AutoSize = true;
            this.lblikindi.BackColor = System.Drawing.Color.Transparent;
            this.lblikindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblikindi.ForeColor = System.Drawing.Color.White;
            this.lblikindi.Location = new System.Drawing.Point(155, 106);
            this.lblikindi.Name = "lblikindi";
            this.lblikindi.Size = new System.Drawing.Size(46, 15);
            this.lblikindi.TabIndex = 0;
            this.lblikindi.Text = "[HH:ss]";
            this.lblikindi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblogle
            // 
            this.lblogle.AutoSize = true;
            this.lblogle.BackColor = System.Drawing.Color.Transparent;
            this.lblogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogle.ForeColor = System.Drawing.Color.White;
            this.lblogle.Location = new System.Drawing.Point(155, 80);
            this.lblogle.Name = "lblogle";
            this.lblogle.Size = new System.Drawing.Size(46, 15);
            this.lblogle.TabIndex = 0;
            this.lblogle.Text = "[HH:ss]";
            this.lblogle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgunes
            // 
            this.lblgunes.AutoSize = true;
            this.lblgunes.BackColor = System.Drawing.Color.Transparent;
            this.lblgunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgunes.ForeColor = System.Drawing.Color.White;
            this.lblgunes.Location = new System.Drawing.Point(155, 54);
            this.lblgunes.Name = "lblgunes";
            this.lblgunes.Size = new System.Drawing.Size(46, 15);
            this.lblgunes.TabIndex = 0;
            this.lblgunes.Text = "[HH:ss]";
            this.lblgunes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblimsak
            // 
            this.lblimsak.AutoSize = true;
            this.lblimsak.BackColor = System.Drawing.Color.Transparent;
            this.lblimsak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblimsak.ForeColor = System.Drawing.Color.White;
            this.lblimsak.Location = new System.Drawing.Point(155, 29);
            this.lblimsak.Name = "lblimsak";
            this.lblimsak.Size = new System.Drawing.Size(46, 15);
            this.lblimsak.TabIndex = 0;
            this.lblimsak.Text = "[HH:ss]";
            this.lblimsak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(127, 3);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(79, 15);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "[tarih]";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSaat
            // 
            this.lblSaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(116, 29);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(91, 16);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "[00:00:00]";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKalanSaat
            // 
            this.lblKalanSaat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSaat.ForeColor = System.Drawing.Color.White;
            this.lblKalanSaat.Location = new System.Drawing.Point(9, 201);
            this.lblKalanSaat.Name = "lblKalanSaat";
            this.lblKalanSaat.Size = new System.Drawing.Size(196, 24);
            this.lblKalanSaat.TabIndex = 0;
            this.lblKalanSaat.Text = "[00:00:00]";
            this.lblKalanSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrVakit
            // 
            this.tmrVakit.Interval = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 22, 9, 53, 59, 0);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Balaban Ezan Vakti";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamayıAçToolStripMenuItem,
            this.toolStripSeparator1,
            this.diniGünlerToolStripMenuItem,
            this.genelAyarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.ezanıDurdurToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 148);
            // 
            // uygulamayıAçToolStripMenuItem
            // 
            this.uygulamayıAçToolStripMenuItem.Name = "uygulamayıAçToolStripMenuItem";
            this.uygulamayıAçToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.uygulamayıAçToolStripMenuItem.Text = "Uygulamayı Aç";
            this.uygulamayıAçToolStripMenuItem.Click += new System.EventHandler(this.uygulamayıAçToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // diniGünlerToolStripMenuItem
            // 
            this.diniGünlerToolStripMenuItem.Name = "diniGünlerToolStripMenuItem";
            this.diniGünlerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.diniGünlerToolStripMenuItem.Text = "Dini Günler";
            // 
            // genelAyarlarToolStripMenuItem
            // 
            this.genelAyarlarToolStripMenuItem.Name = "genelAyarlarToolStripMenuItem";
            this.genelAyarlarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.genelAyarlarToolStripMenuItem.Text = "Genel Ayarlar";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // ezanıDurdurToolStripMenuItem
            // 
            this.ezanıDurdurToolStripMenuItem.Name = "ezanıDurdurToolStripMenuItem";
            this.ezanıDurdurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ezanıDurdurToolStripMenuItem.Text = "Ezanı Durdur";
            this.ezanıDurdurToolStripMenuItem.Click += new System.EventHandler(this.ezanıDurdurToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUlke.ForeColor = System.Drawing.Color.White;
            this.lblUlke.Location = new System.Drawing.Point(3, 3);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(44, 17);
            this.lblUlke.TabIndex = 0;
            this.lblUlke.Text = "[Ulke]";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "[KalanVakit]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel2.Location = new System.Drawing.Point(6, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel3.Location = new System.Drawing.Point(6, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 2);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel4.Location = new System.Drawing.Point(6, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 2);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel5.Location = new System.Drawing.Point(2, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 2);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel6.Location = new System.Drawing.Point(6, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 2);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(246)))), ((int)(((byte)(180)))));
            this.panel7.Location = new System.Drawing.Point(2, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 2);
            this.panel7.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "[0] Kalan Süre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.lblyatsi);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.lblKalanSaat);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.lblimsak);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.lblgunes);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.lblogle);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.lblikindi);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.lblaksam);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(7, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(209, 230);
            this.panel8.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Green;
            this.panel10.Location = new System.Drawing.Point(5, 156);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 21);
            this.panel10.TabIndex = 5;
            this.panel10.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "23:59";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblUlke);
            this.panel9.Controls.Add(this.lblTarih);
            this.panel9.Controls.Add(this.lblSehir);
            this.panel9.Controls.Add(this.lblSaat);
            this.panel9.Location = new System.Drawing.Point(7, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(209, 48);
            this.panel9.TabIndex = 7;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "home_512px.png");
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Namaz_Vakti.Properties.Resources.audio_52px;
            this.pictureBox2.Location = new System.Drawing.Point(184, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Namaz_Vakti.Properties.Resources.info_52px;
            this.pictureBox3.Location = new System.Drawing.Point(126, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Namaz_Vakti.Properties.Resources.marker_52px;
            this.pictureBox4.Location = new System.Drawing.Point(45, 297);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Namaz_Vakti.Properties.Resources.settings_52px;
            this.pictureBox5.Location = new System.Drawing.Point(83, 297);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Namaz_Vakti.Properties.Resources.home_52px;
            this.pictureBox6.Location = new System.Drawing.Point(7, 297);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(112, 48);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gösterToolStripMenuItem.Text = "Göster ";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(229, 341);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Namaz Vakti ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblyatsi;
        private System.Windows.Forms.Label lblaksam;
        private System.Windows.Forms.Label lblikindi;
        private System.Windows.Forms.Label lblogle;
        private System.Windows.Forms.Label lblgunes;
        private System.Windows.Forms.Label lblimsak;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblKalanSaat;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrVakit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem genelAyarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diniGünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ezanıDurdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label9;
    }
}

