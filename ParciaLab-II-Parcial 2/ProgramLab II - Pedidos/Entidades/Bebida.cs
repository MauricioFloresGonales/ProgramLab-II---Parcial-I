using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public enum EGusto
    {
        ConGas,
        SinGas
    }
    public class Bebida: Producto, IInformacion
    {
        int id;
        EGusto gusto;

        #region"Get-Set"
        public int Id
        {
            get { return id; }
        }
        public string Gusto
        {
            get
            {
                switch (gusto)
                {
                    case EGusto.ConGas:
                        return "con gas";
                    case EGusto.SinGas:
                        return "sin gas";
                    default:
                        return "sin especificar";
                }
            }
        }
        #endregion

        #region"Contrutores"
        public Bebida():base()
        {
            this.id = 0;
            this.gusto = EGusto.ConGas;
        }
        public Bebida(string nombre, int precio, EGusto gusto) : base(nombre, precio)
        {
            this.gusto = gusto;
        }
        public Bebida(int id, string nombre,int precio, EGusto gusto):this(nombre, precio, gusto)
        {
            this.id = id;
        }
        #endregion

        #region"Interface"
        public int precioFinalAsumar
        {
            get { return Precio; }
        }
        public string TipoDeClase { get { return "bebida"; } }
        public string InformacionDelProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bebida: {Nombre} Con Gusto a: {Gusto} Precio {Precio}");

            return sb.ToString();
        }
        #endregion
        
        public static EGusto ValidadrGusto(string palabra)
        {
            string palabraAux = Validador.SacarEspaciosDeMas(palabra);
            switch (palabraAux)
            {
                case "con gas":
                    return EGusto.ConGas;
                default:
                    return EGusto.SinGas;
            }
        }
    }
}
