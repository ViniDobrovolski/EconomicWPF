using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_conomic.Class
{
    public class dtoGastoComparar
    {
        public int id { get; set; }
        
        public string nome { get; set; }
        public decimal valor { get; set; }
        public DateTime datagasto { get; set; }
    }
}
