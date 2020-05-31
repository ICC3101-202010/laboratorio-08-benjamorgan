using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Restaurant: Local
    {
        public bool Mesas_exclusivas;
        public List<Restaurant> TodoslosRestaurants = new List<Restaurant>();


        public Restaurant(string dueño, string horarios, int verificador, bool Mesas_exclusivas) : base(dueño, horarios, verificador)
        {
            Dueño = dueño;
            Horarios = horarios;
            Num_verificador = verificador;
            this.Mesas_exclusivas = Mesas_exclusivas;

        }
    }
}
