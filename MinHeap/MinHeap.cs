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

        // Manipolazione Heap
        public void Add(int toAdd)
        {
            Count++;
            if (CheckCapacity(Count))
            {
                Base[Count] = toAdd; 
            }

            HeapSort();
        }

        public void ClearHeap()
        {
            Count = 0;
            Base[1] = 0;
        }


        // Ordinamento

        private void Heapify(int i)
        {

            int Smallest = i;
            int Left = i * 2;
            int Rigth = i * 2 + 1;


            if (Left < Count && Base[Left] < Base[Smallest])
            {
                Smallest = Left;
            }                

            if (Rigth < Count && Base[Rigth] < Base[Smallest])
            {
                Smallest = Rigth;
            }
            

            if (Smallest != i)
            {
                int temp = Base[i];
                Base[i] = Base[Smallest];
                Base[Smallest] = temp;

                Heapify(Smallest);
            }
        }

        void HeapSort()
        {
            for (int i = Count / 2; i >= 1; i--)
            {
                Heapify(i);
            }
                

            for (int i = Count - 1; i >= 1; i--)
            {

                int temp = Base[1];
                Base[1] = Base[i];
                Base[i] = temp;

                Heapify(1);
            }
        }

        // Accesso Heap
        public int GetMin()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }

            int min = Base[1];
            Base[1] = Base[Count];
            Count--;

            HeapSort();
            return min;
        }

        public override string ToString()
        {
            string toReturn = "";

            if(Count <= 0) {
                return "empty";
            }

            for(int i = 1; i < Count+1; i++)
            {
                toReturn += Base[i].ToString()+"\t";
            }

            return toReturn;
        }
    }
}
