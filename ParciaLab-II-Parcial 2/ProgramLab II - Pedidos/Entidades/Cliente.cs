using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Cliente<T, U> 
        where T : IInformacion, new()
        where U : IInformacion, new()
    {
        int id;
        string nombre;
        T pedidoUno;
        U pedidoDos;
        int totalApagar;
        string lugarDeEntrega;
        
        #region"Constructores"
        public Cliente()
        {
            this.nombre = "";
            this.totalApagar = 0;
            this.lugarDeEntrega = "En el local";
        }
        public Cliente(string nombre, T pedidoUno, U pedidoDos, int totalApagar, string lugarDeEntrega): this()
        {
            this.nombre = nombre;
            this.pedidoUno = pedidoUno;
            this.pedidoDos = pedidoDos;
            this.totalApagar = totalApagar;
            this.lugarDeEntrega = lugarDeEntrega;
        }
        public Cliente(int id, string nombre, T pedidoUno, U pedidoDos, int totalApagar, string lugarDeEntrega):this(nombre,pedidoUno,pedidoDos,totalApagar,lugarDeEntrega)
        {
            this.id = id;
        }
        #endregion

        #region"Get - Set"
        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public T PedidoUno
        {
            get { return pedidoUno; }
        }
        public U PedidoDos
        {
            get { return pedidoDos; }
        }
        public int TotalApagar
        {
            get { return PrecioACobrar(); }
        }
        public string LugarDeEntrega
        {
            get { return lugarDeEntrega; }
            set { this.lugarDeEntrega = value; }
        }
        #endregion
        public int PrecioACobrar()
        {
            try
            {
                int retorno = 0;
                retorno = pedidoUno.precioFinalAsumar + pedidoDos.precioFinalAsumar;
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string TipoDePedido<W>(W pedido) where W : IInformacion
        {
            return pedido.TipoDeClase;
        }
        public int IdDePedido<W>(W pedido) where W : IInformacion
        {
            return pedido.Id;
        }
        /*
        public Queue<W> CrearClienteCC<W>(string nombre, Comida pedidoUno, Comida pedidoDos, int totalApagar, string lugarDeEntrega) where W : Cliente<T,U>
        {
            return new Cliente<Comida,Comida>(nombre, pedidoUno, pedidoDos, totalApagar, lugarDeEntrega);
        }*/
    }
}
