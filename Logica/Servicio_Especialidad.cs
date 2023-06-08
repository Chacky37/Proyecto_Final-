using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;
using System.Data;

namespace Logica
{
    public class Servicio_Especialidad : InterfazHospital<Especialidad>
    {
        List<Especialidad> especialidades = new List<Especialidad>();
        Cnx_Especialidad datosEspecialidad = new Cnx_Especialidad();

        public Servicio_Especialidad()
        {
            especialidades = new List<Especialidad>();
        }

        private List<Especialidad> TableToList()
        {
            try
            {
                DataTable tabla = new DataTable();
                List<Especialidad> lista = new List<Especialidad>();

                tabla = datosEspecialidad.AdquirirTablaEspecialidades();

                foreach (DataRow fila in tabla.Rows)
                {
                    Especialidad especialidad = new Especialidad();

                    especialidad.Id = Convert.ToInt32(fila["Id"]);
                    especialidad.Nombre = fila["Nombre"].ToString();

                    lista.Add(especialidad);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Especialidad> GetAll()
        {
            especialidades = TableToList();
            return especialidades;
        }

        public List<Especialidad> GetByName(string name)
        {
            var lista = new List<Especialidad>();
            foreach (var item in GetAll())
            {
                if (item.Nombre.ToUpper().Contains(name.ToUpper()))
                {
                    lista.Add(item);
                }
            }
            return lista;
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

        public bool Add(Especialidad especialidad)
        {
            if (Exist(especialidad.Id) || especialidad == null) return false;
            return datosEspecialidad.InsertarEspecialidad(especialidad);
        }

        public bool Update(Especialidad especialidad)
        {
            if (Exist(especialidad.Id))
            {
                return datosEspecialidad.ActualizarEspecialidad(especialidad);
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (Exist(id)) return datosEspecialidad.EliminarEspecialidad(id);
            return false;
        }
    }

}
