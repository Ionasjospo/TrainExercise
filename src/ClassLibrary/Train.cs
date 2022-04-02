//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
      public class Train
    {
        /// <summary>
        /// Atributo que identifica a cada tren
        /// </summary>
        /// <value></value>
        private string identifier { get; set; }
        /// <summary>
        /// Contador que lo utilizamos en el constructor para saber cuantos
        /// trenes se han creado.
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Constructor de la clase Train.
        /// </summary>
        /// <param name="identificador">Es una string que diferencia a los trenes.</param>
        public Train(string identificador)
        {
            this.identifier = identificador;
            Console.WriteLine(count);
            count++;
        }



        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }


        /// <summary>
        /// Destructor o finalizador de la clase Train
        /// </summary>
        ~Train()
        {
            count--;
        }
    }
}