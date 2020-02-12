using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form_Login : Form
    {
        readonly DbClass dbc = new DbClass();
        readonly Form_Korisnici Kor = new Form_Korisnici();
        readonly EditClass Uredi = new EditClass();

        public Form_Login()
        {
            InitializeComponent();
        }
        private void Btn_prijava_Click_1(object sender, EventArgs e)
        {
            string ole = "SELECT * FROM korisnici WHERE KorisnickoIme='" + txt_korIme.Text + "'and Lozinka='" + Kor.NapraviMD5(TXTlozinka.Text) + "'";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(ole, conn);
                conn.Open();
                OleDbDataReader korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    EditClass.KorisnickoIme = txt_korIme.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušaj ponovno!", dbc.CelijaNazivUpozorenje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbc.ExError + ex, dbc.CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_izlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }

        private void BTN_lozinka_Click(object sender, EventArgs e)
        {
            if (txt_korIme.Text == "" | TXTlozinka.Text == "")
            {
                MessageBox.Show("Unesite svoje trenutno korisničko ime i lozinku.", dbc.UnosError);
            }
            else
            {
                string ole = "SELECT * FROM korisnici WHERE KorisnickoIme='" + txt_korIme.Text + "'and Lozinka='" + Kor.NapraviMD5(TXTlozinka.Text) + "'";
                OleDbConnection conn = new OleDbConnection(dbc.conn_string);
                OleDbCommand cmd = new OleDbCommand(ole, conn);
                conn.Open();
                OleDbDataReader korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    lbl_lozinka.Visible = false;
                    LBLnovaLozinka.Visible = true;
                    TXTlozinka.Text = "";
                    TXTlozinka.Focus();
                    LBLponoviLozinku.Visible = true;
                    TXTponoviLozinku.Visible = true;
                    BTN_lozinka.Visible = false;
                    BTNspremiLozinku.Visible = true;
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušajte ponovno!", dbc.CelijaNazivUpozorenje);
                }
            }
        }

        private void BTNspremiLozinku_Click(object sender, EventArgs e)
        {
            if (txt_korIme.Text != "" | TXTlozinka.Text != "" | TXTponoviLozinku.Text != "")
            {
                if (TXTlozinka.Text == TXTponoviLozinku.Text)
                {
                    Uredi.KorisnikKorisnicko = txt_korIme.Text;
                    Uredi.KorisnikLozinka = Kor.NapraviMD5(TXTlozinka.Text);

                    bool success = Uredi.UpdateLozinka(Uredi);
                    if (success == true)
                    {
                        MessageBox.Show("Lozinka je promijenjena.\nPrijavite se s novom lozinkom!", dbc.CelijaNazivObavjest);
                        lbl_lozinka.Visible = true;
                        LBLnovaLozinka.Visible = false;
                        TXTlozinka.Text = "";
                        TXTlozinka.Focus();
                        LBLponoviLozinku.Visible = false;
                        TXTponoviLozinku.Visible = false;
                        BTN_lozinka.Visible = true;
                        BTNspremiLozinku.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Lozinka nije promijenjena.", dbc.IzmjenaError);
                    }
                }
                else
                {
                    MessageBox.Show("Lozinke se ne podudaraju!", dbc.CelijaNazivUpozorenje);
                }
            }
        }
        public string UlogiraniKorisnik(string _korIme, string IzTablice, string GdjeTrazim)
        {
            string TrazeniKorisnik = "";
            string TraziKorIme = "SELECT ime, prezime FROM " + IzTablice + " WHERE " + GdjeTrazim + " = '" + _korIme + "';";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbCommand cmd = new OleDbCommand(TraziKorIme, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ImeKor = reader.GetString(0);
                    string PrezimeKor = reader.GetString(1);
                    TrazeniKorisnik = ImeKor + " " + PrezimeKor;
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return TrazeniKorisnik;
        }
    }
}
