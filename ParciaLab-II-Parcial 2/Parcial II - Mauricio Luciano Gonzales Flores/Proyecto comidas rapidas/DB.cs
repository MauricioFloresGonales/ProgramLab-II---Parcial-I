using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Proyecto_comidas_rapidas
{
    public class DB
    {
        static SqlConnection conexionDB;

        static DB()
        {
            conexionDB = new SqlConnection("Data Source=NOTEBOOKPIPOCA\\SQLEXPRESS; Initial Catalog = Parcial_Pedidos; integrated segurity = true ");
        }

        public static List<Comida> GetComidas()
        {
            try
            {
                List<Comida> auxComidas = new List<Comida>();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM comida";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxComidas.Add(new Comida(
                        int.Parse(datos["id"].ToString()),
                        datos["nombre"].ToString(),
                        int.Parse(datos["precio"].ToString())
                    ));
                }
                return auxComidas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
