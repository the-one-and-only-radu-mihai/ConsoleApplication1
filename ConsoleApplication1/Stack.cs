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

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void Push(int objectToPush)
        {
            throw new NotImplementedException();
        }

        public int Pull()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
