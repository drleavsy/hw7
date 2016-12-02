using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class BubbleSorter<T> : Sorter<T> where T: IComparable<T> 
    {
        private int ind_last;
        public BubbleSorter(T[] TArray)
        {
            arrayA = TArray;
            sizeA = TArray.Length;
            swapCounter = 0;
            ind1 = 0; // start sorting from thr 1st element
            ind2 = 1; // start comparison from the 2nd element
            ind_last = 0;
        }
/*
        public override void Print()
        {
            Console.Write("[ ");
            foreach (var item in arrayA)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("]");
        }
        */
        public override void Sort()
        {
            ind_last = sizeA + 1; // initilize last first sorted index for buble sort: index until which sorting is done, above this index array will be sorted

            while (swapCounter >= 0)
            {
                if (ind1 == ind_last || ind1 == sizeA) // if we compared all elements in the array, then we go to the beginning of the array 
                {                   // and start comparison cycle all over again
                    if (swapCounter == 0)  // if at the end of array there were no any swaps, then 
                    {
                        break;
                    }
                    ind_last = ind1 - 1; // set index to the last sorted index 
                                         // (- 1 because even after the index was already sorted, it is incremented in the end of while loop)
                    ind1 = 0;      // start comparison cycle from the beginning of the array,
                    ind2 = 1;       // meaning reset all indexes--
                    swapCounter = 0;
                }
                if (ind2 < ind_last && swapArr(arrayA, sizeA, ind1, ind2))
                {
                    swapCounter++;
                }
                ind1++;
                ind2++;
            }
        }

        public override bool swapArr(T [] arrayIn, int sizeIn, int inx1, int inx2)
        {
            T temp1;
            T temp2;

            if (inx1 < sizeIn && inx2 < sizeIn) // check if index is array 
            {
                if (arrayA[ind1].CompareTo(arrayA[ind2]) > 0) {
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
        public override string Print()
        {
            string temp = null;
            if (arrayA != null)
            {
                //SortCars [] test_obj = new SortCars[sizeA];
                SortCars test_obj = arrayA[0] as SortCars;
                if (test_obj != null)
                {
                    Console.Write("[\n ");
                    for (int i = 0; i < sizeA; i++)
                    {
                        test_obj = arrayA[i] as SortCars;
                        temp += test_obj.Print() + "\n";
                    }
                    Console.WriteLine("]");
                }
            }
            else {
                Console.Write("[ ");
                foreach (var item in arrayA)
                {
                    temp += item.ToString() + " ";
                }
                Console.WriteLine("]");
            }
            return temp;
        }
    }
}
