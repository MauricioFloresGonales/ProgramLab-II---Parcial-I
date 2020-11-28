using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public enum ETipo{
        Vegetariana,
        NoVegetariana,
        SinVerduras,
        SinDiscriminar
    }
    public class Comida : Producto, IInformacion
    {
        int id;
        ETipo tipo;
        bool condimentos;

        #region"Get-Set"
        public int Id
        {
            get { return id; }
        }
        public string Tipo
        {
            get
            {
                switch (tipo)
                {
                    case ETipo.Vegetariana:
                        return "vegetariana ";
                    case ETipo.NoVegetariana:
                        return "no vegetariana";
                    case ETipo.SinVerduras:
                        return "sin verduras";
                    default:
                        return "sin tipo de comida";
                }
            }
        }
        public string Condimentos
        {
            get
            {
                if (condimentos == true)
                    return "SI";
                else
                    return "NO";
            }
        }
        #endregion

        #region"Contrutores"
        public Comida():base()
        {
            this.id = 0;
            this.tipo = ETipo.SinDiscriminar;
            this.condimentos = true;
        }
        public Comida(string nombre, int precio, ETipo tipo, bool condimentos) : base(nombre, precio)
        {
            this.tipo = tipo;
            this.condimentos = condimentos;
        }
        public Comida(int id, string nombre, int precio, ETipo tipo, bool condimentos) : this(nombre, precio, tipo, condimentos)
        {
            this.id = id;
        }
        #endregion

        #region"Validadores"
        public static ETipo ValidarTipo(string nombre)
        {
            string palabraAux = Validador.SacarEspaciosDeMas(nombre);
            switch (palabraAux)
            {
                case "Vegetariana ":
                    return ETipo.Vegetariana;
                case "no vegetariana":
                    return ETipo.NoVegetariana;
                case "sin verduras":
                    return ETipo.SinVerduras;
                default:
                    return ETipo.SinDiscriminar;
            }
        }
        public static bool ValidarCondimento(string axu)
        {
            string palabraAux = Validador.SacarEspaciosDeMas(axu);
            switch (palabraAux)
            {
                case "false ":
                    return false;
                default:
                    return true;
            }
        }
        #endregion

        #region"Interface"
        public int precioFinalAsumar
        {
            get { return Precio; }
        }
        public string TipoDeClase { get { return "comida"; } }
        public string InformacionDelProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Plato: {Nombre} Tipo: {Tipo} Condimentos: {Condimentos} Precio {Precio}");

            return sb.ToString();
        }
        #endregion
    }
}
