using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    interface IBuffer<T> : IPrintable
    {
        bool IsFull();
        bool IsEmpty();
        string Peek();
        //string Print();
    }
}
