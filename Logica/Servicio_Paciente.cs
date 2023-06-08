using System;
using System.Collections.Generic;
using Entidades;
using BaseDeDatos;
using System.Data;
using System.Linq;

namespace Logica
{
    public class Servicio_Paciente : InterfazHospital<Paciente>
    {
         List<Paciente> pacientes = new List<Paciente>();
         Cnx_Paciente datosPaciente = new Cnx_Paciente();

        public Servicio_Paciente()
        {
            pacientes = new List<Paciente>();
        }

        private List<Paciente> TableToList()//Convierteun datablate en un objeto
        {
            try
            {
                DataTable tabla = new DataTable();
                List<Paciente> lista = new List<Paciente>();

                tabla = datosPaciente.AdquirirTablaPacientes();

                foreach (DataRow fila in tabla.Rows)
                {
                    Paciente paciente = new Paciente();

                    paciente.Id = Convert.ToInt32(fila["Id"]);
                    paciente.PrimerNombre = fila["PrimerNombre"].ToString();
                    paciente.SegundoNombre = fila["SegundoNombre"].ToString();
                    paciente.PrimerApellido = fila["PrimerApellido"].ToString();
                    paciente.SegundoApellido = fila["SegundoApellido"].ToString();
                    paciente.Telefono = fila["Telefono"].ToString();
                    paciente.Correo = fila["Correo"].ToString();
                    paciente.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                    paciente.Nacionalidad = fila["Nacionalidad"].ToString();
                    paciente.Eps = fila["Eps"].ToString();
                    paciente.Direccion = fila["Direccion"].ToString();
                    paciente.sexo = fila["Sexo"].ToString();
                    paciente.tipo_de_sagre= fila["TipoSangre"].ToString();

                    lista.Add(paciente);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Paciente> GetAll()
        {
            pacientes = TableToList();
            return pacientes;
        }

      
        public bool Exist(int id)
        {
            if (GetAll() != null)
            {
                foreach (var item in GetAll())
                {
                    if (item.Id == id) return true;
                }
            }
            return false;
        }

        public bool Add(Paciente paciente)
        {
            if (Exist(paciente.Id) || paciente == null) return false;
            return datosPaciente.InsertarPaciente(paciente);
        }

        public bool Update(Paciente paciente)
        {
            if (Exist(paciente.Id))
            {
                return datosPaciente.ActualizarPaciente(paciente);
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (Exist(id)) return datosPaciente.EliminarPaciente(id);
            return false;
        }
    }

}
