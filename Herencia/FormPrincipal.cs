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
    public partial class FormPrincipal : Form
    {
        private Stack<Alumno> Pila { get; set; }

        public FormPrincipal()
        {
            Pila = new Stack<Alumno>();
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregar = new AgragarAlumno(this))
            {
                agregar.ShowDialog();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscar = new BuscarAlumno(this))
            {
                buscar.ShowDialog();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var editar = new EditarAlumno(this))
            {
                editar.ShowDialog();
            }
        }

        public void AgregarAlumno(Alumno alumno)
        {
            Pila.Push(alumno);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Pila;

            dgvAlumnos.DataSource = bindingSource;
            dgvAlumnos.Refresh();
        }
    }
}
