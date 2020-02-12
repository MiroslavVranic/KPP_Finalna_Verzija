﻿using System;
using System.Data.OleDb;


namespace KPP_Alpha1
{
    class EditClass
    {
        readonly DbClass dbc = new DbClass();
        //Get i seteri
        //Get, seteri za mjesto
        public int IdMjesto { get; set; }
        public string Ptt { get; set; }
        public string Mjesto { get; set; }
        public int IdZupaija { get; set; }
        public int SecKey { get; set; }
        //Get, seteri za odjel
        public string NazivOdjela { get; set; }
        public int OdjelId { get; set; }
        //Get, seteri za korisnika
        public int KorisnikId { get; set; }
        public string KorisnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
        public string KorisnikKorisnicko { get; set; }
        public string KorisnikLozinka { get; set; }
        public string KorisnikUloga { get; set; }
        //Get. seteri za Posiljatelja
        public int PosiljateljId { get; set; }
        public string PosiljateljNaziv { get; set; }
        public int PosiljateljMjesto { get; set; }
        public int TrazenaSifra { get; set; }
        //Cuvanje korisničkog imena ulogiranog korisnika
        public static string KorisnickoIme { get; set; }
        //          UNOS I IZMJENA MJESTA
        public bool UpdateMjesto(EditClass e)
        {
            bool isSuccess = false;
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                string Uredi = "UPDATE mjesta SET ID=@ID, ptt=@ptt, mjesto=@mjesto," +
                    "idZupanije=@idZupanije, secKey=@secKey WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.IdMjesto);
                cmd.Parameters.AddWithValue("@ptt", e.Ptt);
                cmd.Parameters.AddWithValue("@mjesto", e.Mjesto);
                cmd.Parameters.AddWithValue("@idZupanije", e.IdZupaija);
                cmd.Parameters.AddWithValue("@secKey", e.SecKey);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool InsertMjesto(EditClass e)
        {
            bool isSuccess = false;
            string Unos = "INSERT INTO mjesta(ptt, mjesto, idZupanije, secKey) VALUES(@ptt, @mjesto, @idZupanije, @secKey)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@ptt", e.Ptt);
                cmd.Parameters.AddWithValue("@mjesto", e.Mjesto);
                cmd.Parameters.AddWithValue("@idZupanije", e.IdZupaija);
                cmd.Parameters.AddWithValue("@secKey", e.SecKey);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //          UNOS I IZMJENA ODJELA
        public bool InsertOdjel(EditClass e)
        {
            bool isSuccess = false;
            string Unos = "INSERT INTO odjeli(Naziv) VALUES(@Naziv)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@Naziv", e.NazivOdjela);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool UpdateOdjel(EditClass e)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE odjeli SET ID=@ID, Naziv=@Naziv WHERE ID=@ID";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@ID", e.OdjelId);
                cmd.Parameters.AddWithValue("@Naziv", e.NazivOdjela);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //          UNOS I IZMJENA KORISNIKA
        public bool InsertKorisnik(EditClass e)
        {
            bool isSuccess = false;
            string Unos = "INSERT INTO korisnici(Ime, Prezime, KorisnickoIme, Lozinka, Uloga) VALUES(@Ime, @Prezime, @KorisnickoIme, @Lozinka, @Uloga)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@Ime", e.KorisnikIme);
                cmd.Parameters.AddWithValue("@Prezime", e.KorisnikPrezime);
                cmd.Parameters.AddWithValue("@KorisnickoIme", e.KorisnikKorisnicko);
                cmd.Parameters.AddWithValue("@Lozinka", e.KorisnikLozinka);
                cmd.Parameters.AddWithValue("@Uloga", e.KorisnikUloga);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool UpdateKorsinik(EditClass e)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE korisnici SET id=@id, ime=@ime, prezime=@prezime, KorisnickoIme=@KorisnickoIme, Lozinka=@Lozinka, Uloga=@Uloga WHERE id=@id";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.KorisnikId);
                cmd.Parameters.AddWithValue("@ime", e.KorisnikIme);
                cmd.Parameters.AddWithValue("@prezime", e.KorisnikPrezime);
                cmd.Parameters.AddWithValue("@KorisnickoIme", e.KorisnikKorisnicko);
                cmd.Parameters.AddWithValue("@Lozinka", e.KorisnikLozinka);
                cmd.Parameters.AddWithValue("@Uloga", e.KorisnikUloga);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //          UNOS I IZMJENA POSILJATELJA
        public bool InsertPosiljatelj(EditClass e)
        {
            bool isSuccess = false;
            string Unos = "INSERT INTO posiljatelji(naziv, idMjesto) VALUES(@Naziv, @idMjesto)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@naziv", e.PosiljateljNaziv);
                cmd.Parameters.AddWithValue("@idMjesto", e.PosiljateljMjesto);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool UpdatePosiljatelj(EditClass e)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE posiljatelji SET id=@id, naziv=@naziv, idMjesto=@idMjesto WHERE id=@id";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.PosiljateljId);
                cmd.Parameters.AddWithValue("@naziv", e.PosiljateljNaziv);
                cmd.Parameters.AddWithValue("@idMjesto", e.PosiljateljMjesto);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public int Sifra(string _sifra, string IzTablice, string GdjeTrazim)
        {
            string Trazi = "SELECT id FROM " + IzTablice + " WHERE " + GdjeTrazim + " = '" + _sifra + "';";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(Trazi, conn);
                Int32 TrazenaSifra = (Int32)cmd.ExecuteScalar();
                return TrazenaSifra;
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return TrazenaSifra;
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

        public bool UpdateLozinka(EditClass e)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE korisnici SET KorisnickoIme=@KorisnickoIme, Lozinka =@Lozinka WHERE KorisnickoIme=@KorisnickoIme";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@KorisnickoIme", e.KorisnikKorisnicko);
                cmd.Parameters.AddWithValue("@Lozinka", e.KorisnikLozinka);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
