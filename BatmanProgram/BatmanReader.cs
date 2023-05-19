using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanProgram
{
    /// <summary>
    /// Permet de lire le nombre d'un mot dans un fichier
    /// </summary>
    public class BatmanReader
    {
        private long nbDeBatman = 0;
        /// <summary>
        /// Renvoie le nombre de batman
        /// </summary>
        public long getNbDeBatman
        {
            get => nbDeBatman;
        }

        /// <summary>
        /// Compte le nombre d'itération d'une lettre dans un fichier
        /// </summary>
        public BatmanReader(string path, char letter) 
        {
            // Compte le nombre de batman dans le fichier
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            long nbBatman = 0;
            while (line != null)
            {
                nbBatman += line.Count(f => (f == letter));
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
