using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Comida))]
    [XmlInclude(typeof(Bebida))]
    public abstract class Producto
    {
        string nombre;
        int precio;

        #region"Get-Set"
        public string Nombre
        {
            get { return nombre; }
        }
        public int Precio
        {
            get { return precio; }
        }
        #endregion

        #region"Contrutores"
        public Producto()
        {
            this.nombre = "";
            this.precio = 0;
        }
        public Producto(string nombre, int precio):this()
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        #endregion
    }
}
