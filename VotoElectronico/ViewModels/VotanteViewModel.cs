using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoElectronico.ViewModels
{
    public class VotanteViewModel
    {
        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre { get; set; }
        [System.ComponentModel.DisplayName("Numero de Cuenta")]
        public int NumeroCuenta { get; set; }
        public VotanteViewModel(string nombre, int numeroCuenta)
        {
            this.Nombre = nombre;
            this.NumeroCuenta = numeroCuenta;
        }
    }
}
