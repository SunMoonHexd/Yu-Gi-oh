using System;
using System.Collections.Generic;
using Yugioh;

class Program
{
    public static void Main()
    {
        List<Carta> Cartas = Mazos.CrearCartas();
        Console.WriteLine("----------------ATK Y DEF----------------");
        Cartas[10].Defiende();
        Cartas[10].Ataque();
        MostrarInfo(10, Cartas);
        
    }

    public static void MostrarInfo(int i, List<Carta> Cartas)
    {
        if (i < 0 || i > Cartas.Count())
        {
            Console.WriteLine("El indice de la carta no existe.");
        }
        else
        {
            Console.WriteLine("----------------Información----------------");
            Console.WriteLine($"El nomrbe de la carta es: {Cartas[i].name} ");
            Console.WriteLine($"El ATK de la carta es: {Cartas[i].daño} ");
            Console.WriteLine($"La DEF de la carta es: {Cartas[i].defensa} ");
            Console.WriteLine($"El LV de la carta es: {Cartas[i].nivel} ");
            Console.WriteLine($"La descripción de la carta es: {Cartas[i].descripcion} ");   
        }
    }

    
}