using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Yugioh
{
    public class Duelo
    {
        public static void IniciarDuelo(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine($"El duelo entre {jugador1.nombreJugador} y {jugador2.nombreJugador} ha comenzado"); // debes acceder a la propiedad xd.
            Carta carta1 = ElegirCarta(jugador1);
            Carta carta2 = ElegirCarta(jugador2);
        }

        public static Carta ElegirCarta(Jugador jugadorEligido)
        {
            Console.WriteLine($"{jugadorEligido.nombreJugador}!, debes eligir una carta.");
            bool activador = true;
            Carta jugadorSeleccion = null;
            while (activador)
            {
                for(int i = 0; i< jugadorEligido.Mazo.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {jugadorEligido.Mazo[i].name}.");
                }
                if (int.TryParse(Console.ReadLine(), out int op))
                {
                    if (op >= 1 && op <= jugadorEligido.Mazo.Count)
                    {
                        jugadorSeleccion = jugadorEligido.Mazo[op - 1];
                        Console.WriteLine($"El jugador {jugadorEligido.nombreJugador} ha eligido a {jugadorSeleccion.name}");
                        activador = false;
                    }
                    else
                    {
                        Console.WriteLine("Tu elección esta fuera de rango.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                }
            }
            return jugadorSeleccion;
        }
    }
}