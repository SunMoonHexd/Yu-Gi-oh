using System;
using System.Collections.Generic;
namespace Yugioh
{
    public class Jugador
    {
        private string namePlayer = "";
        private int HP = 8000;
        private List<Carta> mazoPlayer;

        public string nombreJugador
        {
            get { return namePlayer; }
            set
            {
                if (value.Length > 20)
                {
                    namePlayer = "";
                }
                else
                {
                    namePlayer = value;
                }
            }
        }

        public int Vida
        {
            get { return HP; }
            set
            {
                if (value < 0)
                {
                    HP = 0;
                }
                else
                {
                    HP = value;
                }
            }
        }

        public List<Carta> Mazo
        {
            get { return mazoPlayer; }
            set
            {
                if (value == null)
                {
                    mazoPlayer = new List<Carta>();
                }
                else
                {
                    mazoPlayer = value;
                }
            }
        }

        public List<Carta> Mano { get; set; } = new List<Carta>();

        public List<Carta> Campo { get; set; } = new List<Carta>();

        public Jugador(string nom, List<Carta> Maz)
        {
            nombreJugador = nom;
            Mazo = Maz ?? new List<Carta>();
            Mano = new List<Carta>();
            Campo = new List<Carta>();
        }

        public void MostrarJugador()
        {
            Console.WriteLine($"El jugador es {nombreJugador}");
            Console.WriteLine($"La vida del jugador es {Vida}");
            Console.WriteLine($"El mazo tiene {Mazo.Count} cartas");
        }

    }
}