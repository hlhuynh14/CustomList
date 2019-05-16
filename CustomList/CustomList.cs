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
        public int Count { get { return count; } }
        private int count;
        public int Capacity { get { return capacity; } }
        private int capacity;
        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            customList = new T[capacity];

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
            count++ ;
            
        }
        public void ChangeCapacity()
        { 
            if (count == capacity )
            {
                capacity = (capacity * 2);
               T[] customList2 = new T[capacity];
                for (int i = 0; i < Count; i++ )
                {
                    customList2[i] = customList[i];
                    
                }
                customList = customList2;
            }
                
        }
        public bool RemoveFromList( T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (value.Equals(customList[i]))
                {
                    for ( int j = i; j < (count-1); j++)
                    {
                        customList[i] = customList[j + 1];
                    }
                    count--;
                    customList[count] = default(T);
                    return true;
                }
                //else
                //{
                //    return false;
                //}
            }
            return false;
        }

    }
}
