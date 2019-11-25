using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotoElectronico.Models;

namespace VotoElectronico.Models
{
    public class VotoElectronicoContext : DbContext
    {
        public VotoElectronicoContext() : base(@"Data Source=DESKTOP-9KGFDS2;
                                             Initial Catalog=VotoElectronico;
                                             User ID=sa;
                                             Password=1234;")
        {

        }
        public virtual DbSet<Candidato> Candidatos { get; set; }
        public virtual DbSet<Votante> Votantes { get; set; }


    }
}
