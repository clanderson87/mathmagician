using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int MAX { get; private set; } 
        protected int Step { get; set; }
        protected int First { get; set; }
        
            /*
            using properties is like 
            private int max = 50;
            public int GetMax()
            {
                return this.max;
            }

            private void SetMax(int new_max
            {
                this.max = new_max;
            }

            */

        public Integer()
        {
            MAX = 50;
            Step = 1;
            First = 0;
        }

        virtual public int GetFirst()
        {
            return First;
        }

        virtual public int GetNext(int current)
        {
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            if (how_many > MAX)
            {
                throw new Exception();
            }

            int[] seq_array = new int[how_many];
            //^this (int[how_many]) makes sure the array has this much space in the array
            
            /* //this is one way to do this - passes:
            for (int i = 0; i < how_many; i++)
            {
                seq_array[i] = i;
            }*/

            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many -1)
            {
                /*attempt 1
                seq_array[counter+1] = GetNext(seq_array[counter]);
                counter++;*/

                counter++;
                seq_array[counter] = GetNext(seq_array[counter -1]);  
            }

            return seq_array;
        }
    }
}
