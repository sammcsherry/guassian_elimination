using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
    public static class Guassian_Elimination_Algorithm
    {
        public static Guassian_Matrix guassian_elimination_r(Guassian_Matrix matrix, int current_row, int coefficient_index, int increment)
        {
            if (increment == -1 && at_start(matrix.size, current_row))
                return matrix;

            if (increment == 1)
                if(matrix.values[current_row][coefficient_index] != 0)
                 make_coefficient_pivot(matrix.values[current_row], coefficient_index);
// Given this is C are you sure this will work as intended - consdier adding brackets
            if (matrix.values[current_row][coefficient_index] == 1 && matrix.values[current_row + increment][coefficient_index] != 0)
                eliminate_coefficient(matrix, current_row, current_row + increment, coefficient_index, increment);

            if (at_end(matrix.size, current_row))
                increment = -1;

            current_row += increment;
            coefficient_index += increment;
            
            return guassian_elimination_r(matrix, current_row, coefficient_index, increment);
        }

        static bool at_end(int size, int current_row)
        {
            if (current_row == size - 1)
                return true;
            return false;
        }
        static bool at_start(int size, int current_row)
        {
            if (current_row == 0)
                return true;
            return false;
        }
        public static Guassian_Matrix eliminate_coefficient(Guassian_Matrix matrix, int base_row, int row_to_eliminate_index, int current_coefficient, int increment)
        {
            if (row_to_eliminate_index == matrix.size ||row_to_eliminate_index < 0)
                return matrix;
            eliminate_coefficient_from_row(matrix.values[base_row], matrix.values[row_to_eliminate_index], current_coefficient);
            row_to_eliminate_index+=increment;
            return eliminate_coefficient(matrix, base_row, row_to_eliminate_index, current_coefficient, increment);
        }

        public static double[] make_coefficient_pivot(double[] row, int coefficient_index)
        {
            double factor = 1 / row[coefficient_index];
            //Console.WriteLine(factor);
            return mathematical_functions.zip_scalar_array(row, factor);
        }
        public static double[] eliminate_coefficient_from_row(double[] base_row, double[] row_to_eliminate, int coefficient_index)
        {
            double factor = row_to_eliminate[coefficient_index] / base_row[coefficient_index];
            base_row = mathematical_functions.zip_scalar_array(base_row, factor);
            row_to_eliminate = mathematical_functions.zip_subtract_arrays(row_to_eliminate, base_row);
            base_row = mathematical_functions.zip_scalar_array(base_row, 1 / factor);
            return row_to_eliminate;

        }
    }
}
