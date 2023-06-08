using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Servicio_Medico : InterfazHospital<Medico>
    {
        List<Medico> medicos = new List<Medico>();
        Cnx_Medico datosMedico = new Cnx_Medico();


        public Servicio_Medico()
        {
            medicos = new List<Medico>();
        }

        private List<Medico> TableToList()
        {
            try
            {
                DataTable tabla = new DataTable();
                List<Medico> lista = new List<Medico>();

                tabla = datosMedico.AdquirirTablaMedicos();

                foreach (DataRow fila in tabla.Rows)
                {
                    Medico medico = new Medico();

                    medico.Id = Convert.ToInt32(fila["Id"]);
                    medico.PrimerNombre = fila["PrimerNombre"].ToString();
                    medico.SegundoNombre = fila["SegundoNombre"].ToString();
                    medico.PrimerApellido = fila["PrimerApellido"].ToString();
                    medico.SegundoApellido = fila["SegundoApellido"].ToString();
                    medico.Telefono = fila["Telefono"].ToString();
                    medico.Correo = fila["Correo"].ToString();
                    medico.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                    medico.Nacionalidad = fila["Nacionalidad"].ToString();
                    medico.AniosExpe = Convert.ToInt32(fila["AniosExpe"]);

                    lista.Add(medico);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Medico> GetAll()
        {
            medicos = TableToList();
            return medicos;
        }

        public List<Medico> GetByName(string name)
        {
            var lista = new List<Medico>();
            foreach (var item in GetAll())
            {
                if (item.PrimerNombre.ToUpper().Contains(name.ToUpper()))
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

        public bool Add(Medico medico)
        {
            if (Exist(medico.Id) || medico == null) return false;
            return datosMedico.InsertarMedico(medico);
        }

        public bool Update(Medico medico)
        {
            if (Exist(medico.Id))
            {
                return datosMedico.ActualizarMedico(medico);
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (Exist(id)) return datosMedico.EliminarMedico(id);
            return false;
        }
    }

}
