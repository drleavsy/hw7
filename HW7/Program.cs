using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select one of the following option: 1=Buble Sort, 2=Insertion Sort, 3=Stack, 4=Circular Buffer");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();

            //SortItem [] Item1 = new SortItem[3] {3,"Vasya",2,"Petya",1,"Mykola" };
            // SortItem[] arrayOfClass = new SortItem[3];
            SortCars[] arrayOfCars = new SortCars[6]
                     {
            new SortCars("Ford",1992),
            new SortCars("Fiat",1988),
            new SortCars("Buick",1932),
            new SortCars("Ford",1932),
            new SortCars("Dodge",1999),
            new SortCars("Honda",1977)
                     };
            SortCars[] arrayOfCars2 = new SortCars[3]
         {
            new SortCars("",0),
            new SortCars("",0),
            new SortCars("",0),
         };
            string result = null;
            switch (str)
            {
                case "1":
                case "Bubble Sort":
                   //double[] arrayBub = new double[3] { 0.3, -0.33, 0 };  // init array
                    BubbleSorter<SortCars> Bubble1 = new BubbleSorter<SortCars>(arrayOfCars);
                   //BubbleSorter<double> Bubble1 = new BubbleSorter<double>(arrayBub);
                    Console.Write("The array before sorting: ");
                    result = Bubble1.Print();
                    Console.Write(result);

                    Bubble1.Sort();
                    result = Bubble1.Print();
                    Console.Write("Your buble sorted array:  ");
                    //Print();
                    Console.Write(result);
                    Console.WriteLine("Press ENTER to quit");
                    Console.Read();
                    break;
                case "2":
                case "Insertion Sort":
                    //int[] arrayIns = new int[3] {3, 2, 1};  // init array
                    //BubbleSorter<int> Sort1 = new BubbleSorter<int>(arrayIns);
                    BubbleSorter<SortCars> Sort1 = new BubbleSorter<SortCars>(arrayOfCars);
                    Console.Write("The array before sorting: ");
                    result = Sort1.Print();
                    Console.Write(result);

                    Sort1.Sort();
                    Console.Write("Insertion sorted array:   ");
                    result = Sort1.Print();
                    Console.Write(result);
                    Console.WriteLine("Press ENTER to quit");
                    Console.Read();
                    break;
                case "3":
                case "Stack":
                    //char[] arrayStack = new char[3] {' ', ' ', ' '};
                   // MyStack<char> StackInst = new MyStack<char>(arrayStack);
                    MyStack<SortCars> StackInst = new MyStack<SortCars>(arrayOfCars2);
                    //char[] inp1 = new char[3] { 'c', 'b', 'a' };
                    SortCars[] arrayOfCars3 = new SortCars[3]
                    {
                        new SortCars("Dodge",1999),
                        new SortCars("Ford",1981),
                        new SortCars("Buick",1932),
                    };
                    int j = 0;
                    while (str != "q")
                    {
                        if (j > 2) { j = 0; }
                        Console.WriteLine("Please select one of the following option: 1=push, 2=pop, q=quit");
                        //Console.WriteLine("Please enter your selection: ");
                        str = Console.ReadLine();
                        switch (str)
                        {
                            case "1":
                            case "push":
                                // return true if stack is still not full, otherwise return false
                                if (!StackInst.IsFull())
                                {
                                    StackInst.Push(arrayOfCars3[j]); j++;
                                    Console.WriteLine("Your stack is: ");
                                    result = StackInst.Print();// print the stack current status
                                    Console.Write(result);
                                }
                                else
                                {
                                    Console.WriteLine("The stack is full");
                                }
                                break;
                            case "2":
                            case "pull":
                                // return true if stack is still not empty, otherwise return false
                                if (!StackInst.IsEmpty())
                                {
                                    StackInst.Pop();
                                    Console.WriteLine("The value pulled from top is: " + StackInst.Peek());
                                    Console.WriteLine("Your stack is: ");
                                    result = StackInst.Print();// print the stack current status
                                    Console.Write(result);
                                }
                                else
                                {
                                    Console.WriteLine("The stack is empty ");
                                }
                                break;
                            case "q":
                            case "quite":
                                break;
                            default:
                                Console.Write("Invalid selection. ");
                                break;
                        }
                    }
                    break;
                case "4":
                case "circular buffer":
                    SortCars[] arrayOfCars4 = new SortCars[3]
                    {
                        new SortCars("Honda",1977),
                        new SortCars("Fiat",1988),
                        new SortCars("Buick",1932),
                    };
                    j = 0;
                    MyQueue<SortCars> QueueInst = new MyQueue<SortCars>(arrayOfCars2); // initialize array with 0-s

                    while (str != "q")
                    {
                        Console.WriteLine("Please select one of the following option: 1=enqueue, 2=dequeue q=quit");
                        str = Console.ReadLine();  // read user input from the console
                        if (j > 2) { j = 0; }
                        switch (str)
                        {
                            case "1":
                            case "enqueue": // write new element to the buffer from the head
                                if (!QueueInst.IsFull())
                                {
                                    QueueInst.Enqueue(arrayOfCars4[j]); j++;
                                    Console.WriteLine("Your queue is: ");
                                    result = QueueInst.Print();// print the stack current status
                                    Console.Write(result);
                                }
                                else
                                {
                                    Console.WriteLine("The queue is full");
                                }
                                break;
                            case "2":
                            case "dequeue": // delete first element from the buffer from the tail
                                if (!QueueInst.IsEmpty())
                                {
                                    QueueInst.Dequeue();
                                    Console.WriteLine("The value pulled from top is: " + QueueInst.Peek());
                                    Console.WriteLine("Your queue is:");
                                    result = QueueInst.Print();// print the stack current status
                                    Console.Write(result);
                                }
                                else
                                {
                                    Console.WriteLine("The queue is empty ");
                                }
                                break;
                            case "q":
                            case "quit":
                                break;
                            default:
                                Console.Write("invalid selection. ");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3, or 4.");
                    break;
            }
            Console.WriteLine("Press ENTER to quite");
            Console.Read();
        }
    }
}
