using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    public class Servicio_Consulta : InterfazHospital<Consulta>
    {
            List<Consulta> consultas = new List<Consulta>();
            Cnx_Consulta consultaDatos = new Cnx_Consulta();

            public Servicio_Consulta()
            {
                consultas = new List<Consulta>();
            }

            private List<Consulta> TableToList()
            {
                try
                {
                    DataTable tabla = new DataTable();
                    List<Consulta> lista = new List<Consulta>();

                    tabla = consultaDatos.AdquirirTablaConsultas(); 

                    foreach (DataRow fila in tabla.Rows)
                    {
                        Consulta consulta = new Consulta();

                        consulta.Id = Convert.ToInt32(fila["Id"]);
                        consulta.PrimerNombre = fila["PrimerNombre"].ToString();
                        consulta.SegundoNombre = fila["SegundoNombre"].ToString();
                        consulta.PrimerApellido = fila["PrimerApellido"].ToString();
                        consulta.SegundoApellido = fila["SegundoApellido"].ToString();
                        consulta.Telefono = fila["Telefono"].ToString();
                        consulta.Correo = fila["Correo"].ToString();
                        consulta.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        consulta.Nacionalidad = fila["Nacionalidad"].ToString();
                        consulta.IdDescripcion = Convert.ToInt32(fila["IdDescripcion"]);
                        consulta.ValoracionMedica = fila["ValoracionMedica"].ToString();
                        consulta.FechaValoracion = Convert.ToDateTime(fila["FechaValoracion"]);
                        consulta.Medicamentos = fila["Medicamentos"].ToString();

                        lista.Add(consulta);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public List<Consulta> GetAll()
            {
                consultas = TableToList();
                return consultas;
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

            public bool Add(Consulta consulta)
            {
                if (Exist(consulta.Id) || consulta == null) return false;
                return consultaDatos.InsertarConsulta(consulta);
            }

            public bool Update(Consulta consulta)
            {
                if (Exist(consulta.Id))
                {
                    return consultaDatos.ActualizarConsulta(consulta);
                }
                return false;
            }

            public bool Delete(int id)
            {
                if (Exist(id)) return consultaDatos.EliminarConsulta(id);
                return false;
            }
        }



    
}
