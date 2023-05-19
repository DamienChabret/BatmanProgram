using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanProgram
{
    /// <summary>
    /// Génère un fichier
    /// </summary>
    public class GenerateFile
    {
        private int maxGO = 1; // Taille du fichier à atteindre
        private string mot = String.Empty; // Mot qui sera généré
        private string batman = String.Empty; // Chemin du fichier

        /// <summary>
        /// Chemin du fichier créer 
        /// </summary>
        public string BatmanPath
        {
            get => batman; 
        }

        /// <summary>
        /// Constructeur naturelle
        /// </summary>
        /// <param name="mot"> mot à écrire </param>
        public GenerateFile(string mot) 
        {
            this.mot = mot;
            this.batman = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/{this.mot}.txt";
            this.WriteInFile();
        }

        /// <summary>
        /// Ecrit dans le fichier
        /// </summary>
        public void WriteInFile()
        {
            StreamWriter batSignal = new StreamWriter(batman, true, Encoding.ASCII);
            // Tant que le fichier fait pas 1go, continuer à écrire dedans
            string batText = String.Empty;
            for (int i = 0; i < 1000; i++)
            {
                batText += mot;
            }

            // Récupère le poids du fichier
            long poidsDeBatman = getFileLenght();
            while (poidsDeBatman < maxGO)
            {
                batSignal.Write(batText);
                poidsDeBatman = getFileLenght();
            }
            batSignal.Close();
        }

        /// <summary>
        /// retourne le poid du fichier
        /// </summary>
        /// <returns> poids du fichier en GO </returns>
        private long getFileLenght()
        {
            return new FileInfo(batman).Length / 1_073_741_824; // taille en GO
        }
    }
}
