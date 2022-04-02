//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            //var train = new Train("1");
            //train.StartEngines();
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 10000000; i++)
            {
                Train train = new Train("1");
            }
            //Lo que sucedera es que en algun momento dejara de contar, ya que llego a su maximo.

            Train t1 = new Train("Last train to London");
            Train t2 = new Train("Last train to London");
            Train t3 = new Train("Runaway");

        }
    }
}