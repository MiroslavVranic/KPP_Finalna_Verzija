using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    class DbClass
    {
        // String za konekciju na bazu
        public string conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KPP.accdb; Persist Security Info = false";

        #region Stringovi za razne poruke korisniku
        public string PraznaCelija = "Ćelije ne smiju biti prazne!";

        public string CelijaNazivUpozorenje = "Upozorenje";

        public string CelijaNazivObavjest = "Obavijest aplikacije";

        public string IzmjenaError = "Izmjena nije izvršena!";

        public string UnosError = "Unos nije napravljen!";

        public string IdError = "ID stavke nije prondađen!";

        public string ExError = "Dogodila se greška:\n";
        #endregion

        public DataTable Select(string Dbs)
        {
            OleDbConnection conn = new OleDbConnection(conn_string);
            OleDbCommand cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter a = new OleDbDataAdapter(cmd);
                conn.Open();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi, string AcDrugi)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(conn_string);
            OleDbCommand cmd = new OleDbCommand(DbAc, conn);
            conn.Open();
            try
            {
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[AcPrvi].ToString();
                    string drugiString = myReader[AcDrugi].ToString();
                    coll.Add(prviString + " " + drugiString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExError + ex.Message, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return coll;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(conn_string);
            OleDbCommand cmd = new OleDbCommand(DbAc, conn);
            conn.Open();
            try
            {
                OleDbDataReader myReader = cmd.ExecuteReader();
                int jedan = myReader.GetOrdinal(AcPrvi);
                while (myReader.Read())
                {
                    string prviString = myReader.GetString(jedan);
                    coll.Add(prviString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExError + ex, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return coll;
        }
    }
}
