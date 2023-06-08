using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Cnx_Medico
    {
       
            private Conexion cnx = new Conexion();
            private OracleDataAdapter spool = new OracleDataAdapter();



            public bool InsertarMedico(Medico medico)
            {
                OracleCommand insr = new OracleCommand();

                cnx.AbrirConexion();

                try
                {
                    insr.CommandText = "insertarMedico";
                    insr.Connection = cnx.conexion;
                    insr.CommandType = CommandType.StoredProcedure;
                    insr.Parameters.Add("ID", OracleDbType.Int32).Value = medico.Id;
                    insr.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = medico.PrimerNombre;
                    insr.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = medico.SegundoNombre;
                    insr.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = medico.PrimerApellido;
                    insr.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = medico.SegundoApellido;
                    insr.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = medico.Telefono;
                    insr.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = medico.Correo;
                    insr.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = medico.FechaNacimiento;
                    insr.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = medico.Nacionalidad;
                    insr.Parameters.Add("ANIOS_EXPERIENCIA", OracleDbType.Int32).Value = medico.AniosExpe;

                    insr.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cnx.CerrarConexion();
                }
            }


            public DataTable AdquirirTablaMedicos()
            {
                OracleCommand comandoMedico = new OracleCommand();
                DataTable tablaMedico = new DataTable();

                cnx.AbrirConexion();

                try
                {
                    comandoMedico.CommandText = "obtenerMedicos";
                    comandoMedico.Connection = cnx.conexion;
                    comandoMedico.CommandType = CommandType.StoredProcedure;
                    comandoMedico.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    spool.SelectCommand = comandoMedico;
                    spool.Fill(tablaMedico);

                    return tablaMedico;
                }
                finally
                {
                    cnx.CerrarConexion();
                }
            }

           

            public bool ActualizarMedico(Medico medico)
            {
                OracleCommand actualizar = new OracleCommand();

                cnx.AbrirConexion();

                try
                {
                    actualizar.CommandText = "actualizarMedico";
                    actualizar.Connection = cnx.conexion;
                    actualizar.CommandType = CommandType.StoredProcedure;
                    actualizar.Parameters.Add("ID", OracleDbType.Int32).Value = medico.Id;
                    actualizar.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = medico.PrimerNombre;
                    actualizar.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = medico.SegundoNombre;
                    actualizar.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = medico.PrimerApellido;
                    actualizar.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = medico.SegundoApellido;
                    actualizar.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = medico.Telefono;
                    actualizar.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = medico.Correo;
                    actualizar.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = medico.FechaNacimiento;
                    actualizar.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = medico.Nacionalidad;
                    actualizar.Parameters.Add("ANIOS_EXPERIENCIA", OracleDbType.Int32).Value = medico.AniosExpe;

                    actualizar.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cnx.CerrarConexion();
                }
            }

            public bool EliminarMedico(int id)
            {
                OracleCommand eliminar = new OracleCommand();

                cnx.AbrirConexion();

                try
                {
                    eliminar.CommandText = "eliminarMedico";
                    eliminar.Connection = cnx.conexion;
                    eliminar.CommandType = CommandType.StoredProcedure;
                    eliminar.Parameters.Add("ID", OracleDbType.Int32).Value = id;

                    eliminar.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cnx.CerrarConexion();
                }
            }
        }

    }

