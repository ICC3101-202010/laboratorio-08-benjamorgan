using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Recreacional: Local
    {
        public int Capacidad_de_clientes;
        public List<Recreacional> TodoslasRecreacionales = new List<Recreacional>();
        public Recreacional(string dueño, string horarios, int verificador, int Capacidad_de_clientes) : base(dueño, horarios, verificador)
        {
            Dueño = dueño;
            Horarios = horarios;
            Num_verificador = verificador;
            this.Capacidad_de_clientes = Capacidad_de_clientes;
        }
    }
}
