﻿using System;
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
        }

        public void ClearHeap()
        {
            Count = 0;
            Base[1] = 0;
        }


        // Ordinamento
        private void Sort()
        {

        }

        // Accesso Heap
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
