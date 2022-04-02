using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_AgendaNegocio
    {
        //instancias
        D_AgendaRegistros Data = new D_AgendaRegistros();

        //metodos que llaman a los metodos de la clase de datos

        //Metodo para traer la data
        public List<E_AgendaRegistros> GetData()
        {
            return Data.GetData();
        }
        //Metodo para traer un registro
        public List<E_AgendaRegistros> SearchRegistro(string nombre)
        {
            return Data.SearchRegistro(nombre);
        }
        //Metodo para traer un registro por el id
        public SqlDataReader GetDataById(int id)
        {
            return Data.GetDataById(id);
        }
        //Metodo para ingresar un registro
        public void AddRegistro(E_AgendaRegistros registro)
        {
            Data.AddRegistro(registro);
        }
        //metodo para editar un registro
        public void UpdateRegistro(E_AgendaRegistros registro)
        {
            Data.UpdateRegistro(registro);
        }
        //metodo para eliminar un registro
        public void DeleteRegistro(E_AgendaRegistros registro)
        {
            Data.DeleteRegistro(registro);
        }
    }
}
