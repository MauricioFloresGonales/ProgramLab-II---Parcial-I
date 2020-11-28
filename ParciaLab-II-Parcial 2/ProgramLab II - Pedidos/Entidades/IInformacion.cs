using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInformacion
    {
        int Id { get; }
        string TipoDeClase { get; }
        int precioFinalAsumar { get; }
        string InformacionDelProducto();
    }
}
