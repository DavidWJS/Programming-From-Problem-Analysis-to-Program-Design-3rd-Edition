using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Create three arrays of type double. Do a compile-time initialization and place 10
different values in two of the arrays.Write a program to store the product of the
two arrays in the third array. Produce a display using the MessageBox class that
shows the contents of all three arrays using a single line for an element from all
three arrays.*/

namespace ParallelArrayApp
{
    class ParallelArrayApp
    {
        static void Main(string[] args)
        {
            double[] array1 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,34};
            double[] array2 = new double[] { 23, 32, 14, 54, 23, 71, 234, 63, 91, 11 };
            double[] array3 = new double[Math.Max(array1.Length, array2.Length)];

            array3 = ProduceThirdArray(array1, array2);
            DisplayResults(array1, array2, array3);
        }
        //method assumes the two array of not the same size
        public static double[] ProduceThirdArray(double[] array1, double[] array2)
        {
            double[] array3 = new double[Math.Max(array1.Length, array2.Length)];
            int sizeOfSmallest;
            for (sizeOfSmallest = 0; sizeOfSmallest < Math.Min(array1.Length, array2.Length); sizeOfSmallest++)
            {
                array3[sizeOfSmallest] = array1[sizeOfSmallest] * array2[sizeOfSmallest];
            }
            if (array1.Length > array2.Length)
            {
                for (int i = sizeOfSmallest; i < array3.Length; i++)
                {
                    array3[i] = array1[i] * 1;
                }
            }
            else
            {
                if (array2.Length > array1.Length)
                {
                    for (int i = sizeOfSmallest; i < array3.Length; i++)
                    {
                        array3[i] = array2[i] * 1;
                    }
                }
            }
                return array3;
            }
        public static void DisplayResults(double[] array1, double[] array2, double[] array3)
        {
            string output;
            int sizeOfSmallest;

            output = "Array1 * Array2 = Array3\n\n";
            output += "Array1" + "\tArray2" + "\tArray3\n";
            for(sizeOfSmallest = 0; sizeOfSmallest < Math.Min(array1.Length, array2.Length); sizeOfSmallest++)
            {
                output += array1[sizeOfSmallest] + "\t" + array2[sizeOfSmallest] + "\t" + array3[sizeOfSmallest] + "\n";
                if (array1.Length > array2.Length)
                {
                    for (int i = sizeOfSmallest; i < array3.Length; i++)
                    {
                        output += array1[i] + "\t\t" + array3[i] + "\n";
                    }
                }
                else
                {
                    if (array2.Length > array1.Length)
                    {
                        for (int i = sizeOfSmallest; i < array3.Length; i++)
                        {
                            output += array2[i] + "\t\t" + array3[i] + "\n";
                        }
                    }
                }
            }
            MessageBox.Show(output, "Parallel Arrays");
        }
    }
}
