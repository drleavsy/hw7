using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int head;
        private int tail;

        public MyQueue(T[] TArray)
        {
            arrayA = TArray;
            sizeA = TArray.Length;
            count = 0;
            head = 0;
            tail = 0;
        }

        public T Dequeue()
        {
            if (tail < sizeA) // if the tail is less than the size of array
            {
                TValue = arrayA[tail];
                // remove element at the tail index (first index in the ring buffer)
                tail++; // move tail step forward
                count--; // reduce the size of the buffer
            }
            else // if (tail == sizeIn)
            {
                tail = 0; // if last remove was at the end of the array , then set tail to the beginning of the array
                TValue = arrayA[tail];
                // remove element under tail index
                count--;// reduce the size of buffer
                tail++; // move tail one step forward
            }
            return TValue;
        }

        public void Enqueue(T newTop)
        {
            if (head < sizeA)  // check if head index is less than the array size
            {
                arrayA[head] = newTop; // adding new element
                head++; // move "writing" index one ste forward
                count++; // increase the size of buffer
            }
            else // if (head == sizeIn) , if head index reached the end of array
            {
                head = 0; // move the head "write index" to the beginning of the array
                arrayA[head] = newTop; // add new element to the beginning of the array
                count++; // increase the size of buffer
                head++; // move the head index to the 2nd cell of array, after the first one was already written
            }
        }

        public override bool IsEmpty()
        {
            if (count <= sizeA && count > 0) // check if stack is not empty already
            {
                return false;
            }
            else
            {
               // Console.WriteLine("The queue is empty.");
                return true;
            }
        }

        public override bool IsFull()
        {
            if (count < sizeA)  // check if the buffer is not full yet
            {
                return false;
            }
            else
            {
                //Console.WriteLine("The queue is full.");
                return true;
            }
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
                    test_obj = TValue as SortCars;
                    temp = test_obj.Print() + "\n";
                    return temp;
                }
            }
            return TValue.ToString();
        }

        public override string Print()
        {
            string temp = null;
            int i = tail;
            int count_print = count;
            if (count_print == 0) // if buffer is empty print [ ]
            {
                temp = "[ ]\n";
            }
            SortCars test_obj = arrayA[0] as SortCars;
            while (count_print > 0 && arrayA != null)
            {
                if (test_obj != null)
                {
                    if (i < sizeA) // if printed element is less than the maximum of the array
                    {
                        if (tail == i)
                        {
                            test_obj = arrayA[i] as SortCars;
                            temp += "[\n " + test_obj.Print() + "\n";
                            i++;
                        }
                        else if (tail != i)
                        {
                            test_obj = arrayA[i] as SortCars;
                            temp += test_obj.Print() + "\n";
                            i++;
                        }
                    }
                    else if (i >= sizeA) // if index exceed the size of the array
                    {
                        i = 0;
                        if (tail == sizeA) // print start position of the buffer
                        {
                            test_obj = arrayA[i] as SortCars;
                            temp += "[\n" + test_obj.Print() + "\n";
                            i++;
                        }
                        else // print the middle elements of the buffer
                        {
                            test_obj = arrayA[i] as SortCars;
                            temp += test_obj.Print() + "\n";
                            i++;
                        }
                    }
                }
                else
                {
                    if (tail == i)
                    {
                        temp += "[ " + arrayA[i]; // print the first element sof the buffer
                        i++;
                    }
                    else if (tail != i)
                    {
                        temp += ", " + arrayA[i]; // middle element
                        i++;
                    }
                    else if (i >= sizeA) // if index exceed the size of the array
                    {
                        i = 0;
                        if (tail == sizeA) // print start position of the buffer
                        {
                            temp += "[ " + arrayA[i];
                            i++;
                        }
                        else // print the middle elements of the buffer
                        {
                            temp += ", " + arrayA[i];
                            i++;
                        }
                    }
                }
                count_print--;
                if (count_print == 0)
                {
                    temp += "]\n";
                }
            }
            return temp;
        }
    }
}
