using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList <int> list1 = new CustomList<int>();
            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            list1.AddToList(value1);
            list1.AddToList(value2);
            list1.AddToList(value3);
            list1.RemoveFromList(5);
            Console.WriteLine(list1);
            Console.ReadLine();
        }
    }
}
