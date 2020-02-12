using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Main : Form
    {
        readonly DbClass dbc = new DbClass();
        private readonly Form_Login LogFrm = new Form_Login();
        readonly EditClass Uredi = new EditClass();
        OleDbConnection conn = null;

        //O aplikaciji
        readonly string MB_NazivAplikacija = "O aplikaciji KPP";
        readonly string appName = "Knjiga primljenih pošiljki (KPP)";
        readonly string appVersion = "Version 1.0.0.0";
        readonly string appAuthor = "Miroslav Vranić";
        readonly string aboutApp = "Aplikcaija Knjiga primljenih pošiljki je napravaljena kao projekt na predmetu Objektno orijentirano programiranje 2 " +
            "na TVZ-u godina 2017/2018 i proširena kao završni rad 'Aplikacija za evidneciju primljenih pošiljki' br. 3219 TVZ rujan 2019." +
            "\n\nIkone aplikacije su skinute sa: \nhttp://www.freepik.com \nhttp://www.flaticon.com" +
            "\nhttps://www.flaticon.com/authors/smashicons \nhttps://www.flaticon.com/ \nhttp://creativecommons.org/licenses/by/3.0/";
        public Form_Main()
        {
            InitializeComponent();
        }
        private void IzađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ZatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                this.Close();
            }
            else
            {
                ActiveMdiChild.Close();
            }
        }
        private void FormaKPP()
        {
            Form_KPP form = new Form_KPP();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaKorisnici()
        {
            Form_Korisnici form = new Form_Korisnici();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaOdjeli()
        {
            Form_Odjeli form = new Form_Odjeli();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaPosiljatelji()
        {
            Form_Posiljatelji form = new Form_Posiljatelji();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaMjesta()
        {
            Form_Mjesta form = new Form_Mjesta();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaIzvoz()
        {
            Form_Izvoz form = new Form_Izvoz();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void OtvoriKPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaKPP();
            }
            else
            {
                FormaKPP();
            }
        }
        private void DodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaKorisnici();
            }
            else
            {
                FormaKorisnici();
            }
        }
        private void DodajOdjelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaOdjeli();
            }
            else
            {
                FormaOdjeli();
            }
        }
        private void PošiljateljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaPosiljatelji();
            }
            else
            {
                FormaPosiljatelji();
            }
        }
        private void MjestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaMjesta();
            }
            else
            {
                FormaMjesta();
            }
        }
        private void IzvozPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaIzvoz();
            }
            else
            {
                FormaIzvoz();
            }
        }
        private void SpojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(dbc.conn_string);
                conn.Open();
                odspojiToolStripMenuItem.Enabled = true;
                spojiToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbc.ExError + ex.Message, dbc.CelijaNazivUpozorenje);
            }
        }
        private void OdspojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            odspojiToolStripMenuItem.Enabled = false;
            spojiToolStripMenuItem.Enabled = true;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            spojiToolStripMenuItem.PerformClick();
            using (Form_Login LogForm = new Form_Login())
            {
                if (LogFrm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    string _korime = EditClass.KorisnickoIme;
                    string IzTablice = "korisnici";
                    string GdjeTrazim = "korisnickoIme";
                    string Uloga = Uredi.UlogaUlogiranogKor(_korime, IzTablice, GdjeTrazim);
                    if (Uloga == "Administrator")
                    {
                        dodajKorisnikaToolStripMenuItem.Visible = true;
                        FormaKPP();
                    }
                    else
                    {
                        FormaKPP();
                    }
                }
            }
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            odspojiToolStripMenuItem.PerformClick();
        }
        private void OAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija:\t" + appName + "\nVerzija aplikacije:\t" + appVersion + "\nAutor aplikacije:\t" + appAuthor + "\n\nO aplikaciji:\n" + aboutApp, MB_NazivAplikacija);
        }
    }
}
