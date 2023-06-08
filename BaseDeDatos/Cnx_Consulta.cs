using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;
using System.ComponentModel;

namespace BaseDeDatos
{
    public class Cnx_Consulta
    {


        private Conexion cnx = new Conexion();
        private OracleDataAdapter spool = new OracleDataAdapter();


        public bool InsertarConsulta(Consulta consulta)
        {
            OracleCommand insr = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                insr.CommandText = "insertarConsulta";
                insr.Connection = cnx.conexion;
                insr.CommandType = CommandType.StoredProcedure;
                insr.Parameters.Add("ID", OracleDbType.Int32).Value = consulta.Id;
                insr.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = consulta.PrimerNombre;
                insr.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = consulta.SegundoNombre;
                insr.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = consulta.PrimerApellido;
                insr.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = consulta.SegundoApellido;
                insr.Parameters.Add("TEL", OracleDbType.Varchar2).Value = consulta.Telefono;
                insr.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = consulta.Correo;
                insr.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = consulta.FechaNacimiento;
                insr.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = consulta.Nacionalidad;
                insr.Parameters.Add("ID_DESCRIPCION", OracleDbType.Int32).Value = consulta.IdDescripcion;
                insr.Parameters.Add("VALORACION_MEDICA", OracleDbType.Varchar2).Value = consulta.ValoracionMedica;
                insr.Parameters.Add("FECHA_VALORACION", OracleDbType.Date).Value = consulta.FechaValoracion;
                insr.Parameters.Add("MEDICAMENTOS", OracleDbType.Varchar2).Value = consulta.Medicamentos;

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


        public DataTable AdquirirTablaConsultas()
        {
            OracleCommand comandoConsulta = new OracleCommand();
            DataTable TablaConsulta = new DataTable();

            cnx.AbrirConexion();

            try
            {
                comandoConsulta.CommandText = "obtenerConsultas";
                comandoConsulta.Connection = cnx.conexion;
                comandoConsulta.CommandType = CommandType.StoredProcedure;
                comandoConsulta.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                spool.SelectCommand = comandoConsulta;
                spool.Fill(TablaConsulta);

                return TablaConsulta;
            }
            finally
            {
                cnx.CerrarConexion();
            }
        }

        public bool ActualizarConsulta(Consulta consulta)
        {
            OracleCommand actualizar = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                actualizar.CommandText = "actualizarConsulta";
                actualizar.Connection = cnx.conexion;
                actualizar.CommandType = CommandType.StoredProcedure;
                actualizar.Parameters.Add("ID", OracleDbType.Int32).Value = consulta.Id;
                actualizar.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = consulta.PrimerNombre;
                actualizar.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = consulta.SegundoNombre;
                actualizar.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = consulta.PrimerApellido;
                actualizar.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = consulta.SegundoApellido;
                actualizar.Parameters.Add("TEL", OracleDbType.Varchar2).Value = consulta.Telefono;
                actualizar.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = consulta.Correo;
                actualizar.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = consulta.FechaNacimiento;
                actualizar.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = consulta.Nacionalidad;
                actualizar.Parameters.Add("ID_DESCRIPCION", OracleDbType.Int32).Value = consulta.IdDescripcion;
                actualizar.Parameters.Add("VALORACION_MEDICA", OracleDbType.Varchar2).Value = consulta.ValoracionMedica;
                actualizar.Parameters.Add("FECHA_VALORACION", OracleDbType.Date).Value = consulta.FechaValoracion;
                actualizar.Parameters.Add("MEDICAMENTOS", OracleDbType.Varchar2).Value = consulta.Medicamentos;

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

        public bool EliminarConsulta(int id)
        {
            OracleCommand eliminar = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                eliminar.CommandText = "eliminarConsulta";
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
