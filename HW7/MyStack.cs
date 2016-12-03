using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class MyStack<T> : Buffer<T> , IMyStack<T>
    {
        private int top;

        public MyStack(T[] TArray)
        {
            arrayA = TArray;
            sizeA = TArray.Length;
            count = 0;
        }
        public override bool IsEmpty()
        {
            if (top <= 0) // check if stack is not empty already
            {
                return true;
            }
            return false;
        }

        public override bool IsFull()
        {
            if (top >= sizeA) //if stack is full
            {
                return true;
            }
            return false;
        }

        public override string Peek()
        {
            string temp = null;
            if (arrayA != null)
            {
                SortCars test_obj = arrayA[0] as SortCars;
                if (test_obj != null)
                {
                    temp = "\n[\n ";
                    test_obj = arrayA[top] as SortCars;
                    temp = test_obj.Print() + "\n";
                    return temp;
                }
            }
            return TValue.ToString();
        }

        public T Pop()
        {
            TValue = arrayA[top - 1];  // save value from the top and pass it out from the method 
            //arrayA[top - 1] = -1; // delete value 
            top--; // move top one step back
            count--;  // decrease the size of the stack
            return TValue;
        }

        public override string Print()
        {
            string temp = null;
            int i = 0;
            int count_print = count;


            if (count_print == 0)
            {
                temp += "[\n"; // beginning of the stack which is the same as 1st element in the array
            }
            SortCars test_obj = arrayA[0] as SortCars;
            if (test_obj != null)
            {
                while (count_print > 0)
                {
                    if (i == 0)
                    {
                        test_obj = arrayA[i] as SortCars;
                        temp += "[\n" + test_obj.Print() + "\n"; 
                        i++;
                    }
                    else
                    {
                        test_obj = arrayA[i] as SortCars;
                        temp += test_obj.Print() + "\n";
                        i++;
                    }
                    count_print--; // reduce the size of the printed elements
                }
            }
            else
            {
                while (count_print > 0)
                {
                    if (i == 0)
                    {
                        temp += "[ " + arrayA[i]; // print start of the stack
                        i++;
                    }
                    else
                    {
                        temp += ", " + arrayA[i]; // print middle of the stack
                        i++;
                    }
                    count_print--; // reduce the size of the printed elements
                }
            }
            temp += "]\n"; // print the last element of the stack
            return temp;
        }

        public void Push(T newTop)
        {
            arrayA[top] = newTop; // push one element
            top++; // move cursor to the top of the stack
            count++;   // increase the size of stack
        }
    }
}
