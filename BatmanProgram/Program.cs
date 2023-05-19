using BatmanProgram;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyApp 
{
    /// <summary>
    /// Program qui créer le fichier batman de 1go
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string mot = "batman";

            // Créer le fichier batman
            GenerateFile batmanG = new GenerateFile(mot);            
        }
    }
}