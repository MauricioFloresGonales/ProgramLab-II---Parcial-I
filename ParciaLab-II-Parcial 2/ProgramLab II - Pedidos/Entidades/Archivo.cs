using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Archivo<T,U>
        where T: IInformacion, new()
        where U : IInformacion, new()
    {
        public static void GenerarTicket(Cliente<T,U> cliente, string fileName)
        {
            try
            {
                string datetime = string.Concat(DateTime.Now.ToString("HH_mm_ss"));
                string filename = string.Concat(datetime, "_", fileName);
                string ruteFile = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\", filename);

                using (StreamWriter auxSW = new StreamWriter(ruteFile, true))
                {
                    auxSW.WriteLine($"Ticket del fecha: {datetime}");
                    auxSW.WriteLine($"Direccion de entrega: {cliente.LugarDeEntrega}");
                    auxSW.WriteLine("------------------------------------------------------");
                    auxSW.WriteLine(cliente.PedidoUno.InformacionDelProducto());
                    auxSW.WriteLine(cliente.PedidoDos.InformacionDelProducto());
                    auxSW.WriteLine("------------------------------------------------------");
                    auxSW.WriteLine($"Precio Final: {cliente.TotalApagar}");
                    auxSW.WriteLine("GRACIAS VUELVA PRONTO");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void GenerarSerializacion<V>(Queue<V> filaDeClientes, string fileName) where V : IInformacion, new()
        {
            try
            {
                string datetime = string.Concat(DateTime.Now.ToString("HH_mm_ss"));
                string filename = string.Concat(datetime, "_", fileName);
                string ruteFile = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\", filename);

                using (XmlTextWriter  xmlArchivo = new XmlTextWriter(ruteFile, Encoding.UTF8))
                {
                    XmlSerializer escribir = new XmlSerializer(typeof(V));

                    escribir.Serialize(xmlArchivo, filaDeClientes);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Queue<V> LeerSerializacion<V>(string fileName) where V : IInformacion, new()
        {
            try
            {
                Queue<V> aux = new Queue<V>();

                using (XmlTextReader xmlArchivo = new XmlTextReader(fileName))
                {
                    XmlSerializer leer = new XmlSerializer(typeof(Queue<V>));

                    return aux = (Queue<V>)leer.Deserialize(xmlArchivo);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
