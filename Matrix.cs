using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
	public class Guassian_Matrix
	{
		public double[][] values;
		public int size;
		public Guassian_Matrix(int size)
		{
			this.size = size;
			values = new double[size][];
		}

		public double[][] fill_matrix()
        {
			double[] row_1 = new double[] { 1.0, 3.0, 4.0, 6.8, 5.0};
			double[] row_2 = new double[] { 6.0, 7.0, 8.0, 8.9, 9.0 };
			double[] row_3 = new double[] { 17.0, 111.0, 122.0, 1.8, 13.0 };
			double[] row_4 = new double[] { 782.0, 786.0, 999.0, 89.8, 99.0 };

			values[0] = row_1;
			values[1] = row_2;
			values[2] = row_3;
			values[3] = row_4;
			return values;
        }
	}
}
