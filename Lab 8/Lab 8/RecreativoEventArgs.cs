using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class RecreativoEventArgs : EventArgs
    {
        public string Dueño { get; set; }
        public string Horario { get; set; }
        public int Verificador { get; set; }
        public int CapacidadClientes { get; set; }
    }
}
