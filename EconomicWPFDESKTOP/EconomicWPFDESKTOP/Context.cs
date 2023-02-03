using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using E_conomic.Class;

namespace E_conomic
{
    public class Context : DbContext
    {
        public Context() : base("eConomic") { }

        public DbSet<DbUsuarios> usuario { get; set; }
        public DbSet<tipoGastos> tipogasto { get; set; }

        public DbSet<DbnovoGasto> gasto { get; set; }

    }
}
