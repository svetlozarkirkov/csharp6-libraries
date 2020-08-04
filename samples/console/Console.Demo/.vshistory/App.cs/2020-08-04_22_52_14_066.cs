﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="">
//   
// </copyright>
// <summary>
//   Class App.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Console.Demo
{
    using System;
    using System.Net;

    using ML.Map.Core.Concrete;

    /// <summary>
    /// Class App.
    /// </summary>
    internal class App
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            var map = new ArrayMap<string, int>(12);
            Console.WriteLine(map);
        }
    }
}