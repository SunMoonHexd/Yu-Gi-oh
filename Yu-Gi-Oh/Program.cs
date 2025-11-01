using System;
using System.Collections.Generic;
using Yugioh;

class Program
{
    public static void Main()
    {
        List<Carta> Cartas = Mazos.CrearCartas();
        Cartas[0].Defiende();
        
    }

    public static void MostrarInfo(Carta tarjeta)
    {
        
    }   
    
}