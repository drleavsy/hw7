using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class InsertionSort<T> : Sorter<T> where T : IComparable<T>
    {
        public InsertionSort(T [] TArray)
        {
            arrayA = TArray;
            sizeA = TArray.Length;
            swapCounter = 0;
            ind1 = 0; // start sorting from thr 1st element
            ind2 = 0; // start comparison from the 2nd element
        }

        public override string Print()
        {
            Console.Write("[ ");
            foreach (var item in arrayA)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("]");
            return "0";
        }

        public override void Sort()
        {
            while (ind2 < sizeA)
            {
                ind1 = ind2;
                ind2++;
                while (ind1 >= 0 && swapArr(arrayA, sizeA, ind1, ind2))
                {
                    ind1--;
                    ind2--;
                }
            }
            Console.Write("Insertion sorted array:   ");
            Print();
            Console.WriteLine("Press ENTER to quit");
            Console.Read();
        }

        public override bool swapArr(T [] arrayIn, int sizeIn, int inx1, int inx2)
        {
            T temp1;
            T temp2;

            if (inx1 < sizeIn && inx2 < sizeIn) // check if index is array 
            {
                if (arrayA[ind1].CompareTo(arrayA[ind2]) > 0)
                {
                    temp1 = arrayIn[inx1];
                    temp2 = arrayIn[inx2];
                    arrayIn[inx1] = temp2;
                    arrayIn[inx2] = temp1;
                    return true;
                }
            }
            else                              // if 2nd element is greater than 1st one: return false, no swap
            {
                return false;
            }
            return false;
        }
    }
}
