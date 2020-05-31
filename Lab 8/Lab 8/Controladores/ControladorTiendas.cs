using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.Controladores
{
    class ControladorTiendas
    {
        Form1 appform;
        List<Tiendas> TodoslasTiendas = new List<Tiendas>();
        Tiendas a = new Tiendas("a","a",0,"a");
        public ControladorTiendas(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddTienda += OnAddRest;
        }

        public Tiendas OnAddRest(object source, TiendaEventArgs e)
        {
            Tiendas resto = new Tiendas(e.Dueño, e.Horario, e.Verificador, e.Categorias);
            a.TodoslasTiendas.Add(resto);
            return resto;

        }
        public List<Tiendas> get_Lista_Restaurants()
        {
            return TodoslasTiendas;
        }
    }
}
