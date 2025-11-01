using System;
using System.Collections.Generic;

namespace Yugioh
{
    class Mazos
    {
        public static List<Carta> CrearCartas()
        {
            List<Carta> Cartas = new List<Carta>();

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

            Carta c4 = new Carta();

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

            Cartas.Add(c1);
            Cartas.Add(c2);
            Cartas.Add(c3);
            Cartas.Add(c4);
            Cartas.Add(c5);
            Cartas.Add(c6);

            return Cartas;   

        }
    }
}