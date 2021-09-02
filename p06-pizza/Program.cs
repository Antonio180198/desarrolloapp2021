using System;
using static System.Console;

namespace p06_pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub, lug;
            string[] ings;

            string tamaño, cubierta, lugar;
            string ingredientes="";

            if(args.Length<3){
                Menu();
                return 1;
            }
            //tamaño
            tam = char.Parse(args[0].ToUpper());
            if(tam=='P') tamaño="Pequeña";
            else if(tam=='M') tamaño="Mediana";
            else tamaño="Grande";

            //ingredientes
            ings = args[1].Split("+");
            foreach (string i in ings){
                switch (char.Parse(i.ToUpper()))
                {
                    case 'C': ingredientes += "Chapiñones"; break;
                    case 'E': ingredientes += "extraqueso"; break;
                    case 'P': ingredientes += "piña"; break;
                    case 'T': ingredientes += "Tomates"; break;
                }
            }
            //cubierta
            cub = char.Parse(args[2].ToUpper());
            if(cub=='D') cubierta = "Delgada"; else cubierta="Gruesa"; 
            //Lugar
            lug = char.Parse(args[3].ToUpper());
            lugar = (lug=='A' ? "Aqui" : "Llevar");

            WriteLine("Tu piazza es de tamano: {0}", tamaño);
            WriteLine("Ingredientes: {0}", ingredientes);
            WriteLine("Cubierta: {0}", cubierta);
            WriteLine("Lugar: {0}", lugar);
            return 0;
        }
        static void Menu(){
            Clear();
            WriteLine("Tamaño: P - Pequeña, M - Mediana, G - Grande");
            WriteLine("Ingrdientes: C hapinñones + E xtra queso + C lavos + T omates");
            WriteLine("Cubierta: (D)elgada , (G)ruesa ");
            WriteLine("Donde: (A)qui , (L)levar ");
        }
    }
}
