using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_conomic.Class
{
    public class dtoUsuario
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nomecompleto { get; set; }
        public string telefone { get; set; }
        public decimal rendamensal { get; set; }

    }
}
