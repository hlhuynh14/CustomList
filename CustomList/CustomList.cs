using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


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
            count++;

        }
        private void ChangeCapacity()
        {
            if (count == capacity)
            {
                capacity = (capacity * 2);
                T[] customList2 = new T[capacity];
                for (int i = 0; i < Count; i++)
                {
                    customList2[i] = customList[i];

                }
                customList = customList2;
            }

        }
        public bool RemoveFromList(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (value.Equals(customList[i]))
                {
                    for (int j = i; j < (count - 1); j++)
                    {
                        customList[j] = customList[j + 1];

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
            if (this.Count != 0)
            {
                for (int i = 0; i < (this.Count - 1); i++)
                {
                    stringList += this[i].ToString() + ",";

                }
                stringList += this[count - 1].ToString();
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
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                newList.AddToList(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                newList.AddToList(list2[i]);
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {

            for (int i = 0; i < list2.count; i++)
            {
                list1.RemoveFromList(list2[i]);
            }

            return list1;
        }
        private void SortArray(int start, int middle, int end)
        {
            Comparer comp = new Comparer(new CultureInfo(0x040A, false));
            int placeKeeper = start;
            int placeKeeper2 = middle +1;
            int switcher = 0;
            T[] Array1;
            Array1 = new T[(end-start)+1];




            for (int i = start; i <= end; i++)
            {
                if (start > middle)
                {
                    Array1[switcher] = customList[placeKeeper2];
                    switcher++;
                    placeKeeper2++;
                }
                    
               else if( placeKeeper2 > end)
               {
                    Array1[switcher] = customList[start];
                    switcher++;
                    start++;
               }
               else if(comp.Compare(customList[start], customList[placeKeeper2]) == -1)
               {
                  Array1[switcher] = customList[start];
                  switcher++;
                  start++;
               }

               else
               {
                Array1[switcher] = customList[placeKeeper2];
                 switcher++;
                 placeKeeper2++;
               }
            }
               for (int j = 0; j < switcher; j++)
               {
                    customList[placeKeeper] = Array1[j];
                    placeKeeper++;
               }
            
        }
            private void MergeSort(int start, int end)
            {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(start, mid);
                MergeSort(mid + 1, end);
                SortArray(start, mid, end);
            }

            }
            public void Sort()
            {
                MergeSort(0, count-1);
            }




    }
}

