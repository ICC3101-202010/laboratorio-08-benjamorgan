using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Tiendas : Local
    {

        public string categorias;
        public List<Tiendas> TodoslasTiendas = new List<Tiendas>();
        public Tiendas(string dueño,string horarios,int verificador, string categorias) :base(dueño,horarios,verificador)
        {
            Dueño = dueño;
            Horarios = horarios;
            Num_verificador = verificador;
            this.categorias = categorias;
        }
    }
}
