using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class ExamineListMethods
    {
        public static void AddUser(List<string> theList, string value)
        {
            theList.Add(value);
            Console.WriteLine("Count is: " + theList.Count);
            Console.WriteLine("Capacity Is: " + theList.Capacity);
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
        }

        public static void RemoveUser(List<string> theList, string value)
        {
            theList.RemoveAll(x => x.Contains(value));
            Console.WriteLine($"User {value} was deleted.\nCount is: " + theList.Count + "\nCapacity Is: " + theList.Capacity);
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
