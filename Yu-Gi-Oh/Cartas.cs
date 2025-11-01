using System;
using System.Collections.Generic;

namespace Yugioh
{
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


    private string descp;
    public string descripcion
    {
        get { return descp; }
        set
        {
            if (value.Length > 40)
            {
                descp= "";
            }
            else
            {
                descp = value;
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
}