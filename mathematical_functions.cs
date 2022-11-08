using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
    public static class mathematical_functions
    {
        public static Double[] zip_scalar_array(Double[] array, Double Scalar)
        {
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = array[i] * Scalar;
            }
            return array;
        }

        public static Double[] zip_subtract_arrays(Double[] array_1, Double[] array_2)
        {
            for (int i = 0; i < array_1.Length; i++)
            {
                array_1[i] = array_1[i] - array_2[i];
            }
            return array_1;
        }
    }
}
