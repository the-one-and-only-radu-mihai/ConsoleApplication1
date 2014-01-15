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
            new_value = Int32.Parse(Console.ReadLine());
            new_stack.Push(new_value);
            new_stack.Display();


        }
    }
}