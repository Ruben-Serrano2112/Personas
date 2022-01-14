using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand AbrirVentanaCommand { get; }
        public AbrirVistaServicio AbrirServicio { get; }
        public MainWindowVM()
        {
            AbrirVentanaCommand = new RelayCommand(AbrirVentana);
            AbrirServicio = new AbrirVistaServicio();
        }
        private void AbrirVentana()
        {
            AbrirServicio.AbrirVentanaNuevaPersona();
        }
    }
}
