using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stack : IStack
    {
      int[] stack;

        public int Length
        {
            get;
            set;

        }
        
        public int Capacity
        {
            get;
            set;
        }
        public Stack() 
        {
            stack=new int[10];
            Length = 0;
            Capacity = 10;
        }
        public bool IsEmpty()
        {
            return Length == 0;

        }

        public void Push(int objectToPush)
        {
            if (Length < Capacity)
            {
                int i=Length;
                stack[i] = objectToPush;
                Length++;
            }
            else Console.WriteLine("Stack is full");
        }

        public int Pull()
        {
            if(!IsEmpty())
            {
                Length--;
            }
            else Console.WriteLine("Stack is empty");
            return 0;
        }

        public void Clear()
        {
            while (!IsEmpty())
            {
                Length--;
            }
        }
        public void Display()
        {
            int i=0;
            while(i<Length)
            {
                Console.Write(stack[i]);
                Console.Write(" ");
                Console.Write("\n");
                i++;
            }
        }
    }

}
