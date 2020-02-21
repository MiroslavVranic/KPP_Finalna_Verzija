using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace KPP_Alpha1
{
    public partial class Form_KPP : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly KPPeditClass uredi = new KPPeditClass();
        readonly EditClass EditIt = new EditClass();
        public string KorIme { get; set; }
        public string TrazenaSifra { get; set; }
        public string TrazeniID { get; set; }
        public string IzTablice { get; set; }
        public string GdjeTrazim { get; set; }
        public string Korisnik { get; set; }
        public Form_KPP()
        {
            InitializeComponent();
            AutoCompPosiljatelj();
            AutoCompOdjel();
            KorisnikAplikacije();
        }
        private void AutoCompPosiljatelj()
        {
            string DbAc = "SELECT naziv FROM posiljatelji;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcPosiljatelj = dbc.AutoComplete(DbAc, AcPrvi);

            txt_Posiljatelj.AutoCompleteCustomSource = AcPosiljatelj;
        }
        private void AutoCompOdjel()
        {
            string DbAc = "SELECT naziv FROM odjeli;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcOdjel = dbc.AutoComplete(DbAc, AcPrvi);

            txt_Odjel.AutoCompleteCustomSource = AcOdjel;
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT knjiga.id AS ID, knjiga.datumPrimitka AS 'Datum primitka', knjiga.pismeno AS Pismeno, knjiga.brojcano AS Brojčano, " +
                "posiljatelji.naziv AS Pošiljatelj, knjiga.datum AS Datum, odjeli.naziv AS Odjel, korisnici.ime +' '+ korisnici.prezime AS Korisnik FROM (([knjiga] LEFT JOIN [posiljatelji] " +
                "ON [posiljatelji].[id] = [knjiga].[idposiljatelj]) LEFT JOIN [odjeli] ON odjeli.id = knjiga.idodjel) LEFT JOIN [korisnici] ON korisnici.id = knjiga.idkorisnik " +
                "ORDER BY knjiga.id DESC;";
            DataTable dt = dbc.Select(Dbs);
            DGV.DataSource = dt;
        }
        private void Form_KPP_Load(object sender, EventArgs e)
        {
            DTUpdate();
            txt_Korisnik.Text = Korisnik;
        }
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_Odjel.Text == "" | txt_Brojcano.Text == "" | txt_Pismeno.Text == "" | txt_Posiljatelj.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.DatumPrimitka = date_primitka.Text;
                uredi.Pismeno = txt_Pismeno.Text;
                uredi.Brojcano = txt_Brojcano.Text;

                TrazenaSifra = txt_Posiljatelj.Text;
                IzTablice = "posiljatelji";
                GdjeTrazim = "naziv";
                uredi.Idposiljatelj = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                uredi.Datum = date_datum.Text;

                TrazenaSifra = txt_Odjel.Text;
                IzTablice = "odjeli";
                GdjeTrazim = "naziv";
                uredi.Idodjel = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                TrazenaSifra = txt_Korisnik.Text;
                IzTablice = "korisnici";
                GdjeTrazim = "ime+' '+prezime";
                uredi.Idkorisnik = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                bool success = uredi.Insert(uredi);
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
        private void Clear()
        {
            txt_Posiljatelj.Text = "";
            txt_Pismeno.Text = "";
            txt_Brojcano.Text = "";
            txt_Odjel.Text = "";
            txt_Posiljatelj.BackColor = Color.White;
            txt_Pismeno.BackColor = Color.White;
            txt_Brojcano.BackColor = Color.White;
            txt_Odjel.BackColor = Color.White;
            txt_Korisnik.BackColor = Color.White;
            txt_Posiljatelj.Focus();
        }
        //PRETRAŽIVANJE - SEARCH - PRETRAGA
        private void Txt_pretraži_TextChanged(object sender, EventArgs e)
        {
            (DGV.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("Pismeno LIKE '%{0}%' OR Brojčano LIKE '%{0}%' OR Pošiljatelj LIKE '%{0}%' " +
                "OR Odjel LIKE '%{0}%' OR Korisnik LIKE '%{0}%'", 
                txt_pretrazivanje.Text.Trim());
            if (DGV.Rows[0].Cells[0].Value == null) 
                return;
        }

        private void Dgv_kpp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = DGV.Rows[RowIndex].Cells[0].Value.ToString();
            date_primitka.Text = DGV.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Pismeno.Text = DGV.Rows[RowIndex].Cells[2].Value.ToString();
            txt_Brojcano.Text = DGV.Rows[RowIndex].Cells[3].Value.ToString();
            txt_Posiljatelj.Text = DGV.Rows[RowIndex].Cells[4].Value.ToString();
            date_datum.Text = DGV.Rows[RowIndex].Cells[5].Value.ToString();
            txt_Odjel.Text = DGV.Rows[RowIndex].Cells[6].Value.ToString();
        }
        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (txt_Odjel.Text == "" | txt_Brojcano.Text == "" | txt_Pismeno.Text == "" | txt_Posiljatelj.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.KnjigaID = int.Parse(txt_id.Text);
                uredi.DatumPrimitka = date_primitka.Text;
                uredi.Pismeno = txt_Pismeno.Text;
                uredi.Brojcano = txt_Brojcano.Text;

                TrazenaSifra = txt_Posiljatelj.Text;
                IzTablice = "posiljatelji";
                GdjeTrazim = "naziv";
                uredi.Idposiljatelj = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                uredi.Datum = date_datum.Text;

                TrazenaSifra = txt_Odjel.Text;
                IzTablice = "odjeli";
                GdjeTrazim = "naziv";
                uredi.Idodjel = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                TrazenaSifra = txt_Korisnik.Text;
                IzTablice = "korisnici";
                GdjeTrazim = "ime+' '+prezime";
                uredi.Idkorisnik = EditIt.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                bool success = uredi.Update(uredi);

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
        private void Btn_search_posiljatelj_Click(object sender, EventArgs e)
        {
            Form_Mjesta form = new Form_Mjesta();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        private void Btn_search_odjel_Click(object sender, EventArgs e)
        {
            Form_Odjeli form = new Form_Odjeli();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        private void DodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        private string KorisnikAplikacije()
        {
            KorIme = EditClass.KorisnickoIme;
            IzTablice = "korisnici";
            GdjeTrazim = "korisnickoime";
            Korisnik = EditIt.UlogiraniKorisnik(KorIme, IzTablice, GdjeTrazim);

            return Korisnik;
        }
        public string UlogaUlogiranogKor(string _korIme, string IzTablice, string GdjeTrazim)
        {
            string UlogaKorisnika = "";
            string TraziKorIme = "SELECT uloga FROM " + IzTablice + " WHERE " + GdjeTrazim + " = '" + _korIme + "';";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbCommand cmd = new OleDbCommand(TraziKorIme, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UlogaKorisnika = reader.GetString(0);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return UlogaKorisnika;
        }

        private void SpremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_uredi.PerformClick();
        }
        private void PrazneCelije()
        {
            if (txt_Odjel.Text == "")
            {
                txt_Odjel.BackColor = Color.LightPink;
            }
            else
            {
                txt_Odjel.BackColor = Color.White;
            }
            if (txt_Posiljatelj.Text == "")
            {
                txt_Posiljatelj.BackColor = Color.LightPink;
            }
            else
            {
                txt_Posiljatelj.BackColor = Color.White;
            }
            if (txt_Pismeno.Text == "")
            {
                txt_Pismeno.BackColor = Color.LightPink;
            }
            else
            {
                txt_Pismeno.BackColor = Color.White;
            }
            if (txt_Brojcano.Text == "")
            {
                txt_Brojcano.BackColor = Color.LightPink;
            }
            else
            {
                txt_Brojcano.BackColor = Color.White;
            }
            MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
        }
    }
}
