using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Classes
{
    class Operator
    {
        private int codOperator;
        private string nume;
        private string prenume;
        private int cnp;
        private DateTime dataNasterii;

        private string user;
        private string password;

        public Operator(int codOperator, string nume, string prenume, int cnp, DateTime dataNasterii, string user, string password)
        {
            this.codOperator = codOperator;
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.dataNasterii = dataNasterii;
            this.user = user;
            this.password = password;
        }

        public int CodOperator { get => codOperator; set => codOperator = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Cnp { get => cnp; set => cnp = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }



    }
}
