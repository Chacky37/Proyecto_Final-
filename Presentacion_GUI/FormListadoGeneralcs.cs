using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class FormListadoGeneralcs : Form
    {
       
        Paciente enlacePaciente = new Paciente();
        Servicio_Paciente servicio = new Servicio_Paciente();
       
        public FormListadoGeneralcs()
        {
            InitializeComponent();
      

        }

        void closing(FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea Salir?", "Bienvenido al Consultorio",
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


        private void CargarPacientes(string id)
        {
            var lista = servicio.GetAll();
            foreach (var item in lista)
            {
                if (lista != null)
                {
                    textBoxId.Text = item.Id.ToString();
                    textBoxPrimerNombre.Text = item.PrimerNombre;
                    textBoxSegundoNombre.Text = item.SegundoNombre;
                    textBoxPrimerApellido.Text = item.PrimerApellido;
                    textBoxSegundoApellido.Text = item.SegundoApellido;
                    fecha_Nacimiento.Value = item.FechaNacimiento;
                    textBoxTelefono.Text = item.Telefono;
                    textBoxCorreo.Text = item.Correo;
                    textBoxDireccion.Text = item.Direccion;
                    textBoxNacionalidad.Text = item.Nacionalidad;
                    cmbSangre.Text = item.tipo_de_sagre;
                    cmbEps.Text = item.Eps.ToString();

                  //  textBoxId.Enabled = false; ///desactiva la capacidad de edición del control
                }
            }
        }
        void Limpiar()
        {    
            fecha_Nacimiento.Value = DateTime.Today;
            textBoxPrimerNombre.Clear();
            textBoxSegundoNombre.Clear();
            textBoxPrimerApellido.Clear();
            textBoxSegundoApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            cmbSangre.Text = string.Empty;
            textBoxNacionalidad.Clear();
            cmbEps.Text = string.Empty;
            textBoxDireccion.Clear();
        }
        void Guardar()
        {

            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo,
                 textBoxDireccion) == false)
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.tipo_de_sagre = cmbSangre.SelectedValue.ToString();
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Nacionalidad = textBoxNacionalidad.Text;
                enlacePaciente.Eps = cmbEps.SelectedValue.ToString();

                if (servicio.Add(enlacePaciente) == true)
                {
                    MessageBox.Show("Paciente Guardado ", "Agregar Paciente",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Paciente si Existe", "Agregar PACIENTE",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos Necesarios");
            }

        }
        public void CargarDatos()
        {
            
            var lista = servicio.GetAll();
            GrillaPacientes.Rows.Clear();
            foreach(var item in lista)
            {
                GrillaPacientes.Rows.Add(item.Id,item.PrimerNombre,item.SegundoNombre,item.PrimerApellido,item.SegundoApellido,
                                        item.FechaNacimiento,item.Telefono,item.Correo,item.tipo_de_sagre,item.Direccion,item.Nacionalidad,item.Eps);
            }
        }

        
        void Actualizar()
        {
            if(textBoxId.Text!="")
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.tipo_de_sagre = cmbSangre.SelectedValue.ToString();
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Nacionalidad = textBoxNacionalidad.Text;
                enlacePaciente.Eps = cmbEps.SelectedValue.ToString().ToString();

                var respuesta = MessageBox.Show("¿Confirmar Cambios?", "Actualizar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Update(enlacePaciente) == true)
                    {
                        CargarDatos();
                        MessageBox.Show("Paciente Actualizado " + enlacePaciente.PrimerNombre + " Actualizado", "Actualizar Pacientes",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error ", "Actualizacion",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Actualizacion Cancelada", "Actualizacion",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        void Eliminar()
        {
            if(textBoxId.Text!="")
            {
                var respuesta = MessageBox.Show("¿Desea Eliminar?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Delete(int.Parse(textBoxId.Text))==true)
                    {
                        MessageBox.Show("Paciente Eliminado.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Eliminacion",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion Cancelada", "Eliminacion",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                CargarDatos();
            }
        }
        
        private bool CamposEstanCompletos(params TextBox[] controles)
        {
            foreach (var control in controles)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
            }
            return false;
        }
 

        void buttonagregar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarDatos();
            Limpiar();
        }
        private void FormListadoGeneralcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
           
            Limpiar();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void FormListadoGeneralcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing(e);
        }
        private void buttonfiltar_Click(object sender, EventArgs e)
        {

        }




        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        private void GrillaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

