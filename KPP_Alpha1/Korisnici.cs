using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Korisnici : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly EditClass uredi = new EditClass();

        #region Methods
        public Form_Korisnici()
        {
            InitializeComponent();
            cmb_uloga.SelectedIndex = 0;
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT * FROM korisnici ORDER BY ime ASC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_korisnik.DataSource = dt;
        }
        private void Clear()
        {
            txt_id.Text = "";
            txt_ime.Text = "";
            txt_prezime.Text = "";
            txt_korIme.Text = "";
            txt_lozinka.Text = "";
            cmb_uloga.SelectedIndex = 0;
            txt_ime.Focus();
        }
        private void Form_Korisnici_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        public string NapraviMD5(string Lozinka)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Lozinka));
            byte[] rezultat = md5.Hash;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rezultat.Length; i++)
            {
                sb.Append(rezultat[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void Lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_ime.Text == "" | txt_prezime.Text == "" | txt_korIme.Text == "" | txt_lozinka.Text == "" | cmb_uloga.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.KorisnikIme = txt_ime.Text;
                uredi.KorisnikPrezime = txt_prezime.Text;
                uredi.KorisnikKorisnicko = txt_korIme.Text;
                uredi.KorisnikLozinka = NapraviMD5(txt_lozinka.Text);
                uredi.KorisnikUloga = cmb_uloga.Text;

                bool success = uredi.InsertKorisnik(uredi);
                if (success == true)
                {
                    DTUpdate();
                    Clear();
                }
                else
                {
                    MessageBox.Show(dbc.UnosError, dbc.CelijaNazivUpozorenje);
                }
            }
        }
        private void Lbl_uredi_Click(object sender, EventArgs e)
        {
            if (txt_ime.Text == "" | txt_prezime.Text == "" | txt_korIme.Text == "" | txt_lozinka.Text == "" | cmb_uloga.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.KorisnikId = int.Parse(txt_id.Text);
                uredi.KorisnikIme = txt_ime.Text;
                uredi.KorisnikPrezime = txt_prezime.Text;
                uredi.KorisnikKorisnicko = txt_korIme.Text;
                uredi.KorisnikLozinka = NapraviMD5(txt_lozinka.Text);
                uredi.KorisnikUloga = cmb_uloga.Text;

                bool success = uredi.UpdateKorsinik(uredi);
                if (success == true)
                {
                    DTUpdate();
                    Clear();
                }
                else
                {
                    MessageBox.Show(dbc.IzmjenaError, dbc.CelijaNazivUpozorenje);
                }
            }
        }
        private void Dgv_korisnik_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_korisnik.Rows[RowIndex].Cells[0].Value.ToString();
            txt_ime.Text = dgv_korisnik.Rows[RowIndex].Cells[1].Value.ToString();
            txt_prezime.Text = dgv_korisnik.Rows[RowIndex].Cells[2].Value.ToString();
            txt_korIme.Text = dgv_korisnik.Rows[RowIndex].Cells[3].Value.ToString();
            cmb_uloga.Text = dgv_korisnik.Rows[RowIndex].Cells[5].Value.ToString();
        }
        private void Txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (dgv_korisnik.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("ime LIKE '%{0}%' OR prezime LIKE '%{0}%' OR korisnickoime LIKE '%{0}%' OR uloga LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
            if (dgv_korisnik.Rows[0].Cells[0].Value == null)
                return;
        }
        private void DodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        private void SpremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_uredi.PerformClick();
        }
        private void PrazneCelije()
        {
            if (txt_ime.Text == "")
            {
                txt_ime.BackColor = Color.LightPink;
            }
            else
            {
                txt_ime.BackColor = Color.White;
            }
            if (txt_prezime.Text == "")
            {
                txt_prezime.BackColor = Color.LightPink;
            }
            else
            {
                txt_prezime.BackColor = Color.White;
            }
            if (txt_korIme.Text == "")
            {
                txt_korIme.BackColor = Color.LightPink;
            }
            else
            {
                txt_korIme.BackColor = Color.White;
            }
            if (txt_lozinka.Text == "")
            {
                txt_lozinka.BackColor = Color.LightPink;
            }
            else
            {
                txt_lozinka.BackColor = Color.White;
            }
            if (cmb_uloga.Text == "")
            {
                cmb_uloga.BackColor = Color.LightPink;
            }
            else
            {
                cmb_uloga.BackColor = Color.White;
            }
            MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
        }
        #endregion
    }
}
