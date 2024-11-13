using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Dao
{
    public class CustomersDao
    {
        string cadena = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

        public List<Customers> ListarCustomers()
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customers> lista = new List<Customers>();
            Customers obj;
            while (reader.Read())
            {
                obj = new Customers()
                {
                    IdCliente = reader.GetString(0),
                    NombreCliente = reader.GetString(1),
                    Direccion = reader.GetString(2),
                    Telefono = reader.GetString(3),
                    Pais = reader.GetString(4),
                };
                lista.Add(obj);
            }
            reader.Close();
            conn.Close();
            return lista;
        }
    }
}