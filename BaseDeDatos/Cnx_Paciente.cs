using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;

namespace BaseDeDatos
{
    public class Cnx_Paciente
    {


        private Conexion cnx = new Conexion();
        private OracleDataAdapter spool = new OracleDataAdapter(); //Actua como un puente entre la base de datos y el conjunto de datos de memoria


        public bool InsertarPaciente(Paciente paciente)
        {
            OracleCommand insr = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                insr.CommandText = "insertarPaciente"; // AL registro  que deseamos enviar
                insr.Connection = cnx.conexion;
                insr.CommandType = CommandType.StoredProcedure; //Tipo
                insr.Parameters.Add("ID", OracleDbType.Int32).Value = paciente.Id;
                insr.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = paciente.PrimerNombre;
                insr.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = paciente.SegundoNombre;
                insr.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = paciente.PrimerApellido;
                insr.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = paciente.SegundoApellido;
                insr.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = paciente.Telefono;
                insr.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = paciente.Correo;
                insr.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = paciente.FechaNacimiento;
                insr.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
                insr.Parameters.Add("EPS", OracleDbType.Varchar2).Value = paciente.Eps;
                insr.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = paciente.Direccion;
                insr.Parameters.Add("SEXO", OracleDbType.Varchar2).Value = paciente.sexo;
                insr.Parameters.Add("TIPO_SANGRE", OracleDbType.Varchar2).Value = paciente.tipo_de_sagre;

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



        public DataTable AdquirirTablaPacientes()
        {
            OracleCommand comandoPaciente = new OracleCommand();
            DataTable tablaPaciente = new DataTable();

            cnx.AbrirConexion();

            try
            {
                comandoPaciente.CommandText = "obtenerPacientes";
                comandoPaciente.Connection = cnx.conexion;
                comandoPaciente.CommandType = CommandType.StoredProcedure;
                comandoPaciente.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                spool.SelectCommand = comandoPaciente;
                spool.Fill(tablaPaciente);

                return tablaPaciente;
            }
            finally
            {
                cnx.CerrarConexion();
            }
        }

      
        public bool ActualizarPaciente(Paciente paciente)
        {
            OracleCommand actualizar = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                actualizar.CommandText = "actualizarPaciente";
                actualizar.Connection = cnx.conexion;
                actualizar.CommandType = CommandType.StoredProcedure;
                actualizar.Parameters.Add("ID", OracleDbType.Int32).Value = paciente.Id;
                actualizar.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = paciente.PrimerNombre;
                actualizar.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = paciente.SegundoNombre;
                actualizar.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = paciente.PrimerApellido;
                actualizar.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = paciente.SegundoApellido;
                actualizar.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = paciente.Telefono;
                actualizar.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = paciente.Correo;
                actualizar.Parameters.Add("FECHA_NACIMIENTO", OracleDbType.Date).Value = paciente.FechaNacimiento;
                actualizar.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
                actualizar.Parameters.Add("EPS", OracleDbType.Varchar2).Value = paciente.Eps;
                actualizar.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = paciente.Direccion;
                actualizar.Parameters.Add("SEXO", OracleDbType.Varchar2).Value = paciente.sexo;
                actualizar.Parameters.Add("TIPO_SANGRE", OracleDbType.Varchar2).Value = paciente.tipo_de_sagre;

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

        public bool EliminarPaciente(int id)
        {
            OracleCommand eliminar = new OracleCommand();

            cnx.AbrirConexion();

            try
            {
                eliminar.CommandText = "eliminarPaciente";
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
