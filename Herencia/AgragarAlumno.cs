using System;
using System.Windows.Forms;

namespace Herencia
{
    public partial class AgragarAlumno : Form
    {
        private FormPrincipal frmPrincipal { get; set; }

        public AgragarAlumno(FormPrincipal form)
        {
            frmPrincipal = form;
            InitializeComponent();
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                Carnet = Convert.ToInt32(txtCarnet.Text),
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoApellido.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Celular = Convert.ToInt32(txtCelular.Text),
                TelefonoCasa = Convert.ToInt32(txtTelefonoCasa.Text)
            };

            frmPrincipal.AgregarAlumno(alumno);
            this.Close();
        }
    }
}
