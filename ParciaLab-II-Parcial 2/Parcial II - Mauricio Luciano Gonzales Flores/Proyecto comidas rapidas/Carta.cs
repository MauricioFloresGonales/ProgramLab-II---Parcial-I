﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_comidas_rapidas
{
    public static class Carta
    {
        static List<Comida> listaDeComidas;

        static Carta()
        {
            listaDeComidas = DB.GetComidas();
        }
        public static void Iniciar()
        {

        }
    }
}
