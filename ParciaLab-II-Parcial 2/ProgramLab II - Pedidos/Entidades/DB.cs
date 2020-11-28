using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class DB
    {
        static SqlConnection conexionDB;

        static DB()
        {
            conexionDB = new SqlConnection("Data Source=NOTEBOOKPIPOCA\\SQLEXPRESS; Initial Catalog = Parcial_Pedidos; integrated security = true ");
        }
        #region"Comida"
        public static List<Comida> GetComidas()
        {
            try
            {
                List<Comida> auxComidas = new List<Comida>();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM comidas";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxComidas.Add(new Comida(
                        int.Parse(datos["id"].ToString()),
                        Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                        int.Parse(datos["precio"].ToString()),
                        Comida.ValidarTipo(datos["tipo"].ToString()),
                        Comida.ValidarCondimento(datos["condimentos"].ToString())
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="auxComidas"></param>
        /// <returns>retorna el numero de datos insertados</returns>
        public static int InsertarComidas(Comida auxComidas)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[comidas] VALUES @nombre, @precio, @tipo";
                comando.Parameters.Add(new SqlParameter("@nombre", auxComidas.Nombre));
                comando.Parameters.Add(new SqlParameter("@precio", auxComidas.Precio));
                comando.Parameters.Add(new SqlParameter("@tipo", auxComidas.Tipo));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                return comando.ExecuteNonQuery();
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
        public static Comida GetComidaPorId(string id)
        {
            try
            {
                Comida auxComidas = new Comida();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM comidas WHERE comidas.id = @id";
                comando.Parameters.Add(new SqlParameter("@id", id));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxComidas = new Comida(
                        int.Parse(datos["id"].ToString()),
                        Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                        int.Parse(datos["precio"].ToString()),
                        Comida.ValidarTipo(datos["tipo"].ToString()),
                        Comida.ValidarCondimento(datos["condimentos"].ToString())
                        );
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

        #endregion

        #region"Bebida"
        public static List<Bebida> GetBebidas()
        {
            try
            {
                List<Bebida> auxComidas = new List<Bebida>();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM bebida";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxComidas.Add(new Bebida(
                        int.Parse(datos["id"].ToString()),
                        Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                        int.Parse(datos["precio"].ToString()),
                        Bebida.ValidadrGusto(datos["gusto"].ToString())
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
        public static int InsertarBebidas(Bebida auxBebida)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[comidas] VALUES @nombre, @precio, @tipo";
                comando.Parameters.Add(new SqlParameter("@nombre", auxBebida.Nombre));
                comando.Parameters.Add(new SqlParameter("@precio", auxBebida.Precio));
                comando.Parameters.Add(new SqlParameter("@tipo", auxBebida.Gusto));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                return comando.ExecuteNonQuery();
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
        public static Bebida GetBebidaPorId(string id)
        {
            try
            {
                Bebida auxBebidas = new Bebida();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM comidas WHERE comidas.id = @id";
                comando.Parameters.Add(new SqlParameter("@id", id));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxBebidas = new Bebida(
                        int.Parse(datos["id"].ToString()),
                        Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                        int.Parse(datos["precio"].ToString()),
                        Bebida.ValidadrGusto(datos["gusto"].ToString())
                        );
                }
                return auxBebidas;
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
        #endregion

        #region"Cliente"
        public static Queue<Cliente<U,V>> GetCliente<T,U,V,W>()
            where V:U
            where U:Bebida, W, T
            where W : Comida,IInformacion, new()
        {
            try
            {
                Queue<Cliente<U,V>> auxClientes = new Queue<Cliente<U, V>>();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM cliente";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    if (datos["tipoUno"].ToString().Equals("comida") && datos["tipoDos"].ToString().Equals("comida"))
                    {
                        auxClientes.Enqueue(new Cliente<Comida,Comida>(
                            Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                            DB.GetComidaPorId(datos["tipoUno"].ToString()),
                            DB.GetComidaPorId(datos["tipoDos"].ToString()),
                            int.Parse(datos["totalApagar"].ToString()),
                            Validador.SacarEspaciosDeMas(datos["lugarDeEntrega"].ToString())
                            );
                    }
                    if (datos["tipoUno"].ToString().Equals("comida") && datos["tipoDos"].ToString().Equals("bebida"))
                    {
                        auxClientes.Enqueue(new Cliente<Comida, Bebida>(
                            Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                            DB.GetComidaPorId(datos["tipoUno"].ToString()),
                            DB.GetComidaPorId(datos["tipoDos"].ToString()),
                            int.Parse(datos["totalApagar"].ToString()),
                            Validador.SacarEspaciosDeMas(datos["lugarDeEntrega"].ToString())
                            );
                    }
                    if (datos["tipoUno"].ToString().Equals("bebida") && datos["tipoDos"].ToString().Equals("comida"))
                    {
                        auxClientes.Enqueue(new Cliente<Bebida, Comida>(
                            Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                            DB.GetBebidaPorId(datos["tipoUno"].ToString()),
                            DB.GetComidaPorId(datos["tipoDos"].ToString()),
                            int.Parse(datos["totalApagar"].ToString()),
                            Validador.SacarEspaciosDeMas(datos["lugarDeEntrega"].ToString())
                            );
                    }
                    if (datos["tipoUno"].ToString().Equals("bebida") && datos["tipoDos"].ToString().Equals("bebida"))
                    {
                        auxClientes.Enqueue(new Cliente<Bebida,Bebida>(
                            Validador.SacarEspaciosDeMas(datos["nombre"].ToString()),
                            DB.GetBebidaPorId(datos["tipoUno"].ToString()),
                            DB.GetBebidaPorId(datos["tipoDos"].ToString()),
                            int.Parse(datos["totalApagar"].ToString()),
                            Validador.SacarEspaciosDeMas(datos["lugarDeEntrega"].ToString())
                            );
                    }
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <returns>retorna el numero de datos insertados</returns>
        public static int InsertarCliente<U, V>(Cliente<U, V> auxCliente) where U : V where V : IInformacion, new()
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[[cliente]] VALUES @nombre, @tipoUno, @pedidoUno, @tipoDos, @pedidoDos, @totalAPagar, @lugarDeEntrega";
                comando.Parameters.Add(new SqlParameter("@nombre", auxCliente.Nombre));
                comando.Parameters.Add(new SqlParameter("@tipoUno", auxCliente.TipoDePedido(auxCliente.PedidoUno)));
                comando.Parameters.Add(new SqlParameter("@pedidoUno", auxCliente.IdDePedido(auxCliente.PedidoUno)));
                comando.Parameters.Add(new SqlParameter("@tipoDos", auxCliente.TipoDePedido(auxCliente.PedidoDos)));
                comando.Parameters.Add(new SqlParameter("@pedidoDos", auxCliente.IdDePedido(auxCliente.PedidoUno)));
                comando.Parameters.Add(new SqlParameter("@totalAPagar", auxCliente.TotalApagar));
                comando.Parameters.Add(new SqlParameter("@lugarDeEntrega", auxCliente.LugarDeEntrega));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }
                return comando.ExecuteNonQuery();
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
        #endregion
       
    }
}
