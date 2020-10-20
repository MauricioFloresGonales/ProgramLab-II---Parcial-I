using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Empleado : Persona
    {
        public enum EUsuarios
        {
            Apu, mauricio
        }
        EUsuarios usuarios;
        int horasDiarias;
        float salario;

        public EUsuarios Usuario
        {
            get { return this.usuarios; }
        }
        public Empleado(string nombre, string apellido, int horas, float salario, EUsuarios usuario) : base(nombre, apellido)
        {
            this.horasDiarias = horas;
            this.salario = salario;
            this.usuarios = usuario;
        }

        public static bool operator == (Empleado empleadoUno, string nombre)
        {
            if(empleadoUno.nombre == nombre)
            return true;
            else
                return false;
        }
        public static bool operator !=(Empleado empleadoUno, string nombre)
        {
            return !(empleadoUno == nombre);
        }

        public bool contrasenias(EUsuarios usuarios, string contrasenia)
        {
            bool retorno;
            switch (usuarios)
            {
                case EUsuarios.Apu:
                    retorno = Validaciones.stringIsEqual(contrasenia, "Nahasapeemapetilon");
                    break;
                case EUsuarios.mauricio:
                    retorno = Validaciones.stringIsEqual(contrasenia, "123");
                    break;
                default:
                    retorno = false;
                    break;
            }
            return retorno;
        }
    }
}
