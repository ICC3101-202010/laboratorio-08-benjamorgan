using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Local
    {
        public string Dueño { get; set; }
        public string Horarios { get; set; }
        public int Num_verificador { get; set; }


        public Local(string dueño,string horario, int verificador)
        {
            this.Dueño = dueño;
            this.Horarios = horario;
            this.Num_verificador = verificador;
        }

    }
}
