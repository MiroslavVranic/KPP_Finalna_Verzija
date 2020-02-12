using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Posiljatelji : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly EditClass uredi = new EditClass();

        public string TrazenaSifra { get; set; }
        public string IzTablice { get; set; }
        public string GdjeTrazim { get; set; }
        public Form_Posiljatelji()
        {
            InitializeComponent();
            AutoCompMjesto();
        }
        private void AutoCompMjesto()
        {
            string DbAc = "SELECT * FROM mjesta;";
            string AcPrvi = "mjesto";
            string AcDrugi = "ptt";
            AutoCompleteStringCollection AcMjesto = dbc.AutoComplete(DbAc, AcPrvi, AcDrugi);
            txt_mjesto.AutoCompleteCustomSource = AcMjesto;
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT posiljatelji.id AS ID, posiljatelji.naziv AS Pošiljatelj, mjesta.mjesto AS Mjesto FROM posiljatelji" +
                " INNER JOIN mjesta ON mjesta.id = posiljatelji.idmjesto ORDER BY naziv ASC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_posiljatelji.DataSource = dt;
        }
        private void Form_Posiljatelji_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        private void Clear()
        {
            txt_naziv.Text = "";
            txt_mjesto.Text = "";
            txt_id.Text = "";
            txt_naziv.Focus();
        }
        private void Lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_naziv.Text == "" | txt_mjesto.Text == "")
            {
                if (txt_naziv.Text == "")
                {
                    txt_naziv.BackColor = Color.LightPink;
                }
                else
                {
                    txt_naziv.BackColor = Color.White;
                }
                if (txt_mjesto.Text == "")
                {
                    txt_mjesto.BackColor = Color.LightPink;
                }
                else
                {
                    txt_mjesto.BackColor = Color.White;
                }
                MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
            }
            else
            {
                uredi.PosiljateljNaziv = txt_naziv.Text;

                TrazenaSifra = txt_mjesto.Text;
                GdjeTrazim = "mjesto+' '+ptt";
                IzTablice = "mjesta";
                uredi.PosiljateljMjesto = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                bool success = uredi.InsertPosiljatelj(uredi);

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
            if (txt_naziv.Text == "" | txt_mjesto.Text == "" | txt_id.Text == "")
            {
                if (txt_id.Text == "")
                {
                    txt_id.BackColor = Color.LightPink;
                }
                else
                {
                    txt_id.BackColor = Color.White;
                }
                if (txt_naziv.Text == "")
                {
                    txt_naziv.BackColor = Color.LightPink;
                }
                else
                {
                    txt_naziv.BackColor = Color.White;
                }
                if (txt_mjesto.Text == "")
                {
                    txt_mjesto.BackColor = Color.LightPink;
                }
                else
                {
                    txt_mjesto.BackColor = Color.White;
                }
                MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
            }
            else
            {
                uredi.PosiljateljId = int.Parse(txt_id.Text);
                uredi.PosiljateljNaziv = txt_naziv.Text;

                TrazenaSifra = txt_mjesto.Text;
                GdjeTrazim = "mjesto";
                IzTablice = "mjesta";
                uredi.PosiljateljMjesto = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                bool success = uredi.UpdatePosiljatelj(uredi);

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
        private void Dgv_posiljatelji_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_posiljatelji.Rows[RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = dgv_posiljatelji.Rows[RowIndex].Cells[1].Value.ToString();
            txt_mjesto.Text = dgv_posiljatelji.Rows[RowIndex].Cells[2].Value.ToString();
        }
        private void Txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            string Pretraga = txt_pretrazivanje.Text;
            string Dbs = "SELECT posiljatelji.id AS ID, posiljatelji.naziv AS Pošiljatelj, mjesta.mjesto AS Mjesto FROM posiljatelji" +
                " INNER JOIN mjesta ON mjesta.id = posiljatelji.idmjesto WHERE posiljatelji.naziv LIKE '%" + Pretraga + "%'";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbDataAdapter a = new OleDbDataAdapter(Dbs, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgv_posiljatelji.DataSource = dt;
        }
        private void DodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        private void SpremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_uredi.PerformClick();
        }
    }
}
