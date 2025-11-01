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


            Carta c7 = new Carta();
            c7.name = "Baby Dragon";
            c7.daño = 1200;
            c7.defensa = 700;
            c7.nivel = 3;
            c7.descripcion = "Dragón bebé";

            Carta c8 = new Carta();
            c8.name = "Mushroom Man";
            c8.daño = 800;
            c8.defensa = 600;
            c8.nivel = 2;
            c8.descripcion = "Hombre hongo";

            Carta c9 = new Carta();
            c9.name = "Baby Dragon";
            c9.daño = 1200;
            c9.defensa = 700;
            c9.nivel = 3;
            c9.descripcion = "Dragón bebé";

            Carta c10 = new Carta();
            c10.name = "Baby Dragon";
            c10.daño = 1200;
            c10.defensa = 700;
            c10.nivel = 3;
            c10.descripcion = "Dragón bebé";

             Carta c11 = new Carta();
            c11.name = "Tyhone";
            c11.daño = 1200;
            c11.defensa = 1400;
            c11.nivel = 4;
            c11.descripcion = "Águila tyhone";

             Carta c12 = new Carta();
            c12.name = "Shadow Specter";
            c12.daño = 500;
            c12.defensa = 200;
            c12.nivel = 1;
            c12.descripcion = "Espectro sombra";

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