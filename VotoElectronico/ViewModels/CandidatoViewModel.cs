using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronico.ViewModels
{
    public class CandidatoViewModel
    {
        [System.ComponentModel.DisplayName("Cargo")]
        public string Cargo { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public String Nombre { get; set; }
        public CandidatoViewModel(string cargo, string nombre)
        {
            this.Cargo = cargo;
            this.Nombre = nombre;
        }
    }
}
