﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_conomic.Class
{
    [Table("tipogasto", Schema = "public")]
    public class tipoGastos
    {
        [Key]
        public int id { get; set; }
        public string nomegasto { get; set; }
        
    }
}
