using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {// member variable (HAS A)
        private T[] customList;
        public int count { get { return Count; } }
        private int Count;
        public int capacity { get { return Capacity; } }
        private int Capacity;
        // constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            customList = new T[Capacity];

        }
     // member methods (CAN DO)
     public T this[int indexrange]
     {
           
                get
                {
                    return customList[indexrange];
                }
                set
                {
                    customList[indexrange] = value;
                }
            
     }


       public void AddToList(T value)
        {
            ChangeCapacity();
            customList[Count] = value;
            Count++ ;
            
        }
        public void ChangeCapacity()
        { 
            if (Count == Capacity )
            {
                Capacity = (Capacity * 2);
               T[] customList2 = new T[capacity];
                for (int i = 0; i < Count; i++ )
                {
                    customList2[i] = customList[i];
                    
                }
                
                customList = customList2;
            }
                
        }

 
    }
}
