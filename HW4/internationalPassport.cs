using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class internationalPassport
    {
        private long number;
        private string name;
        private DateOnly date;

        public internationalPassport() {}
        public internationalPassport(long number, string name, DateOnly date)
        {
            this.number = number;
            this.name = name;
            this.date = date;
        }

        public void setNumber(long number) { this.number = number; }
        public void setName(string name) { this.name = name; }
        public void setDate(DateOnly date) { this.date = date; }

        public long getNumber() { return number; }
        public string getName() { return name; }
        public DateOnly getDate() { return date; }

        public void show()
        {
            Console.WriteLine(number);
            Console.WriteLine(name);
            Console.WriteLine(date);
            Console.WriteLine();
        }
    }
}
