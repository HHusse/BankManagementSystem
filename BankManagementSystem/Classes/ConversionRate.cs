using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Classes
{
    class ConversionRate
    {
        public static float Rate(string from, string to)
        {
            if (from == to)
                return 1;
            if (from == "EUR" && to == "RON")
                return Convert.ToSingle("4.93");
            if (from == "EUR" && to == "USD")
                return Convert.ToSingle("1.04");
            if (from == "RON" && to == "EUR")
                return Convert.ToSingle("0.20");
            if(from == "RON" && to == "USD")
                return Convert.ToSingle("0.21");
            if (from == "USD" && to == "EUR")
                return Convert.ToSingle("0.96");
            else
                return Convert.ToSingle("4.73");

        }
    }
}
