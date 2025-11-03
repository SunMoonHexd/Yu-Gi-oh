using System;
using System.Collections.Generic;

namespace Yugioh
{
    class Mazos
    {
        public static List<Carta> CrearCartas()
        {
            List<Carta> Cartas = new List<Carta>();

            Carta c1 = new Carta("Mago Oscuro", 2500, 2100, 7, "hechicero que usa magia de corte oscuro y prohibido, a veces para invocar entidades o lanzar maldiciones");

            Carta c2 = new Carta("Dragón Blanco de Ojos Azules", 3000, 2500, 8, "Es una criatura legendaria de un poder destructivo casi invencible");

            Carta c3 = new Carta("Cráneo Invocado", 2500 , 1200 , 6 , "Un demonio con un ataque formidable.");

            Carta c4 = new Carta("C MAX",500,200,2,"es un tipo de carta conocida como trampa de mano: una carta que puedes activar desde tu mano durante el turno de tu oponente");

            Carta c5 = new Carta("Celtic Guardian",1400,1200,4,"Un elfo valiente que protege los bosques con su espada.");

            Carta c6 = new Carta("Kuriboh",300,200,1,"Un pequeño monstruo peludo que puede salvarte en el momento justo.");

            Carta c7 = new Carta("Baby Dragon",1200,700,3,"Dragón bebé");

            Carta c8 = new Carta("Mushroom Man", 800, 600, 2, "Hombre hongo");

            Carta c9 = new Carta("Exodia el Prohibido",1000,1000,3,"Pieza del legendario Exodia");

            Carta c10 = new Carta("Jinzo",2400,1500,6,"Androide que niega las trampas");

            Carta c11 = new Carta("Tyhone",1200,1400,4,"Águila tyhone");

            Carta c12 = new Carta("Shadow Specter",500,200,1,"Espectro sombra");

            Cartas.Add(c1);
            Cartas.Add(c2);
            Cartas.Add(c3);
            Cartas.Add(c4);
            Cartas.Add(c5);
            Cartas.Add(c6);
            Cartas.Add(c7);
            Cartas.Add(c8);
            Cartas.Add(c9);
            Cartas.Add(c10);
            Cartas.Add(c11);
            Cartas.Add(c12);

            return Cartas;   

        }
    }
}