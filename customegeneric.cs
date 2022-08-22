using System;

namespace Collections
{
    class MyStack<t>
    {
        int size;
        t[] stack;
        int top;
        public MyStack()
        {
            size = 10;
            stack = new t[size];
        }
        public int Push(t element)
        {
            if (top == size - 1)
            {
                Console.WriteLine("stack overflows");
            }
            else
            {
                top = top + 1;
                stack[top] = element;
            }
            return 0;
        }
        public t Pop()
        {
            t Removedele;
            t temp = default(t);
            if (top < 0)
            {
                Removedele = stack[top];
                top = top + 1;
                return Removedele;
            }
            return temp;
        }
        public t[] GetStackEle()
        {
            t[] elements = new t[top + 1];
            Array.Copy(stack, 0, elements, 0, top + 1);
            return elements;
        }
    }
    class Prgrm
    {
        static void Main(string[] args)
        {

            MyStack<string> S = new MyStack<string>();
            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter option");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("enter string to push");
                            string temp = Console.ReadLine();
                            int result = S.Push(temp);
                            if (result != -1)
                            {
                                Console.WriteLine("element pushed into stack");
                            }
                            else
                            {
                                Console.WriteLine("stack overflows");
                            }
                            break;

                        }
                    case 2:
                        {
                            string Result = S.Pop();
                            if (Result != null)
                            {
                                Console.WriteLine("delete element; " + Result);
                            }
                            else
                            {
                                Console.WriteLine("stack underflow");
                            }
                            break;
                        }
                    case 3:
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("you have entered wrong choice");
                            break;
                        }
                }
            }
        }
    }
}
