﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota_Final_del_Computo_1_y_2___tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());//8
            Console.WriteLine("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());//9
            Console.WriteLine("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine());//7

            //8*30%= 2.4
            //9*30%= 2.7
            //7*40%= 2.8
            //C1   = 7.9

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.WriteLine("Lab1: ");
            lab1 = double.Parse(Console.ReadLine());//8

            Console.WriteLine("Lab2: ");
            lab2 = double.Parse(Console.ReadLine());//9

            Console.WriteLine("Parcial1: ");
            parcial1 = double.Parse(Console.ReadLine());//7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0} ", c2);

            //Obtener la nota final por computo y Nota final de la materia de programacion 1

            //Pausa
            Console.ReadLine();

        }
    }
}
