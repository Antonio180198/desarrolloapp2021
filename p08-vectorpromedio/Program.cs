﻿using System;

namespace p08_vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]vector={10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100};
            int suma=0,  nmp=0;
            float promedio=0.0f;
            suma =nmp =0;
            promedio=0.0f;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]  }");
                suma=suma+vector[i];
            }
            promedio=suma/vector.Length;
            Console.WriteLine($"\nLa suma es {suma} y el promedio es {promedio}\n\n");
            for (int i = 0; i < vector.Length; i++){
                if(vector[i]>promedio){
                    Console.Write($"{vector [i] } ");
                    nmp++;
                }
            }
            Console.WriteLine($"\nTotal de numeros mayores que el promedio {nmp}");
        }
    }
}
