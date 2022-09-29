﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aerolinea
    {
        public static List<Vendedor> Vendedores = new List<Vendedor>();
        public static List<Avion> aviones = new List<Avion>();
        public static List<Vuelo> vuelos = new List<Vuelo>();
        public static bool modoOscuro = false;
        public static List<Vuelo> vuelosFinalizados = new List<Vuelo>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static int ConseguirIndex(string matricula)
        {
            for (int i = 0; i < aviones.Count; i++)
            {
                if (matricula == aviones[i].Matricula)
                {
                    return i;
                }
            }
            return -1;
        }

        public static float CalcularRecaudacionTotal()
        {
            float retorno=0;
            if (vuelos.Count > 0)
            {
                foreach(Vuelo vuelo in vuelos)
                {
                    retorno += vuelo.Recaudacion;
                }
            }
            if (vuelosFinalizados.Count > 0)
            {
                foreach(Vuelo vuelo in vuelosFinalizados)
                {
                    retorno += vuelo.Recaudacion;
                }
            }

            return retorno;
        }

    }
}
