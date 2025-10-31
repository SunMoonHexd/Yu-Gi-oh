using System;
using System.Collections.Generic;

class Carta
{
    List<string> tipoDeMounstro = new List<string>() { };
    List<string> Atributo = new List<string>() { "oscuridad", "luz", "tierra", "agua", "fuego", "viento" };
    private string nombre;

    public string name
    {
        get { return nombre; }
        set
        {
            if (value.Length > 20)
            {
                nombre = "";
            }
            else
            {
                nombre = value;
            }
        }
    }
    private int ATK;

    public int daño
    {
        
        get { return ATK; }
        set
        {
            if (value < 0)
            {
                ATK = 0; 
            }
            else
            {
                ATK = value;
            }
        }
    }
    private int DEF;
    public int defensa
    {
        get { return DEF; }
        set
        {
            if (value < 0)
            {
                DEF = 0;
            }
            else
            {
                DEF = value;
            }
        }
    }


    private string dsc;
    public string descripcion
    {
        get { return dsc; }
        set
        {
            if (value.Length > 40)
            {
                dsc = "";
            }
            else
            {
                dsc = value;
            }
        }
    }
    private int LV;

    public int nivel
    {
        get { return LV; }
        set
        {
            if (value < 0)
            {
                LV = 0;
            }
            else
            {
                LV = value;
            }
        }
    }
    private string modo = "ataque";

    public void Defiende()
    {
        Console.WriteLine($"El monstruo {nombre} defenderá con {DEF} puntos");
    }

    public void CambiarModo(string nuevoModo)
    {
        if (nuevoModo.ToLower() == "ataque")
        {
            modo = "ataque";
            Console.WriteLine($"La carta {nombre} fue colocada en ataque");
        }
        else if (nuevoModo.ToLower() == "defensa")
        {
            modo = "defensa";
            Console.WriteLine($"La carta {nombre} fue colocada en defensa");
        }
    }

}


class Program
{
    public static void Main()
    {
        Carta c1 = new Carta();
        c1.name = "Mago Oscuro";
        c1.daño = 2500;
        c1.defensa = 2100;
        c1.nivel = 7;
        c1.descripcion = "hechicero que usa magia de corte oscuro y prohibido, a veces para invocar entidades o lanzar maldiciones";

        Carta c2 = new Carta();
        c2.name = "Dragón Blanco de Ojos Azules";
        c2.daño = 3000;
        c2.defensa = 2500;
        c2.nivel = 8;
        c2.descripcion = "Es una criatura legendaria de un poder destructivo casi invencible";

        Carta c3 = new Carta();
        c3.name = "Cráneo Invocado";
        c3.daño = 2500;
        c3.defensa = 1200;
        c3.nivel = 6;
        c3.descripcion = "Un demonio con un ataque formidable.";

        Carta c5 = new Carta();
        c5.name = "Celtic Guardian";
        c5.daño = 1400;
        c5.defensa = 1200;
        c5.nivel = 4;
        c5.descripcion = "Un elfo valiente que protege los bosques con su espada.";

        Carta c6 = new Carta();
        c6.name = "Kuriboh";
        c6.daño = 300;
        c6.defensa = 200;
        c6.nivel = 1;
        c6.descripcion = "Un pequeño monstruo peludo que puede salvarte en el momento justo.";

    }

    public static void MostrarInfo()
    {
        
    }   
    
}