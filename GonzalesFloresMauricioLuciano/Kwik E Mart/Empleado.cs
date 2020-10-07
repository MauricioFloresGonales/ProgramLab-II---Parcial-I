using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Empleado : Persona
    {
        int horasDiarias;
        float salario;

        public Empleado(string nombre, string apellido, int horas, float salario) : base(nombre, apellido)
        {
            this.horasDiarias = horas;
            this.salario = salario;
        }


    }
}
