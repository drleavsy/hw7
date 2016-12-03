using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    interface IMyStack<T> : IBuffer<T>
    {
        void Push(T newTop);
        T Pop();
    }
}
