using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class PyramidParser
    {
        public int[,] readInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader r = new StreamReader(filename);
            while ((line = r.ReadLine()) != null)
            {
                lines++;
            }

            int[,] pyramid = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    pyramid[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }
            r.Close();
            return pyramid;
        }
        public void printPyramid(int[,] pyramid)
        {
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int j = 0; j < pyramid.GetLength(0); j++)
                {
                    Console.Write(string.Format("{0} ", pyramid[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.WriteLine("###############################################");
        }
    }
}
