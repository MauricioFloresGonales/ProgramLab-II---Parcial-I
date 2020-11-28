using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda<T> where T:class, IInformacion, new()
    {
        static Queue<T> filaDeClientes;
        public Tienda()
        {
            filaDeClientes = new Queue<T>();
        }
        public static bool AgregarCliente(T cliente)
        {
            try
            {
                filaDeClientes.Enqueue(cliente);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public static T AtenderCliente()
        {
            try
            {
                T primerCliente = filaDeClientes.Dequeue();
                return primerCliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
