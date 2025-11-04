using System;
using System.Collections.Generic;

namespace Yugioh
{
    public class Carta
    {
        List<string> tipoDeMounstro = new List<string>() { };
        List<string> Atributo = new List<string>() { "oscuridad", "luz", "tierra", "agua", "fuego", "viento" };
        private string nombre;
        public string name
        {
            get { return nombre; }
            set
            {
                if (value.Length > 30)
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
                if (value.Length > 100)
                {
                    descp = "";
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
        public void Ataque()
        {
            Console.WriteLine($"El monstruo {nombre} atacara con {ATK} puntos");
        }
        public void CambiarModo()
        {
            if (modo == "ataque")
            {
                modo = "defensa";
                Console.WriteLine($"La carta {nombre} fue colocada en {modo}");
            }
            else if (modo == "defensa")
            {
                modo = "ataque";
                Console.WriteLine($"La carta {nombre} fue colocada en {modo}");
            }
        }
        public void MostrarInfo()
        {
            Console.WriteLine("----------------Información----------------");
            Console.WriteLine($"El nomrbe de la carta es: {nombre} ");
            Console.WriteLine($"El ATK de la carta es: {ATK} ");
            Console.WriteLine($"La DEF de la carta es: {DEF} ");
            Console.WriteLine($"El LV de la carta es: {LV} ");
            Console.WriteLine($"La descripción de la carta es: {descp} ");
            Console.WriteLine($"El modo de la carta es : {modo} ");
        }

        public Carta()
        {
            nombre = "";
            defensa = 0;
            daño = 0;
            nivel = 0;
            descripcion = "";
            modo = "ataque";
        }
        public Carta(string nom, int atk, int def, int niv, string descrip)
        {
            name = nom;
            daño = atk;
            defensa = def;
            nivel = niv;
            descripcion = descrip;
            modo = "ataque";
        }
        
    }
}