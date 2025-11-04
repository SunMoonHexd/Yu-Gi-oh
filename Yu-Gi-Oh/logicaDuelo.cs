using System;
using System.Collections.Generic;
namespace Yugioh
{
    public class Duelo
    {
        public static void IniciarDuelo(Jugador jugador1, Jugador jugador2)
        {
            Console.Clear();
            Console.WriteLine("════════════════════════════════════════════════");
            Console.WriteLine("       ¡¡¡ ¡¡DUEL!! ¡¡DUEL!! ¡¡¡");
            Console.WriteLine($"    {jugador1.nombreJugador}  VS  {jugador2.nombreJugador}");
            Console.WriteLine("════════════════════════════════════════════════\n");

         
            BarajarMazo(jugador1.Mazo);
            BarajarMazo(jugador2.Mazo);

            
            RobarCartasIniciales(jugador1);
            RobarCartasIniciales(jugador2);

            Jugador turnoActual = jugador1;
            Jugador oponente = jugador2;

            while (jugador1.Vida > 0 && jugador2.Vida > 0)
            {
                Console.Clear();
                MostrarEstado(jugador1, jugador2);
                RealizarTurno(turnoActual, oponente);

                
                (turnoActual, oponente) = (oponente, turnoActual);
            }

            MostrarGanador(jugador1.Vida > 0 ? jugador1 : jugador2);
        }

        static void BarajarMazo(List<Carta> mazo)
        {
            Random rnd = new Random();
            for (int i = mazo.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Carta temp = mazo[i];
                mazo[i] = mazo[j];
                mazo[j] = temp;
            }
        }

        static void RobarCartasIniciales(Jugador j)
        {
            for (int i = 0; i < 5 && j.Mazo.Count > 0; i++)
            {
                j.Mano.Add(j.Mazo[0]);
                j.Mazo.RemoveAt(0);
            }
        }

        static void MostrarEstado(Jugador j1, Jugador j2)
        {
            string linea = "═".PadRight(48, '═');
            Console.WriteLine($"╔{linea}╗");
            Console.WriteLine($"║ {j1.nombreJugador.PadRight(15)} | LP: {j1.Vida.ToString().PadLeft(4)} | Mano: {j1.Mano.Count} | Mazo: {j1.Mazo.Count} ║");
            Console.WriteLine($"║ Campo: {j1.Campo.Count} monstruos".PadRight(50) + "║");
            Console.WriteLine($"╠{linea}╣");
            Console.WriteLine($"║ {j2.nombreJugador.PadRight(15)} | LP: {j2.Vida.ToString().PadLeft(4)} | Mano: {j2.Mano.Count} | Mazo: {j2.Mazo.Count} ║");
            Console.WriteLine($"║ Campo: {j2.Campo.Count} monstruos".PadRight(50) + "║");
            Console.WriteLine($"╚{linea}╝\n");
        }
        static void RealizarTurno(Jugador actual, Jugador oponente)
        {
            Console.WriteLine($"\n--- TURNO DE {actual.nombreJugador.ToUpper()} ---");

            
            if (actual.Mazo.Count > 0)
            {
                Carta robada = actual.Mazo[0];
                actual.Mano.Add(robada);
                actual.Mazo.RemoveAt(0);
                Console.WriteLine($"Robaste: {robada.name}");
            }
            else
            {
                Console.WriteLine("¡No hay cartas en el mazo! Pierdes 1000 LP.");
                actual.Vida -= 1000;
                if (actual.Vida <= 0) return;
            }

            
            InvocarMonstruo(actual);
            Console.WriteLine("\nPresiona ENTER para pasar a la Batalla...");
            Console.ReadLine();

            
            if (actual.Campo.Count > 0)
            {
                Atacar(oponente, actual);
            }
            else
            {
                Console.WriteLine("No tienes monstruos para atacar.");
            }

            
            Console.WriteLine("Fin del turno. ENTER para continuar...");
            Console.ReadLine();
        }

        static void InvocarMonstruo(Jugador j)
        {
            if (j.Mano.Count == 0)
            {
                Console.WriteLine("No tienes cartas en mano.");
                return;
            }

            Console.WriteLine("\n¿Quieres invocar un monstruo? (s/n)");
            if (Console.ReadLine().ToLower() != "s") return;

            Console.WriteLine("Tus cartas:");
            for (int i = 0; i < j.Mano.Count; i++)
                Console.WriteLine($"{i + 1}. {j.Mano[i].name} (ATK: {j.Mano[i].daño} | DEF: {j.Mano[i].defensa})");

            if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= j.Mano.Count)
            {
                Carta c = j.Mano[idx - 1];
                Console.WriteLine($"¿En qué modo? (1=Ataque / 2=Defensa)");
                string modo = Console.ReadLine() == "2" ? "defensa" : "ataque";
                c.CambiarModo(); // Cambia si es defensa
                if (modo == "defensa") c.CambiarModo();

                j.Campo.Add(c);
                j.Mano.RemoveAt(idx - 1);
                Console.WriteLine($"¡{c.name} invocado en {modo}!");
            }
        }

        static void Atacar(Jugador defensor, Jugador atacante)
        {
            Console.WriteLine("\nElige tu monstruo para atacar:");
            for (int i = 0; i < atacante.Campo.Count; i++)
                Console.WriteLine($"{i + 1}. {atacante.Campo[i].name} ({atacante.Campo[i].daño})");

            if (!int.TryParse(Console.ReadLine(), out int atkIdx) || atkIdx < 1 || atkIdx > atacante.Campo.Count) return;

            Carta atacanteCarta = atacante.Campo[atkIdx - 1];

            if (defensor.Campo.Count == 0)
            {
                
                int daño = atacanteCarta.daño;
                defensor.Vida -= daño;
                Console.WriteLine($"¡ATAQUE DIRECTO! {defensor.nombreJugador} pierde {daño} LP.");
                return;
            }

            Console.WriteLine("Elige el monstruo enemigo a atacar:");
            for (int i = 0; i < defensor.Campo.Count; i++)
                Console.WriteLine($"{i + 1}. {defensor.Campo[i].name} ({defensor.Campo[i].defensa})");

            if (!int.TryParse(Console.ReadLine(), out int defIdx) || defIdx < 1 || defIdx > defensor.Campo.Count) return;

            Carta defensorCarta = defensor.Campo[defIdx - 1];

            // Cálculo de batalla
            if (atacanteCarta.daño > defensorCarta.defensa)
            {
                int daño = atacanteCarta.daño - defensorCarta.defensa;
                defensor.Vida -= daño;
                defensor.Campo.RemoveAt(defIdx - 1);
                Console.WriteLine($"¡{defensorCarta.name} destruido! {daño} de daño a LP.");
            }
            else if (atacanteCarta.daño < defensorCarta.defensa)
            {
                int daño = defensorCarta.defensa - atacanteCarta.daño;
                atacante.Vida -= daño;
                Console.WriteLine($"¡Contraataque! {atacante.nombreJugador} pierde {daño} LP.");
            }
            else
            {
                Console.WriteLine("¡Empate! Ambos monstruos destruidos.");
                atacante.Campo.RemoveAt(atkIdx - 1);
                defensor.Campo.RemoveAt(defIdx - 1);
            }
        }

        static void MostrarGanador(Jugador ganador)
        {
            Console.Clear();
            Console.WriteLine($"       ¡¡¡ {ganador.nombreJugador} GANA !!!");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}