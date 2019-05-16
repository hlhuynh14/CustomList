using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return customList[index];
            }

        }
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
            }
            return false;
        }
        public override string ToString()
        {
            
            string stringList = "";
            if (count != 0)
            {
                for (int i = 0; i < (count - 1); i++)
                {
                    stringList += customList[i].ToString() + ",";

                }
                stringList += customList[count - 1].ToString();
            }
            
            return stringList;
        }
        public CustomList<T> Zip(CustomList<T> list)
        { CustomList<T> newList = new CustomList<T>();
             if (count >= list.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    newList.AddToList(customList[i]);
                    
                     if (list[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        newList.AddToList(list[i]);
                    }
                }
            }
             else
            {
                for (int i = 0; i < list.count; i++)
                {

                    if (customList[i] == null)
                    {
                       
                    }
                    else
                    {
                        newList.AddToList(customList[i]);
                    }
                    newList.AddToList(list[i]);

               }

            }
            return newList;
        }

    }
}
