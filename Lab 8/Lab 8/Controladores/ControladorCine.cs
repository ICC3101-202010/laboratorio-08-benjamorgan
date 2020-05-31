using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.Controladores
{
    class ControladorCine
    {
        Form1 appform;
        List<Cine> TodoslosCines = new List<Cine>();
        Cine a = new Cine("a", "a", 0, 0);
        public ControladorCine(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddCine += OnAddRest;
        }

        public Cine OnAddRest(object source, CineEventArgs e)
        {
            Cine resto = new Cine(e.Dueño, e.Horario, e.Verificador, e.num_salas);
            a.TodoslosCines.Add(resto);
            return resto;

        }
        public List<Cine> get_Lista_Restaurants()
        {
            return TodoslosCines;
        }
    }
}
