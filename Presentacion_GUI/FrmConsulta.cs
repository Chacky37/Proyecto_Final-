using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class FrmConsulta : Form
    {
        Servicio_Consulta servicio = new Servicio_Consulta();
        public FrmConsulta()
        {
            InitializeComponent();
        }
        void Mensaje(bool boolean)
        {
            if (boolean == true)
            {
                MessageBox.Show("No ha habido ningun problema, todo ha ido correctamente");
            }
            else
            {
                MessageBox.Show("¡Error! Ha habido un error.");
            }
        }
        public void Guardar()
        {
            if (!string.IsNullOrWhiteSpace(txtTratamiento.Text) && (!string.IsNullOrWhiteSpace(txtDiagnostico.Text)) &&
                (!string.IsNullOrWhiteSpace(txtMedicamento.Text)) && (!string.IsNullOrWhiteSpace(txtIdCita.Text)))   
            {
                Consulta consulta = new Consulta();
                consulta.Medicamentos = txtTratamiento.Text;
                consulta.ValoracionMedica = txtDiagnostico.Text;
                consulta.Medicamentos = txtMedicamento.Text;
            }
            else
            {
                Mensaje(false); 
            }

        }
        void CargarGrilla()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = servicio.GetAll();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void FrmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea Salir?", "Consultorio",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Owner.Show();
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}