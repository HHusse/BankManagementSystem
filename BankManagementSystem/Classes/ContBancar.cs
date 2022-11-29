using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankManagementSystem
{
    class ContBancar : Client
    {
        private string nrcont;
        private DateTime dataDeschiderii;
        private string moneda;
        private float sold;

        public ContBancar(string nume, string prenume, long cnp, DateTime dataNasterii, string user, int PIN, string cont, DateTime dataDeschiderii, string moned, long sold) : base(nume, prenume, cnp, dataNasterii, user, PIN)
        {
            this.nrcont = cont;
            this.dataDeschiderii = dataDeschiderii;
            this.moneda = moned;
            this.sold = sold;
        }

        public void adaugareContBancar(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={this.cnp} and `nrCont` like '{this.nrcont.Substring(0, 3)}%'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows == false)
            {
                rdr.Close();
                cmd = new MySqlCommand($"INSERT INTO conturibancare VALUES ({this.cnp},'{this.nrcont}','{this.dataDeschiderii.ToString("dd/MM/yyyy")}'," +
                    $"'{this.moneda}',{this.sold});", conn);
                cmd.ExecuteNonQuery();
            }
            else
                MessageBox.Show($"Aveti deja un cont in {this.nrcont.Substring(0, 3)}");

        }

        public static void InterogareSold(long cnp, string nrCont, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT sold FROM `conturibancare` WHERE cnp={cnp} and `nrCont`='{nrCont}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            MessageBox.Show($"Soldul contului dumneavoastra {nrCont} este de \n \n {rdr["sold"].ToString()} {nrCont.Substring(0, 3)}");
        }

        public static void DepunereNumerar(float suma, string nrCont, long cnp, MySqlConnection conn)
        {

            MySqlCommand cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`+{suma} WHERE `cnp`={cnp} and `nrCont`='{nrCont}' ;", conn);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{nrCont}','{"Depunere"}',{suma},'{DateTime.Now.ToString("dd/MM/yyyy")}','{nrCont.Substring(0,3)}');", conn);
            cmd.ExecuteNonQuery();

        }

        public static void RetragereNumerar(float suma, string nrCont, long cnp, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE  `nrCont`='{nrCont}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (float.Parse(rdr["sold"].ToString()) >= suma)
            {
                rdr.Close();
                cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`-{suma} WHERE `cnp`={cnp} and `nrCont`='{nrCont}' ;", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{nrCont}','{"Retragere"}',{suma},'{DateTime.Now.ToString("dd/MM/yyyy")}','{nrCont.Substring(0, 3)}');", conn);
                cmd.ExecuteNonQuery();
            }

            else
                MessageBox.Show("Fonduri insficiente!");



        }

        public static void TransferBancar(float suma, string from, string to, long cnp, MySqlConnection conn)
        {
            MySqlCommand cmdv = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE  `nrCont`='{from}'", conn);
            MySqlDataReader rdr = cmdv.ExecuteReader();
            rdr.Read();

            if (float.Parse(rdr["sold"].ToString()) >= suma)
            {
                rdr.Close();
                cmdv = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE  `nrCont`='{to}'", conn);
                rdr = cmdv.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    rdr.Read();
                    long cnpDestinatar = Convert.ToInt64(rdr["cnp"].ToString());
                    rdr.Close();
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`-{suma} WHERE `cnp`={cnp} and `nrCont`='{from}' ;", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`+{suma} WHERE `cnp`={cnpDestinatar} and `nrCont`='{to}' ;", conn);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`,`to`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{from}','{to}','{"Transfer"}',{suma},'{DateTime.Now.ToString("dd/MM/yyyy")}','{from.Substring(0, 3)}');", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show($"Contul la catre doriti sa tranfera-ti suma de {suma} {from.Substring(0, 3)} nu exista la banca noastra!");
                }
            }
            else
            {
                MessageBox.Show("Fonduri insficiente!");
            }
        }
        public static void LichidareCont(string nrCont, long cnp, MySqlConnection conn)
        {

            MySqlCommand cmd = new MySqlCommand($"DELETE FROM `conturibancare` WHERE `cnp`={cnp} and `nrCont`='{nrCont}';", conn);
            cmd.ExecuteNonQuery();

        }

        public static void TransferConturi(float suma, string from, string to, long cnp, MySqlConnection conn)
        {
            MySqlCommand cmdv = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={cnp} and `nrCont`='{from}'", conn);
            MySqlDataReader rdr = cmdv.ExecuteReader();
            rdr.Read();

            if (float.Parse(rdr["sold"].ToString()) >= suma)
            {
                rdr.Close();
                cmdv = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={cnp} and `nrCont`='{to}'", conn);
                rdr = cmdv.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    rdr.Read();
                    rdr.Close();
                    float a = Classes.ConversionRate.Rate(from.Substring(0, 3), to.Substring(0, 3));
                    float sumaTrimisa = suma * Classes.ConversionRate.Rate(from.Substring(0, 3), to.Substring(0, 3));
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`-{suma} WHERE `cnp`={cnp} and `nrCont`='{from}' ;", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand($"UPDATE `conturibancare` SET `sold`=`sold`+{sumaTrimisa} WHERE `cnp`={cnp} and `nrCont`='{to}' ;", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand($"INSERT INTO `tranzactii`(`from`, `to`, `tiptranzactie`, `suma`, `data`, `moneda`) VALUES ('{from}','{to}','{"Transfer Conturi Personale"}',{suma},'{DateTime.Now.ToString("dd/MM/yyyy")}','{from.Substring(0, 3)+"->"+to.Substring(0,3)}');", conn);
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Fonduri insficiente!");
            }
        }
    }
}
