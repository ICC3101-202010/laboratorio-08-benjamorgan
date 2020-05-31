using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_8
{
    public partial class Form2 : Form
    {
        //public List<Restaurant> TodoslosRestaurants = new List<Restaurant>();
        public List<Tiendas> TodoslasTiendas = new List<Tiendas>();
        public List<Cine> TodoslosCines = new List<Cine>();
        public List<Recreacional> TodoslasRecreacionales = new List<Recreacional>();
        public Form2(List<Restaurant> TodoslosRestaurants, List<Tiendas> TodoslasTiendas, List<Cine> TodoslosCines, List<Recreacional> TodoslasRecreacionales)
        {
            InitializeComponent();
            Controladores.ControladorRestaurantes a = new Controladores.ControladorRestaurantes();

            for (int i = 0; i < TodoslosRestaurants.Count() ; i++)
            {
                richTextBoxConTodosLosLocales.Text += "Dueño "+ TodoslosRestaurants[i].Dueño.ToString() + " Horario: "+ TodoslosRestaurants[i].Horarios.ToString() + " Numero Verificador: "+ TodoslosRestaurants[i].Num_verificador.ToString()+ " Mesas exclisuvas: "+ TodoslosRestaurants[i].Mesas_exclusivas.ToString()+ Environment.NewLine;
            }
            for (int i = 0; i < TodoslasTiendas.Count(); i++)
            {
                richTextBoxConTodosLosLocales.Text += "Dueño " + TodoslasTiendas[i].Dueño.ToString() + " Horario: " + TodoslasTiendas[i].Horarios.ToString() + " Numero Verificador: " + TodoslasTiendas[i].Num_verificador.ToString() + " Categorias: " + TodoslasTiendas[i].categorias.ToString() + Environment.NewLine;
            }
            for (int i = 0; i < TodoslosCines.Count(); i++)
            {
                richTextBoxConTodosLosLocales.Text += "Dueño " + TodoslosCines[i].Dueño.ToString() + " Horario: " + TodoslosCines[i].Horarios.ToString() + " Numero Verificador: " + TodoslosCines[i].Num_verificador.ToString() + " Numero de salas: " + TodoslosCines[i].Num_salas.ToString() + Environment.NewLine;
            }
            for (int i = 0; i < TodoslasRecreacionales.Count(); i++)
            {
                richTextBoxConTodosLosLocales.Text += "Dueño " + TodoslasRecreacionales[i].Dueño.ToString() + " Horario: " + TodoslasRecreacionales[i].Horarios.ToString() + " Numero Verificador: " + TodoslasRecreacionales[i].Num_verificador.ToString() + " Capacidad de clientes: " + TodoslasRecreacionales[i].Capacidad_de_clientes.ToString() + Environment.NewLine;
            }

        }

        private void richTextBoxConTodosLosLocales_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
