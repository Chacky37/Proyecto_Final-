using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;
using TextBox = System.Windows.Forms.TextBox;

namespace Presentacion_GUI
{
    public partial class FrmMedico : Form
    {
        Medico enlaceMedico = new Medico();
        Servicio_Medico servicio = new Servicio_Medico();

        public FrmMedico()
        {
            InitializeComponent();
        }


        void Nuevo()
        {
            textBoxId.Enabled = true;
            textBoxId.Focus();

            textBoxId.Clear();
            textBoxPrimerNombre.Clear();
            textBoxSegundoNombre.Clear();
            textBoxPrimerApellido.Clear();
            textBoxSegundoApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            dtpGraduacion.Value = DateTime.Today;
            dtpNacimiento.Value = DateTime.Today;
            cmbCiudad.Text = "";
            cmbEspecialidad.Text = "";


        }
        void CargarEspecialidades()
        {
            Servicio_Especialidad servicio = new Servicio_Especialidad();
            cmbEspecialidad.DataSource = servicio.GetAll();
            cmbEspecialidad.DisplayMember = "nombre";
            cmbEspecialidad.ValueMember = "Id";
        }
        bool CamposEstanCompletos(params TextBox[] controles)
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
        void Agregar()
        {
            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo) == false)
            {
                enlaceMedico.Id = int.Parse(textBoxId.Text);
                enlaceMedico.PrimerNombre = textBoxPrimerNombre.Text;
                enlaceMedico.SegundoNombre = textBoxSegundoNombre.Text;
                enlaceMedico.PrimerApellido = textBoxPrimerApellido.Text;
                enlaceMedico.SegundoApellido = textBoxSegundoApellido.Text;
                enlaceMedico.Telefono = textBoxTelefono.Text;
                enlaceMedico.Correo = textBoxCorreo.Text;
                enlaceMedico.Especialidad = cmbEspecialidad.SelectedValue.ToString();
                enlaceMedico.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlaceMedico.FechaNacimiento = dtpNacimiento.Value;

                if (servicio.Add(enlaceMedico) == true)
                {
                    MessageBox.Show("Medico Agregado", "Guardar Medico",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Medico Ya Existe", "Guardar Medico",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos Necesarios");
            }
        }
        void Salir()
        {
            Close();
        }
        void Actualizar()
        {
            if (textBoxId.Text != "")
            {
                enlaceMedico.Id = int.Parse(textBoxId.Text);
                enlaceMedico.PrimerNombre = textBoxPrimerNombre.Text;
                enlaceMedico.SegundoNombre = textBoxSegundoNombre.Text;
                enlaceMedico.PrimerApellido = textBoxPrimerApellido.Text;
                enlaceMedico.SegundoApellido = textBoxSegundoApellido.Text;
                enlaceMedico.FechaNacimiento = dtpNacimiento.Value;
                enlaceMedico.Telefono = textBoxTelefono.Text;
                enlaceMedico.Correo = textBoxCorreo.Text;
                enlaceMedico.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlaceMedico.Especialidad = cmbEspecialidad.SelectedValue.ToString();

                var respuesta = MessageBox.Show("¿Desea Actualizar " + textBoxPrimerNombre.Text + "?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Update(enlaceMedico) == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Medico " + enlaceMedico.PrimerNombre + " Actualizado ", "Actualizar");
                    }
                    else
                    {
                        MessageBox.Show("Error ", "Actualizar");
                    }
                }
                else
                {
                    MessageBox.Show("Actualizacion no Lograda", "Actualizar");
                }
            }
        }
        int ObtenerAño(DateTime fecha)
        {
            int años = (DateTime.Now.Year - fecha.Year);
            return años;
        }
        void CargarGrilla()
        {
            GrillaMed.Rows.Clear();
            var lista = servicio.GetAll();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    GrillaMed.Rows.Add(item.Id,
                                       item.PrimerNombre,
                                       item.SegundoNombre,
                                       item.PrimerApellido,
                                       item.SegundoApellido,
                                       ObtenerAño(item.FechaNacimiento),
                                       item.Telefono,
                                       item.Correo,
                                       item.Especialidad,
                                       item.Nacionalidad);
                }
            }
        }
        void Eliminar()
        {
            if (textBoxId.Text != null)
            {
                var respuesta = MessageBox.Show("¿Desea Eliminar " + textBoxPrimerNombre.Text + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Delete(int.Parse(textBoxId.Text)) == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Medico Eliminado ", "Eliminar");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion no lograda", "Eliminar");
                }

            }
        }
        void Filtrar()
        {
            if (TxtFiltrar.Text != null)
            {
                var lista = servicio.GetByName(TxtFiltrar.Text);
                if (lista != null)
                {
                    GrillaMed.Rows.Clear();
                    foreach (var item in lista)
                    {
                        GrillaMed.Rows.Add(item.Id,
                                           item.PrimerNombre,
                                           item.SegundoNombre,
                                           item.PrimerApellido,
                                           item.SegundoApellido,
                                           ObtenerAño(item.FechaNacimiento),
                                           item.Telefono,
                                           item.Correo,
                                           item.Especialidad,
                                           item.Nacionalidad);
                    }
                }
            }
        }
        


 
        private void FrmMedico_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarEspecialidades();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            CargarGrilla();
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void FrmMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            

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
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            CargarGrilla();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarGrilla();
        }
        private void buttonFiltar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }


    }

}