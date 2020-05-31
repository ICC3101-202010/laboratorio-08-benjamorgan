using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Cine:Local
    {
        public int Num_salas;
        public List<Cine> TodoslosCines = new List<Cine>();
        public Cine(string dueño, string horarios, int verificador, int Num_salas) : base(dueño, horarios, verificador)
        {
            Dueño = dueño;
            Horarios = horarios;
            Num_verificador = verificador;
            this.Num_salas = Num_salas;
        }
    }
}
