using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoElectronico.Models
{
    public class Votante
    { 
        [Key]
        public int IdVotante { get; set; }
        public string NombreVotante { get; set; }
        public int NumeroCuenta { get; set; }
        //public ICollection<Candidato> Candidatos { get; set; }
    }
}
