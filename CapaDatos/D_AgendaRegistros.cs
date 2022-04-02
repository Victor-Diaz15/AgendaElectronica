using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Configuration;

namespace CapaDatos
{
    public class D_AgendaRegistros
    {
        //Connection String
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Metodos CRUD

        //metodo traer la data
        public List<E_AgendaRegistros> GetData()
        {
            SqlCommand cm = new SqlCommand("SP_SELECTALLREGISTROS", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            List<E_AgendaRegistros> Listar = new List<E_AgendaRegistros>();
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                Listar.Add(new E_AgendaRegistros
                {
                    IDREGISTRO = reader.GetInt32(0),
                    NOMBRE = reader.GetString(1),
                    APELLIDO = reader.GetString(2),
                    DIRECCION = reader.GetString(3),
                    FECHA_NACIMIENTO = reader.GetDateTime(4).ToString(),
                    CELULAR = reader.GetString(5)
                });
            }
            reader.Close();
            conexion.Close();
            return Listar;
        }
        //Metodo para traer un registro por el Nombre
        public List<E_AgendaRegistros> SearchRegistro(string name)
        {
            SqlCommand cm = new SqlCommand("SP_BUSCARREGISTRO", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cm.Parameters.AddWithValue("@BUSCAR", name);

            List<E_AgendaRegistros> Listar = new List<E_AgendaRegistros>();
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                Listar.Add(new E_AgendaRegistros
                {
                    IDREGISTRO = reader.GetInt32(0),
                    NOMBRE = reader.GetString(1),
                    APELLIDO = reader.GetString(2),
                    DIRECCION = reader.GetString(3),
                    FECHA_NACIMIENTO = reader.GetDateTime(4).ToString(),
                    CELULAR = reader.GetString(5)
                });
            }
            reader.Close();
            conexion.Close();
            return Listar;
        }
        //METODO PARA TRAER UN REGISTRO POR EL ID
        public SqlDataReader GetDataById(int id)
        {
            SqlCommand cm = new SqlCommand("SP_SELECTBYID", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cm.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cm.ExecuteReader();
            return reader;
        }
        //METODO PARA INGRESAR UN REGISTRO 
        public void AddRegistro(E_AgendaRegistros registro)
        {
            
            SqlCommand cm = new SqlCommand("SP_INSERTARREGISTRO", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cm.Parameters.AddWithValue("@NOMBRE", registro.NOMBRE);
            cm.Parameters.AddWithValue("@APELLIDO", registro.APELLIDO);
            cm.Parameters.AddWithValue("@DIRECCION", registro.DIRECCION);
            cm.Parameters.AddWithValue("@FECHA_NACIMIENTO", Convert.ToDateTime(registro.FECHA_NACIMIENTO));
            cm.Parameters.AddWithValue("@CELULAR", registro.CELULAR);

            cm.ExecuteNonQuery();
            conexion.Close();
        }
        //METODO PARA EDITAR UN REGISTRO 
        public void UpdateRegistro(E_AgendaRegistros registro)
        {
            conexion.Close();
            SqlCommand cm = new SqlCommand("SP_EDITARREGISTRO", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cm.Parameters.AddWithValue("@IDREGISTRO", registro.IDREGISTRO);
            cm.Parameters.AddWithValue("@NOMBRE", registro.NOMBRE);
            cm.Parameters.AddWithValue("@APELLIDO", registro.APELLIDO);
            cm.Parameters.AddWithValue("@DIRECCION", registro.DIRECCION);
            cm.Parameters.AddWithValue("@FECHA_NACIMIENTO", Convert.ToDateTime(registro.FECHA_NACIMIENTO));
            cm.Parameters.AddWithValue("@CELULAR", registro.CELULAR);

            cm.ExecuteNonQuery();
            conexion.Close();
        }
        //METODO ELIMINAR REGISTRO
        public void DeleteRegistro(E_AgendaRegistros registro)
        {
            SqlCommand cm = new SqlCommand("SP_ELIMINARREGISTRO", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cm.Parameters.AddWithValue("@IDREGISTRO", registro.IDREGISTRO);

            cm.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
