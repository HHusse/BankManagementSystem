using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public long Cnp { get => cnp; set => cnp = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        public void adaugare(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO operatorii VALUES ('{this.nume}','{this.prenume}',{this.cnp},'{this.dataNasterii.ToString("MM/dd/yyyy") }'" +
                $",'{this.user}','{this.password}',{"false"});", conn);
            cmd.ExecuteNonQuery();
            
        }

    }
}
