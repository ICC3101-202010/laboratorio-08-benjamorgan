using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_8.Controladores;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        BindingList<Local> todoslocales = new BindingList<Local>();
        List<int> Verificadores = new List<int>();
        List<Restaurant> TodoslosRestaurants1 = new List<Restaurant>();
        List<Tiendas> TodoslasTiendas1 = new List<Tiendas>();
        List<Cine> TodoslosCines1 = new List<Cine>();
        List<Recreacional> TodoslasRecreacionales1 = new List<Recreacional>();


        public delegate Restaurant RestaurantEventHandler(object source, RestaurantEventArgs args);
        public event RestaurantEventHandler AddRest;
        public delegate Tiendas TiendaEventHandler(object source, TiendaEventArgs args);
        public event TiendaEventHandler AddTienda;
        public delegate Cine CineEventHandler(object source, CineEventArgs args);
        public event CineEventHandler AddCine;
        public delegate Recreacional RecreativoEventHandler(object source, RecreativoEventArgs args);
        public event RecreativoEventHandler AddRecreativo;


        public Form1()
        {
            InitializeComponent();
        }

        private void labelVer_Locales_Click(object sender, EventArgs e)
        {
            panelVista_De_Locales_Existentes.Visible = true;
            todoslocales.Clear();
            for (int i = 0; i < TodoslosRestaurants1.Count; i++)
            {
                todoslocales.Add(TodoslosRestaurants1[i]);
            }
            for (int i = 0; i < TodoslosCines1.Count; i++)
            {
                todoslocales.Add(TodoslosCines1[i]);
            }
            for (int i = 0; i < TodoslasTiendas1.Count; i++)
            {
                todoslocales.Add(TodoslasTiendas1[i]);
            }
            for (int i = 0; i < TodoslasRecreacionales1.Count; i++)
            {
                todoslocales.Add(TodoslasRecreacionales1[i]);
            }
            comboBox1.DataSource = todoslocales;
            comboBox1.DisplayMember = "Num_verificador";
        }


        private void pictureBoxRevisar_Local_Existente_Click(object sender, EventArgs e)
        {
            panelVista_De_Locales_Existentes.Visible = true;
            todoslocales.Clear();
            for (int i = 0; i < TodoslosRestaurants1.Count; i++)
            {
                todoslocales.Add(TodoslosRestaurants1[i]);
            }
            for (int i = 0; i < TodoslosCines1.Count; i++)
            {
                todoslocales.Add(TodoslosCines1[i]);
            }
            for (int i = 0; i < TodoslasTiendas1.Count; i++)
            {
                todoslocales.Add(TodoslasTiendas1[i]);
            }
            for (int i = 0; i < TodoslasRecreacionales1.Count; i++)
            {
                todoslocales.Add(TodoslasRecreacionales1[i]);
            }
            comboBox1.DataSource = todoslocales;
            comboBox1.DisplayMember = "Num_verificador";

        }

        private void labelSalir_Ver_Loacales_Click(object sender, EventArgs e)
        {
            panelVista_De_Locales_Existentes.Visible = false;
            todoslocales.Clear();

        }



        private void lblAñadir_nuevo_local_Click(object sender, EventArgs e)
        {

            panelAñadir_Nuevo_Local.Visible = true;
            panelAñadir_Nuevo_Local.BringToFront();


        }

        private void labelVolver_Al_Inicio_Click(object sender, EventArgs e)
        {
            panelAñadir_Nuevo_Local.Visible = false;
            panelVista_De_Locales_Existentes.Visible = false;
        }

        private void panelVolver_Del_Menu_Añadir_Paint(object sender, PaintEventArgs e)
        {
            panelAñadir_Nuevo_Local.Visible = false;
            panelVista_De_Locales_Existentes.Visible = false;
        }

        private void pictureBoxAgregar_Nuevo_Local_Click(object sender, EventArgs e)
        {

            panelAñadir_Nuevo_Local.Visible = true;
            panelAñadir_Nuevo_Local.BringToFront();

        }

        private void labelVolver_Al_Inicio_Click_1(object sender, EventArgs e)
        {
            panelAñadir_Nuevo_Local.Visible = false;
            panelVista_De_Locales_Existentes.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void labelRecreacion_Click(object sender, EventArgs e)
        {
            panelAñadir_Recreacion.Visible = true;
        }

        private void labelRestaurant_Click(object sender, EventArgs e)
        {
            panelAñadir_Restaurant.Visible = true;
        }

        private void labelCine_Click(object sender, EventArgs e)
        {
            panelAñadir_Cine.Visible = true;
        }

        private void labelTiendas_Click(object sender, EventArgs e)
        {
            panelAñadir_Tiendas.Visible = true;
        }

        private void buttonVolver_Restaurant_Click(object sender, EventArgs e)
        {
            panelAñadir_Restaurant.Visible = false;
        }

        private void buttonback_Añadir_cine_Click(object sender, EventArgs e)
        {
            panelAñadir_Cine.Visible = false;
        }

        private void buttonVolverAñadir_Recreacion_Click(object sender, EventArgs e)
        {
            panelAñadir_Recreacion.Visible = false;
        }

        private void buttonvolverAñadir_Tiendas_Click(object sender, EventArgs e)
        {
            panelAñadir_Tiendas.Visible = false;
        }

        private void labelSalir_Buscar_Local_Click(object sender, EventArgs e)
        {
            panelVista_De_Locales_Existentes.Visible = false;
        }

        private void labelVer_Locales_Existentes_Click(object sender, EventArgs e)
        {
            Form2 forms2 = new Form2(TodoslosRestaurants1, TodoslasTiendas1, TodoslosCines1, TodoslasRecreacionales1);
            forms2.ShowDialog();

        }
        
        private void buttonAgregar_Restaurant_Click(object sender, EventArgs e)
        {
            string dueño = textBoxDueño_Restaurant.Text;
            string horario = textBoxHorario_Restaurant.Text;
            bool aux = false;
            int k = 0;
            bool MPremium = false;
            if (checkBoxPremium_restaurant.Checked == true)
                MPremium = true;
            for (int i = 0; i < Verificadores.Count(); i++)
            {
                if (Verificadores[i].ToString() == textBoxVerificador_Restaurant.Text)
                {
                    aux = true;
                }
            }
            Int32.TryParse(textBoxVerificador_Restaurant.Text, out k);
            if (aux == false && k > 0)
            {
                if (AddRest != null)
                {
                    Verificadores.Add(k);
                    Restaurant res = AddRest(this, new RestaurantEventArgs()
                    {
                        Dueño = dueño,
                        Horario = horario,
                        Verificador = k,
                        MesasP = MPremium

                    });
                    textBoxDueño_Restaurant.Clear();
                    textBoxHorario_Restaurant.Clear();
                    textBoxVerificador_Restaurant.Clear();
                    checkBoxPremium_restaurant.Checked = false;
                    TodoslosRestaurants1.Add(res);


                }



            }
            else
                labelError_num_Restaurants.Visible = true;
        }

        private void buttonAgregar_cine_Click(object sender, EventArgs e)
        {
            string dueño = textBoxDueño_Cine.Text;
            string horario = textBoxHorario_Cine.Text;
            bool aux = false;
            int k = 0;
            for (int i = 0; i < Verificadores.Count(); i++)
            {
                if (Verificadores[i].ToString() == textBoxVerificador_Cine.Text)
                {
                    aux = true;
                }
            }
            int q = 0;
            Int32.TryParse(textBoxNum_Salas_Cine.Text, out q);
            Int32.TryParse(textBoxVerificador_Cine.Text, out k);
            if (aux == false && k > 0 && q > 0)
            {
                if (AddCine != null)
                {
                    Verificadores.Add(k);
                    Cine cine = AddCine(this, new CineEventArgs()
                    {
                        Dueño = dueño,
                        Horario = horario,
                        Verificador = k,
                        num_salas = q

                    });
                    textBoxDueño_Cine.Clear();
                    textBoxHorario_Cine.Clear();
                    textBoxVerificador_Cine.Clear();
                    textBoxNum_Salas_Cine.Clear();
                    TodoslosCines1.Add(cine);

                }
            }
            else
                labelError_Cine.Visible = true;
        }

        private void bottonAgregar_Tienda_Click(object sender, EventArgs e)
        {
            string dueño = textBoxDueño_Tienda.Text;
            string horario = textBoxHorario_Tienda.Text;
            bool aux = false;
            int k = 0;
            for (int i = 0; i < Verificadores.Count(); i++)
            {
                if (Verificadores[i].ToString() == textBoxVerificador_Tienda.Text)
                {
                    aux = true;
                }
            }
            string q = textBoxCategoria_Tienda.Text;
            Int32.TryParse(textBoxVerificador_Tienda.Text, out k);
            if (aux == false && k > 0)
            {
                if (AddTienda != null)
                {
                    Verificadores.Add(k);
                    Tiendas tienda = AddTienda(this, new TiendaEventArgs()
                    {
                        Dueño = dueño,
                        Horario = horario,
                        Verificador = k,
                        Categorias = q

                    });
                    textBoxDueño_Tienda.Clear();
                    textBoxHorario_Tienda.Clear();
                    textBoxVerificador_Tienda.Clear();
                    textBoxCategoria_Tienda.Clear();
                    TodoslasTiendas1.Add(tienda);

                }
            }
            else
                labelError_Tienda.Visible = true;
        }

        private void buttonAgregar_Recreacional_Click(object sender, EventArgs e)
        {
            string dueño = textBoxDueño_Recreacional.Text;
            string horario = textBoxHorario_Recreacional.Text;
            bool aux = false;
            int k = 0;
            for (int i = 0; i < Verificadores.Count(); i++)
            {
                if (Verificadores[i].ToString() == textBoxVerificador_Recreacional.Text)
                {
                    aux = true;
                }
            }
            int q = 0;
            Int32.TryParse(textBoxClientes_Recreacional.Text, out q);
            Int32.TryParse(textBoxVerificador_Recreacional.Text, out k);
            if (aux == false && k > 0 && q > 0)
            {
                if (AddCine != null)
                {
                    Verificadores.Add(k);
                    Recreacional recreativ = AddRecreativo(this, new RecreativoEventArgs()
                    {
                        Dueño = dueño,
                        Horario = horario,
                        Verificador = k,
                        CapacidadClientes = q

                    });
                    textBoxDueño_Recreacional.Clear();
                    textBoxHorario_Recreacional.Clear();
                    textBoxVerificador_Recreacional.Clear();
                    textBoxClientes_Recreacional.Clear();
                    TodoslasRecreacionales1.Add(recreativ);

                }
            }
            else
                labelError_Cine.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Local selected = comboBox1.SelectedItem as Local;
            textBoxInfo_Local_Al_Hacer_Clic.Text = "Dueño " + selected.Dueño + " ;Horario: " + selected.Horarios + " ;Numero Veridicador:  " + selected.Num_verificador ;

        }
    }
}
