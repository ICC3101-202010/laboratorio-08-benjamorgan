using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.Controladores
{
    class ControladorRecreacional
    {
        Form1 appform;
        List<Recreacional> TodoslasRecreacionales = new List<Recreacional>();
        Recreacional a = new Recreacional("a", "a", 0, 0);
        public ControladorRecreacional(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddRecreativo += OnAddRest;
        }

        public Recreacional OnAddRest(object source, RecreativoEventArgs e)
        {
            Recreacional resto = new Recreacional(e.Dueño, e.Horario, e.Verificador, e.CapacidadClientes);
            a.TodoslasRecreacionales.Add(resto);
            return resto;

        }
        public List<Recreacional> get_Lista_Restaurants()
        {
            return TodoslasRecreacionales;
        }
    }
}
