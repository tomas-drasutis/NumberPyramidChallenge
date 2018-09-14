using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PyramidParser pyramidParser = new PyramidParser();
            PathFinder pathFinder = new PathFinder();

            int[,] pyramid = pyramidParser.readInput(@"D:\CODING\C#\Challenge\Challenge\pyramid2.txt");
            Console.WriteLine(pathFinder.getMaxSum(pyramid, pyramid.GetLength(0)));
        }
    
    }
}

