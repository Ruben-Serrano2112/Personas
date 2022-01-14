using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class AbrirVistaServicio
    {
        public void AbrirVentanaNuevaPersona()
        {
            NuevaPersona nueva = new NuevaPersona();
            nueva.Show();
        }
    }
}
