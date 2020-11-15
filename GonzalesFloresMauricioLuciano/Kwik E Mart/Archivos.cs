using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Kwik_E_Mart
{
   public static class Archivos
    {
        public static void CrearArchivoTxt(List<Venta> venta,string fileName)
        {
            try
            {
                string datetime = string.Concat(DateTime.Now.ToString("HH_mm_ss"));
                string filename = string.Concat(datetime, "_",fileName);
                //string ruteFile = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"\\", datetime);
                string ruteFile = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\", filename);

                using (StreamWriter auxSW = new StreamWriter(ruteFile,true))
                {
                    auxSW.WriteLine($"Compra del dia: {datetime}");
                    auxSW.WriteLine("---------------------------");
                    foreach (Venta v in venta)
                    {
                        auxSW.WriteLine(v.ToString());
                    }
                    auxSW.WriteLine("---------------------------");
                    auxSW.WriteLine("GRACIAS VUELVA PRONTO");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string LeerArchivoTxt(string fileName)
        {
            try
            {
                string infoLeida = "";
                //string ruteFile = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "\\", fileName);
                string ruteFile = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\", fileName);

                if (File.Exists(ruteFile))
                {
                    using (StreamReader auxSR = new StreamReader(ruteFile))
                    {
                        string lineaLeida = string.Empty;

                        while ((lineaLeida = auxSR.ReadLine()) != null)
                        {
                            infoLeida += string.Concat(lineaLeida, "\n");
                        }
                    }
                }
                return infoLeida;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void CrearArchivoXml(string fileName, object ob)
        {//El objeto a pasar a Xml tiene que tener la etiqueta [Serializable] arriba de la clase
            try
            {
                string ruteFile = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "\\", fileName);

                using (XmlTextWriter auxArchivo = new XmlTextWriter(ruteFile, Encoding.UTF8) )
                {
                    XmlSerializer auxEscritor = new XmlSerializer(typeof(object));

                    auxEscritor.Serialize(auxArchivo, ob);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void LeerArchivoXml(string fileName, object ob)
        {//El objeto a pasar a Xml tiene que tener la etiqueta [Serializable] arriba de la clase
            try
            {
                string ruteFile = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "\\", fileName);

                using (XmlTextReader auxArchivoALeer = new XmlTextReader(ruteFile))
                {
                    XmlSerializer auxLector = new XmlSerializer(typeof(object));

                    ob = (Object)auxLector.Deserialize(auxArchivoALeer);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
