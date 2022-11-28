using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BankManagementSystem
{
    class Client
    {
        
        private string nume;
        private string prenume;
        protected long cnp;
        private DateTime dataNasterii;

        private string user;
        private int PIN;

        public Client( string nume, string prenume, long cnp, DateTime dataNasterii, string user, int PIN)
        {
            
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.dataNasterii = dataNasterii;
            this.user = user;
            this.PIN = PIN;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public long Cnp { get => cnp; set => cnp = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }


        public void adaugare(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO Clientii VALUES ('{this.nume}','{this.prenume}',{this.cnp},'{this.dataNasterii.ToString("dd/MM/yyyy") }');",conn);
            MySqlCommand cmdL = new MySqlCommand($"INSERT INTO loginclient VALUES ('{this.user}',{this.PIN},{this.cnp});",conn);
            cmd.ExecuteNonQuery();
            cmdL.ExecuteNonQuery();

        }
    }
}
