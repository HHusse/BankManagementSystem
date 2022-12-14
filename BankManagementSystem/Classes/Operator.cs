using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Classes
{
    class Operator
    {
        private string nume;
        private string prenume;
        private long cnp;
        private DateTime dataNasterii;

        private string user;
        private string password;

        public Operator(string nume, string prenume, long cnp, DateTime dataNasterii, string user, string password)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.dataNasterii = dataNasterii;
            this.user = user;
            this.password = password;
        }

        public void adaugare(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO operatorii VALUES ('{this.nume}','{this.prenume}',{this.cnp},'{this.dataNasterii.ToString("MM/dd/yyyy") }'" +
                $",'{this.user}','{this.password}',{"false"});", conn);
            cmd.ExecuteNonQuery();

        }

        public static DataTable afisareData(string cont, MySqlConnection conn)
        {
            DataTable set = new DataTable();

            string co = $"SELECT `from`As 'FROM', `to`As 'TO', `tiptranzactie`AS 'TIP', `suma`AS 'SUMA', `moneda`as 'VALUTA', `data` AS 'DATA' FROM `tranzactii` " +
                $"WHERE `from` like '{cont}%' or `to` like '{cont}%'";
            MySqlDataAdapter a = new MySqlDataAdapter(co, conn);
            a.Fill(set);

            return set;
        }

        public static float SumeTotale()
        {
            float suma = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare`", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString().Contains("RON") == true)
                {
                    suma = suma + Convert.ToSingle(rdr[4].ToString());
                }
                else if (rdr[1].ToString().Contains("EUR") == true)
                {
                    suma = suma + (Convert.ToSingle(rdr[4].ToString()) * ConversionRate.Rate("EUR", "RON"));
                }
                else
                    suma = suma + (Convert.ToSingle(rdr[4].ToString()) * ConversionRate.Rate("USD", "RON"));
            }
            rdr.Close();
            return suma;
        }

        public static float SumeRON()
        {
            float suma = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare`", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString().Contains("RON") == true)
                {
                    suma = suma + Convert.ToSingle(rdr[4].ToString());
                }

            }
            rdr.Close();
            return suma;
        }
        public static float SumeEUR()
        {
            float suma = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare`", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString().Contains("EUR") == true)
                {
                    suma = suma + Convert.ToSingle(rdr[4].ToString());
                }

            }
            rdr.Close();
            return suma;
        }
        public static float SumeUSD()
        {
            float suma = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare`", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString().Contains("USD") == true)
                {
                    suma = suma + Convert.ToSingle(rdr[4].ToString());
                }

            }
            rdr.Close();
            return suma;
        }

        public static int ConturiTotale()
        {
            int ct = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare`", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
            }
            return ct;
        }
        public static int ConturiRON()
        {
            int ct = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` Where `nrCont` like 'RON%'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
            }
            return ct;
        }

        public static int ConturiEUR()
        {
            int ct = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` Where `nrCont` like 'EUR%'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
            }
            return ct;
        }

        public static int ConturiUSD()
        {
            int ct = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` Where `nrCont` like 'USD%'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
            }
            return ct;
        }
        public static DataTable TranzactiiZile(string data)
        {
            DataTable set = new DataTable();

            string co = $"SELECT `from`As 'FROM', `to`As 'TO', `tiptranzactie`AS 'TIP', `suma`AS 'SUMA', `moneda`as 'VALUTA' FROM `tranzactii` WHERE `data`='{data}' ";
            MySqlDataAdapter a = new MySqlDataAdapter(co, ConnectionDB.conectiune());
            a.Fill(set);

            return set;
        }

        public static int NumarTranzactiiZile(string data)
        {
            int ct = 0;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `tranzactii` WHERE `data`='{data}' ", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
            }
            return ct;
        }

        public static void DepunereNumerar(float suma, string nrCont, MySqlConnection conn)
        {
            float sumaFinala = suma - (suma * (float)0.01);
            MySqlCommand cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`+{sumaFinala} WHERE `nrCont`='{nrCont}' ;", conn);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{nrCont}','{"Depunere"}',{sumaFinala},'{DateTime.Now.ToString("dd/MM/yyyy")}','{nrCont.Substring(0, 3)}');", conn);
            cmd.ExecuteNonQuery();
        }

        public static bool RetragereNumerar(float suma, string nrCont, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE  `nrCont`='{nrCont}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (float.Parse(rdr["sold"].ToString()) >= suma)
            {
                rdr.Close();
                cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`-{suma} WHERE `nrCont`='{nrCont}' ;", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{nrCont}','{"Retragere"}',{suma},'{DateTime.Now.ToString("dd/MM/yyyy")}','{nrCont.Substring(0, 3)}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }

            else 
            {
                MessageBox.Show("Fonduri insficiente!");
                return false;
            }
                

        }

        public static float interogareSold(string nrCont)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `nrCont`='{nrCont}'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            float sold = Convert.ToSingle(rdr[4].ToString());
            return sold;

        }

    }
}
