using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregar = new AgragarAlumno())
            {
                agregar.ShowDialog();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscar = new BuscarAlumno())
            {
                buscar.ShowDialog();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var editar = new EditarAlumno())
            {
                editar.ShowDialog();
            }
        }
    }
}
