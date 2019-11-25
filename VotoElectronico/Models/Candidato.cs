using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoElectronico.Models
{
    public class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }
        public string CargoCandidato { get; set; }
        public string NombreCandidato { get; set; }
        //public int IdVotante { get; set; }
        //[ForeignKey("IdVotante")]
        //public virtual Votante Votante { get; set; }
    }
}
