using System;
using System.Collections.Generic;
using Yugioh;

class Program
{
    public static void Main()
    {
        List<Carta> Cartas = Mazos.CrearCartas();
        Console.WriteLine("----------------ATK Y DEF----------------");
        Cartas[3].Defiende();
        Cartas[3].Ataque();
        Cartas[3].CambiarModo();
        Cartas[3].MostrarInfo();
        
    }  
}