using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MyStack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }
        public MyStack()
        {
            top = -1;
        }
        public bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        public virtual object Clone()
        {
            return new StackImplementation.MyStack();
        }
    }
    class Prgrm
    {
        public static void Main(string[] args)
        {
            MyStack ms= new MyStack();
            ms.Push(10);
            ms.Push(20);
            ms.Push(30);
            ms.Push(40);
            ms.PrintStack();
            ms.Peek();
            Console.WriteLine("Item popped from Stack : {0}", ms.Pop());
            ms.PrintStack();
        }
  }
