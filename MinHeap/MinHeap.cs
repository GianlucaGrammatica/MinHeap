using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    internal class MinHeap
    {
        private int[] Base = new int[4];
        private int Count = 0;
        private int Capacity = 4;

        public MinHeap() {
            Base[0] = -1;
            Count = 0;
        }

        // Gestione Array
        private void IncArray()
        {
            Capacity = Capacity * 2;
            int[] newBase = new int[Capacity];
            Base.CopyTo(newBase, 0);
            Base = newBase;
            return;
        }

        public bool CheckCapacity(int toCheck)
        {
            if(Capacity <= toCheck)
            {
                IncArray();
            }
            return true;
        }

        //
        public void Add(int toAdd)
        {
            Count++;
            if (CheckCapacity(Count))
            {
                Base[Count] = toAdd; 
            }
        }
    }
}
