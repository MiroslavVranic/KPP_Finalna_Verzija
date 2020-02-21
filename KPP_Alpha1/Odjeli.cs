using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Odjeli : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly EditClass uredi = new EditClass();

        public Form_Odjeli()
        {
            InitializeComponent();
        }

        private void Form_Odjeli_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT * FROM odjeli ORDER BY naziv ASC;";
            DataTable dt = dbc.Select(Dbs);
            DGV.DataSource = dt;
        }
        private void Clear()
        {
            txt_naziv.Text = "";
            txt_id.Text = "";
        }
        private void Lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_naziv.Text == "")
            {
                txt_naziv.BackColor = Color.LightPink;
                MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
            }
            else
            {
                txt_naziv.BackColor = Color.White;
                uredi.NazivOdjela = txt_naziv.Text.Trim();

                bool success = uredi.InsertOdjel(uredi);

                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_naziv.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.UnosError, dbc.CelijaNazivUpozorenje);
                }
            }
        }

        private void Lbl_uredi_Click(object sender, EventArgs e)
        {
            if (txt_naziv.Text == "")
            {
                txt_naziv.BackColor = Color.LightPink;
                MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);
            }
            else
            {
                txt_naziv.BackColor = Color.White;
                uredi.OdjelId = int.Parse(txt_id.Text.Trim());
                uredi.NazivOdjela = txt_naziv.Text.Trim();

                bool success = uredi.UpdateOdjel(uredi);

                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_naziv.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.IzmjenaError, dbc.CelijaNazivUpozorenje);
                }
            }
        }
        //ODABIR TIPKOVNICOM MIŠA NEKOG OD REDOVA ZA UREĐIVANJE
        private void Dgv_odjel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = DGV.Rows[RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = DGV.Rows[RowIndex].Cells[1].Value.ToString();
        }
        //PRETRAŽIVANJE - SEARCH - PRETRAGA
        private void Txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (DGV.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("naziv LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
            if (DGV.Rows[0].Cells[0].Value == null) 
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
    }
}
