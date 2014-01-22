using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1;
namespace MyStack
{
    public class Program
    {
        public static void Main()
        {
            Stack new_stack=new Stack();
            int new_value;
            //new_value = Int32.Parse(Console.ReadLine());
            //new_stack.Push(new_value);
            new_stack.Push(1);
            new_stack.Push(2);
            new_stack.Push(3);
            new_stack.Push(4);
            new_stack.Push(5);
            new_stack.Push(6);
            new_stack.Push(7);
            new_stack.Push(8);
            new_stack.Push(9);
            new_stack.Push(10);
            new_stack.Push(11);
            new_stack.Push(12);
            new_stack.Push(13);

            Console.WriteLine(new_stack[0]);
            foreach (float item in new_stack)
            {
                if(item>0) Console.WriteLine(item);
            }

            

        }
    }
}