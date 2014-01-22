using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ConsoleApplication1
{
   public class Stack : IStack, IEnumerable
    {
      float[] stack;

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
            stack=new float[10];
            Length = 0;
            Capacity = 10;
        }
        public bool IsEmpty()
        {
            return Length == 0;

        }

        public void Push(float objectToPush)
        {
            if (Length < Capacity)
            {
                int i=Length;
                stack[i] = objectToPush;
                Length++;
            }
            else
            {
                float[] a = new float[Capacity * 2];
                for (int i = 0; i < Capacity; i++)
                    a[i] = stack[i];
                stack = a;
                
                stack[Length] = objectToPush;
                Capacity *= 2;
            }
        }

        public float Pull()
        {
            if (!IsEmpty())
            {
                Length--;
                return stack[Length];

            }
            else
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
        }

        public void Clear()
        {
            Length = 0;

        }
        public void Display()
        {
            int i=0;
            while(i < Length)
            {
                Console.Write(stack[i]);
                Console.Write("\n");
                i++;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return stack.GetEnumerator();
        }

       
        public bool MoveNext()
        {
            Length++;
            return (Length < Capacity);
        }
        public object Current
        {
            get { return stack[Length]; }

        }
        public void Reset()
        { Length = 0; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stack.GetEnumerator();
        }
       public float this[int i]
        {
            get { return stack[i]; }
           
        }
    }
   }


