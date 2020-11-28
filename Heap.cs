using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Heap
    {
        public IList<int> list;
        public int count;
        public int capacity;
        public int heapType;

        public Heap(int capacity,int heapType)
        {
            this.capacity = capacity;
            this.count = 0;
            this.heapType = heapType;
            this.list = new List<int>();            
        }

        /// <summary>
        /// Time complexity O(1)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Parent(int i)
        {
            if( i <= 0 || i >= this.count)
            {
                return -1;
            }
            return i - 1 / 2;
        }
        /// <summary>
        /// Time complexity O(1)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int LeftChild(int i)
        {
            if (i <= 0 || i >= this.count)
            {
                return -1;
            }
            return 2 * i + 1;
        }
        /// <summary>
        /// Time complexity O(1)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int RightChild(int i)
        {
            if (i <= 0 || i >= this.count)
            {
                return -1;
            }
            return 2 * i + 2;
        }
        /// <summary>
        /// Time Complexity O(logn) Space Complexity O(1)
        /// </summary>
        /// <param name="i"></param>
        public void PercolateDown(int i)
        {
            int l, r, max = i, temp;
            l = LeftChild(i);
            r = RightChild(i);

            if(l!=-1 && list[l] > list[i])
            {
                max = l;
            }
            else if(r!=-1 && list[r] > list[i])
            {
                max = r;
            }
            if(max!=i)
            {
                temp = list[max];
                list[max] = list[i];
                list[i] = temp;
            }
        }
        /// <summary>
        /// Deleting an element uses Percolate Down and Inserting an element uses Percolate Up
        /// Time complexity is O(logn)
        /// </summary>
        /// <returns></returns>
        public int DeleteMax()
        {
            if (this.count == 0) return -1;

            int data = list[0];
            this.list[0] = this.list[this.count - 1];
            this.count--;
            PercolateDown(0);
            return data;
        }

        public void Insert(int data)
        {
            int i;
            this.count++;
            i = this.count - 1;
            while(i >= 0 && data > this.list[i-1/2])
            {
                this.list[i] = list[i - 1 / 2];
                i = i - 1 / 2;
            }
            list[i] = data;
        }
        public void DestroyingHeap()
        {
            this.count = 0;
            this.list = null;
        }
        /// <summary>
        /// Time Complexity O(n)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        public void BuildHeap(int[] A, int  n)
        {
            if (this.list == null) return;

            list = A.ToList();

            this.count = n;
            for(int i = (count-1)/2; i >=0; i--)
            {
                PercolateDown(i);
            }
        }
        /// <summary>
        /// Since Time Complexity of both Insertion and deletion is logn 
        /// Time Complaexity of Heap Sort is O(nlogn)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        public void HeapSort(int[] A,int n)
        {                 
            Heap heap = new Heap(n, 0);
            int old_size, temp;
            old_size = n;
            BuildHeap(A, n);
            for(int  i = n-1; i >=0; i--)
            {
                temp = heap.list[0];
                heap.list[0] = heap.list[heap.count - 1];
                heap.count--;
                heap.PercolateDown(0);
            }
            heap.count = old_size;
        }
    }
}
