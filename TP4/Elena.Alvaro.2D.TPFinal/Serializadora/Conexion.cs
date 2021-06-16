using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Serializadora
{
    public class Conexion
    {
        public List<Materiales> LeerMaterial()
        {
            List<Materiales> materiales = new List<Materiales>();
            String connectionStr = @"Data Source=.;Initial Catalog = TP4; Integrated Security = True";
            bool aux=true;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT * FROM [Tp4-Tabla]");

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read() != false)
                    {
                        if ((int)dataReader["tipo"] == 0)
                            aux = false;
                        materiales.Add(new Materiales(dataReader["nombre"].ToString(), (int)dataReader["cantidad"], aux));
                    }
                    dataReader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return materiales;
        }

        public bool GuardarMaterial()
        {
            List<Materiales> personas = new List<Materiales>();
            String connectionStr = @"Data Source=.;Initial Catalog = TP4; Integrated Security = True";
            bool aux = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT * FROM [Tp4-Tabla]");

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read() != false)
                    {
                        if ((int)dataReader["tipo"] == 0)
                            aux = false;
                        personas.Add(new Materiales(dataReader["nombre"].ToString(), (int)dataReader["cantidad"], aux));
                    }
                    dataReader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return false; ;
        }
    }
}

