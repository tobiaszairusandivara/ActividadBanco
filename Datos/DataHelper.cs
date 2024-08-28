using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;

namespace BancoApp.Datos
{
    public class DataHelper
    {
        private static DataHelper _instancia;
        private SqlConnection conexion;
        private string cadenaConexion;
        private DataHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public static DataHelper ConseguirInstancia()
        {
            if(_instancia == null)
            {
                _instancia = new DataHelper();
            }
            return _instancia;
        }
        public DataTable? ExecuteSPQuery(string sp, params SqlParameter[] parameters)
        {
            DataTable? tabla = new DataTable();
            try
            {
                conexion.Open();
                var cmd = new SqlCommand(sp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                tabla.Load(cmd.ExecuteReader());
                conexion.Close();
            }
            catch (SqlException)
            {
                tabla = null;
            }
            return tabla;
        }
        public bool ExecteCRUDSPQuery(string sp, params SqlParameter[] parametros)
        {
            bool retorno;
            try
            {
                conexion.Open();
                var cmd = new SqlCommand(sp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }
                if (cmd.ExecuteNonQuery() != 0)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch(SqlException)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
