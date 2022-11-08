using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
    class Program
    {
        static void Main(string[] args)
        {

            void init()
            {
                Guassian_Matrix matrix = new Guassian_Matrix(4);
                matrix.fill_matrix();
           
                
                Guassian_Elimination_Algorithm.guassian_elimination_r(matrix, 0, 0,1);
                foreach (double[] row in matrix.values)
                {
                    foreach (double element in row)
                    {
                        Console.Write(element + "  ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            init();
        }
    }
}
