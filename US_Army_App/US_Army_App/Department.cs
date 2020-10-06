using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Army_App
{
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        public int NumberOfBatallions { get; set; }
        public string Info { get { return ShortInfo(); } }
        public string ShortInfo()
        {
            return $"{Name}  {NumberOfBatallions} batallions";
        }
    }
}
