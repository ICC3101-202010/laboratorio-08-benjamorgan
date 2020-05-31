using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 appform = new Form1();
            Controladores.ControladorRestaurantes ctr = new Controladores.ControladorRestaurantes(appform);
            Controladores.ControladorCine ctr1 = new Controladores.ControladorCine(appform);
            Controladores.ControladorRecreacional ctr2= new Controladores.ControladorRecreacional(appform);
            Controladores.ControladorTiendas ctr3= new Controladores.ControladorTiendas(appform);




            Application.Run(appform);
        }
    }
}
