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
    public partial class BuscarAlumno : Form
    {
        private FormPrincipal frmPrincipal { get; set; }

        public BuscarAlumno(FormPrincipal form)
        {
            frmPrincipal = form;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
