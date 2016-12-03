using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public abstract class Sorter<T> : ISorter<T> 
    {
        protected T [] arrayA; // initialize array
        protected int sizeA;
        protected int swapCounter;
        protected int ind1; // start sorting from thr 1st element
        protected int ind2; // start comparison from the 2nd element

        public abstract bool swapArr(T [] arrayNew, int sizeIn, int inx1, int inx2);
        public abstract string Print();
        public abstract void Sort();
    }
}
