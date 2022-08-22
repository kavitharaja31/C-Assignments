using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StackException
    {
        
        private int[] ele;
        private int top;
        private int max;
     
    public class StackException_push:Exception
    {
        public override string Message
        {
            get { return "Stack Overflow, can't perform push operation further";
            }
        }
    }
    public class StackException_pop : Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Empty, can't perform pop operation further";
            }

        }
    }

        public StackException(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                throw new StackException_push();
            }
            else
            {
                ele[++top] = item;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                throw new StackException_pop();
            }
            else
            {
                Console.WriteLine("Popped element is " + ele[top]);
                return ele[top--];
            }
        }
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

    class Prgm
    {
        public static void Main(string[] args)
        {
        try
        {
            Stack_Q3 S = new Stack_Q3(7);
            S.push(15);
            S.push(16);
            S.push(17);
            S.push(18);
            S.push(19);
            S.push(20);
            S.push(21);
            Console.WriteLine("Items are : ");
            S.printStack();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
        }
    }
