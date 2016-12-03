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
        public override string Print()
        {
            string temp = null;
            if (arrayA != null)
            {
                //SortCars [] test_obj = new SortCars[sizeA];
                SortCars test_obj = arrayA[0] as SortCars;
                if (test_obj != null)
                {
                    temp = "\n[\n ";
                    for (int i = 0; i < sizeA; i++)
                    {
                        test_obj = arrayA[i] as SortCars;
                        temp += test_obj.Print() + "\n";
                    }
                    temp += "]\n";
                }
                else
                {
                    temp = "\n[ ";
                    foreach (var item in arrayA)
                    {
                        temp += item.ToString() + " ";
                    }
                    temp += "]\n";
                }
            }
            return temp;
        }
    }
}
