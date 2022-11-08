using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
    public static class Guassian_Operators
    {
        public static void swap_rows(Double[] row_1, Double[] row_2)
        {
            int vector_size = row_1.Length;
            Double[] temp = new Double[vector_size];
            temp = row_2;
            row_2 = row_1;
            row_1 = temp;
        }

        public static Double[] multiply_row(Double[] row, Double scalar)
        {
            return mathematical_functions.zip_scalar_array(row, scalar);
        }

        public static Double[] subtract_arrays(Double[] row_1, Double[] row_2)
        {
            return mathematical_functions.zip_subtract_arrays(row_1, row_2);
        }
    }
}
