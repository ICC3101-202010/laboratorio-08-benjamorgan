using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_8.Controladores;

namespace Lab_8.Controladores
{
    class ControladorRestaurantes
    {
        Form1 appform;
        List<Restaurant> TodoslosRestaurants = new List<Restaurant>();
        Restaurant a = new Restaurant("a", "a", 1, false);

        public ControladorRestaurantes()
        {

        }
        public ControladorRestaurantes(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddRest += OnAddRest;
        }

        public Restaurant OnAddRest(object source, RestaurantEventArgs e)
        {
            Restaurant resto = new Restaurant(e.Dueño,e.Horario,e.Verificador,e.MesasP);
            a.TodoslosRestaurants.Add(resto);
            return resto;

        }
        public List<Restaurant> get_Lista_Restaurants()
        {
            return TodoslosRestaurants;
        }

        public Restaurant get_a()
        {
            return a;
        }
    }
}
