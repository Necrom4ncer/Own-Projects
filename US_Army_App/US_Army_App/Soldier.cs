using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Army_App
{
    public  class Soldier
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Info { get { return ShortInfo(); } }
        public string ShortInfo()
        {
            return $"{FirstName}  {LastName}  {Age}   y.o \n";
        }
    }
}
