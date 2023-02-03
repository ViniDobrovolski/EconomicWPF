using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_conomic.Class
{
    [Table("usuario", Schema = "public")]
    public class DbUsuarios
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nomecompleto  { get; set; }
        public string telefone { get; set; }
        public decimal rendamensal { get; set; }
        

    }
}
