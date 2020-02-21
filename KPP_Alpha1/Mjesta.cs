using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Mjesta : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly EditClass uredi = new EditClass();

        public int IdZupaija { get; set; }
        public string TrazenaSifra { get; set; }
        public string IzTablice { get; set; }
        public string GdjeTrazim { get; set; }

        public Form_Mjesta()
        {
            InitializeComponent();
            AutoCompZupanija();
        }
        private void AutoCompZupanija()
        {
            string DbAc = "SELECT * FROM zupanije;";
            string AcPrvi = "zupanija";
            AutoCompleteStringCollection AcZup = dbc.AutoComplete(DbAc, AcPrvi);
            txt_Zupanija.AutoCompleteCustomSource = AcZup;
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT mjesta.id AS ID, mjesta.ptt AS 'Poštanski broj', mjesta.mjesto AS Mjesto, zupanije.zupanija AS Županija, mjesta.secKey AS 'Poštanski ured'" +
                            " FROM mjesta INNER JOIN zupanije ON mjesta.idZupanije = zupanije.id ORDER BY ptt ASC, mjesta.id ASC;";
            DataTable dt = dbc.Select(Dbs);
            DGV_Mjesta.DataSource = dt;
        }
        private void Form_Mjesta_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        private void Btn_Uredi_Click(object sender, EventArgs e)
        {
            if (txt_Mjesto.Text == "" | txt_Ptt.Text == "" | txt_Zupanija.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.IdMjesto = int.Parse(txt_id.Text);
                uredi.Ptt = txt_Ptt.Text;
                uredi.Mjesto = txt_Mjesto.Text;

                TrazenaSifra = txt_Zupanija.Text;
                GdjeTrazim = "zupanija";
                IzTablice = "zupanije";
                uredi.IdZupaija = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                TrazenaSifra = txt_secKey.Text;
                GdjeTrazim = "mjesto";
                IzTablice = "mjesta";
                uredi.SecKey = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);
                bool success = uredi.UpdateMjesto(uredi);
                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_Ptt.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.IzmjenaError, dbc.CelijaNazivUpozorenje);
                }
            }
        }
        private void Dgv_mjesta_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = DGV_Mjesta.Rows[RowIndex].Cells[0].Value.ToString();
            txt_Ptt.Text = DGV_Mjesta.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Mjesto.Text = DGV_Mjesta.Rows[RowIndex].Cells[2].Value.ToString();
            txt_Zupanija.Text = DGV_Mjesta.Rows[RowIndex].Cells[3].Value.ToString();
            txt_secKey.Text = DGV_Mjesta.Rows[RowIndex].Cells[4].Value.ToString();
        }
        private void Txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (DGV_Mjesta.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("['poštanski broj'] LIKE '%{0}%' OR mjesto LIKE '%{0}%' OR županija LIKE '%{0}%'",
                txt_pretrazivanje.Text.Trim());
            if (DGV_Mjesta.Rows[0].Cells[0].Value == null)
                return;
        }
        private void Clear()
        {
            txt_id.Text = "";
            txt_Ptt.Text = "";
            txt_Mjesto.Text = "";
            txt_Zupanija.Text = "";
            txt_secKey.Text = "";
            txt_Mjesto.Focus();
        }
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_Mjesto.Text == "" | txt_Ptt.Text == "" | txt_Zupanija.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.Mjesto = txt_Mjesto.Text.Trim();
                uredi.Ptt = txt_Ptt.Text.Trim();

                TrazenaSifra = txt_Zupanija.Text.Trim();
                GdjeTrazim = "zupanija";
                IzTablice = "zupanije";
                uredi.IdZupaija = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);

                TrazenaSifra = txt_secKey.Text.Trim();
                GdjeTrazim = "mjesto";
                IzTablice = "mjesta";
                uredi.SecKey = uredi.Sifra(TrazenaSifra, IzTablice, GdjeTrazim);
                if (IdZupaija < 1)
                {
                    MessageBox.Show(dbc.IdError, dbc.CelijaNazivUpozorenje);
                }
                else
                {
                    bool success = uredi.InsertMjesto(uredi);
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
        }
        private void DodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        private void SpremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Uredi.PerformClick();
        }
        private void PrazneCelije()
        {
            if (txt_Mjesto.Text == "")
            {
                txt_Mjesto.BackColor = Color.LightPink;
            }
            else
            {
                txt_Mjesto.BackColor = Color.White;
            }
            if (txt_Ptt.Text == "")
            {
                txt_Ptt.BackColor = Color.LightPink;
            }
            else
            {
                txt_Ptt.BackColor = Color.White;
            }
            if (txt_Zupanija.Text == "")
            {
                txt_Zupanija.BackColor = Color.LightPink;
            }
            else
            {
                txt_Zupanija.BackColor = Color.White;
            }
            MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
        }
    }
}
