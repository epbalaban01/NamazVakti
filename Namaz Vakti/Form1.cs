using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Reflection;
using WMPLib;

namespace Namaz_Vakti
{
    public partial class Form1 : Form
    {

        public OleDbConnection database;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=namaz.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbDataReader oku;
        NotifyIcon notify_Icon = new NotifyIcon();

        WindowsMediaPlayer wmp = new WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guncelle();
            timer1.Start();

            dateTimePicker1.Text = DateTime.Now.ToLongDateString();

            notify_Icon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            bildirim();
            timer3.Start();
            timer4.Start();
        }


        public event EventHandler MinimizeEvent;
        protected virtual void OnMinimize(EventArgs e)
        {
            if (MinimizeEvent != null) MinimizeEvent(this, e);
            {
                NotifyIcon();
               
            }
        }

        private const int WM_SYSCOMMAND = 0x0112, SC_MINIMIZE = 0xf020;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && m.WParam == (IntPtr)SC_MINIMIZE)
            {
                m.Result = (IntPtr)1;
                OnMinimize(new EventArgs());

                return;
            }
            base.WndProc(ref m);

        }

        void NotifyIcon()
        {
            this.Hide();
            notify_Icon.Visible = true;
            notify_Icon.ContextMenuStrip = contextMenuStrip1;

            // notifyIcon için event ataması yaptık
            notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
        }

        private void guncelle()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbCommand verioku = new OleDbCommand("select * from gebze where tarih = @tarih", baglanti);
            verioku.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            oku = verioku.ExecuteReader();

            while (oku.Read())
            {
                lblTarih.Text = oku["tarih"].ToString();
                lblimsak.Text = oku["imsak"].ToString();
                lblgunes.Text = oku["gunes"].ToString();
                lblogle.Text = oku["ogle"].ToString();
                lblikindi.Text = oku["ikindi"].ToString();
                lblaksam.Text = oku["aksam"].ToString();
                lblyatsi.Text = oku["yatsi"].ToString();
                lblSehir.Text = oku["ilce"].ToString();
                lblUlke.Text = "Türkiye";


            }
            oku.Close();
            baglanti.Close();       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();

            ezanvakti();
            KalanVakit();
          
        }


        private void ezanvakti()
        {

            TimeSpan imsak = TimeSpan.Parse(lblimsak.Text);
            TimeSpan sabah = TimeSpan.Parse(lblgunes.Text); // 10 PM
            TimeSpan ogle = TimeSpan.Parse(lblogle.Text);
            TimeSpan ikindi = TimeSpan.Parse(lblikindi.Text);
            TimeSpan aksam = TimeSpan.Parse(lblaksam.Text);
            TimeSpan yatsi = TimeSpan.Parse(lblyatsi.Text);
            TimeSpan gece = TimeSpan.Parse("00:00");

            TimeSpan now = DateTime.Now.TimeOfDay;

            try
            {
                if ((now > imsak) && (now < sabah))
                {
                    label2.Text = "Şimdi İmsak Vakti";

                    timer2.Start();
                }
                if ((now > sabah) && (now < ogle))
                {
                    label2.Text = "Şimdi Güneş Vakti";

                    timer2.Start();
                }
                else if ((now > ogle) && (now < ikindi))
                {
                    label2.Text = "Şimdi Öğle Vakti";

                    timer2.Start();
                }
                else if ((now > ikindi) && (now < aksam))
                {
                    label2.Text = "Şimdi İkindi Vakti";
                 
                    timer2.Start();
                }
                else if ((now > aksam) && (now < yatsi))
                {
                    label2.Text = "Şimdi Akşam Vakti";

                    timer2.Start();
                }
                else if ((now > gece))
                {
                    label2.Text = "Şimdi Yatsı Vakti";

                    timer2.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }

        }

        private void bildirim()
        {

           

        }

        private void KalanVakit()
        {
           
            string suankiSaat = DateTime.Now.ToShortTimeString();
            string bitisSaati = label1.Text;

            TimeSpan fark = DateTime.Parse(bitisSaati).Subtract(DateTime.Parse(suankiSaat));
            string calismasüresi = fark.TotalMinutes.ToString();
            label9.Text = calismasüresi;


           


        }

        private void KalanVakitBildirim()
        {
            String hourMinute = DateTime.Now.ToString("mm");
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }

        private void uygulamayıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }

        
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğini Emin Misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Güzel");
            }
        }

        private void ezanıDurdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            ezanıDurdurToolStripMenuItem.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(label2.Text == "Şimdi İmsak Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = lblgunes.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "Sabah'a Kalan Süre";
                panel10.Visible = false;
                //

            }
            else if (label2.Text == "Şimdi Güneş Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = lblogle.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "Öğlen'e Kalan Süre";
                panel10.Visible = false;
                //
            }
            else if (label2.Text == "Şimdi Öğle Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = lblikindi.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "İkindi'ye Kalan Süre";
                panel10.Visible = false;
                //
            }
            else if (label2.Text == "Şimdi İkindi Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = lblaksam.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "Akşam'a Kalan Süre";
                panel10.Visible = false;
                //
            }
            else if (label2.Text == "Şimdi Akşam Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = lblyatsi.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "Yatsı'ya Kalan Süre";
                panel10.Visible = false;
                //
            }
            else if (label2.Text == "Şimdi Yatsı Vakti")
            {
                //kalan saat süresi
                string girisZamani = DateTime.Now.ToLongTimeString();
                string cikisZamani = label1.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                string calismaSuresi = girisCikisFarki.ToString();
                lblKalanSaat.Text = calismaSuresi.ToString();
                label10.Text = "İmsak'a Kalan Süre";
                panel10.Visible = false;
                //
            }
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (label9.Text == "2")
            {
                //*Bildirim Mesajı
                Hide();
                notify_Icon.Visible = true;
                notify_Icon.BalloonTipTitle = "Akşama Kalan Süre";
                notify_Icon.BalloonTipText = "Akşama 30 dakika kaldı. \nSaat : " + DateTime.Now.ToShortTimeString();
                notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
                notify_Icon.ShowBalloonTip(30000);
                notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
                //
                timer3.Stop();
                return;
               

            }
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToShortTimeString() == lblogle.Text)
            {
                //*Bildirim Mesajı
                Hide();
                notify_Icon.Visible = true;
                notify_Icon.BalloonTipTitle = "Öğle Vakti";
                notify_Icon.BalloonTipText = "Öğle ezanı vakti gelmiştir. \nSaat : " + DateTime.Now.ToShortTimeString();
                notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
                notify_Icon.ShowBalloonTip(30000);
                notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
                //
                //*Ezan Okuma
                wmp.URL = Application.StartupPath + @"\ses\ogle.wma";
                wmp.controls.play();
                //
                timer4.Stop();
                return;
            }
            else if (DateTime.Now.ToShortTimeString() == lblikindi.Text)
            {
                //*Bildirim Mesajı
                Hide();
                notify_Icon.Visible = true;
                notify_Icon.BalloonTipTitle = "İkindi Vakti";
                notify_Icon.BalloonTipText = "İkindi ezanı vakti gelmiştir. \nSaat : " + DateTime.Now.ToShortTimeString();
                notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
                notify_Icon.ShowBalloonTip(30000);
                notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
                //

                //*Ezan Okuma
                wmp.URL = Application.StartupPath + @"\ses\ikindi.wma";
                wmp.controls.play();
                //
                timer4.Stop();
                return;
            }
            else if (DateTime.Now.ToShortTimeString() == lblaksam.Text)
            {
                //*Bildirim Mesajı
                Hide();
                notify_Icon.Visible = true;
                notify_Icon.BalloonTipTitle = "Akşam Vakti";
                notify_Icon.BalloonTipText = "Akşam ezanı vakti gelmiştir. \nSaat : " + DateTime.Now.ToShortTimeString();
                notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
                notify_Icon.ShowBalloonTip(30000);
                notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
                //

                //*Ezan Okuma
                wmp.URL = Application.StartupPath + @"\ses\aksam.wma";
                wmp.controls.play();
                //
                timer4.Stop();
                return;
            }
            else if (DateTime.Now.ToShortTimeString() == lblyatsi.Text)
            {
                //*Bildirim Mesajı
                Hide();
                notify_Icon.Visible = true;
                notify_Icon.BalloonTipTitle = "Yatsı Vakti";
                notify_Icon.BalloonTipText = "Yatsı ezanı vakti gelmiştir. \nSaat : " + DateTime.Now.ToShortTimeString();
                notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
                notify_Icon.ShowBalloonTip(30000);
                notify_Icon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
                //

                //*Ezan Okuma
                wmp.URL = Application.StartupPath + @"\ses\yatsi.wma";
                wmp.controls.play();
                //
                timer4.Stop();
                return;


            }
        
        }

        private void btn_EzanDurdur_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();

        }
    }
}
