using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Army_App
{
    public class Rank
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Info { get { return ShortInfo(); } }
        public string ShortInfo()
        {
            return $"Rank  {Name}";
        }
    }
}
