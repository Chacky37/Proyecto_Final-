using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;


namespace BaseDeDatos
{

    public class Cnx_Especialidad
    {
        private Conexion cnx = new Conexion();
        private OracleDataAdapter spool = new OracleDataAdapter();

        public DataTable AdquirirTablaEspecialidades()
        {
            OracleCommand comandoEspecialidad = new OracleCommand();
            DataTable tablaEspecialidad = new DataTable();

            cnx.AbrirConexion();

            try
            {
                comandoEspecialidad.CommandText = "obtenerEspecialidades";
                comandoEspecialidad.Connection = cnx.conexion;
                comandoEspecialidad.CommandType = CommandType.StoredProcedure;
                comandoEspecialidad.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                spool.SelectCommand = comandoEspecialidad;
                spool.Fill(tablaEspecialidad);

                return tablaEspecialidad;
            }
            finally
            {
                cnx.CerrarConexion();
            }
        }

        public bool InsertarEspecialidad(Especialidad especialidad)
        {
            OracleCommand insr = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                insr.CommandText = "insertarEspecialidad";
                insr.Connection = cnx.conexion;
                insr.CommandType = CommandType.StoredProcedure;
                insr.Parameters.Add("ID", OracleDbType.Int32).Value = especialidad.Id;
                insr.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = especialidad.Nombre;

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

        public bool ActualizarEspecialidad(Especialidad especialidad)
        {
            OracleCommand actualiza = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                actualiza.CommandText = "actualizarEspecialidad";
                actualiza.Connection = cnx.conexion;
                actualiza.CommandType = CommandType.StoredProcedure;
                actualiza.Parameters.Add("ID", OracleDbType.Int32).Value = especialidad.Id;
                actualiza.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = especialidad.Nombre;

                actualiza.ExecuteNonQuery();

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

        public bool EliminarEspecialidad(int id)
        {
            OracleCommand eliminar = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                eliminar.CommandText = "eliminarEspecialidad";
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
