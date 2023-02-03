using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_conomic.Class
{
    [Table ("gasto", Schema = "public")]
    public class DbnovoGasto
    {
        [Key]
        public int id { get; set; }
        public int usuarioid { get; set; }
        public int tipoid { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set;}
        public string descricao { get; set; }
        public DateTime datagasto { get; set; }
        
        
    }
}
