using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class ExamineQueueMethods
    {
        public static void EnqueueUser(Queue<string> theQueue, string value)
        {
            theQueue.Enqueue(value);
            Console.WriteLine("\nThere are currently: " + theQueue.Count + " people in line");
            foreach (var item in theQueue)
            {
                Console.WriteLine(item);
            }
        }

        public static void DequeueUser(Queue<string> theQueue)
        {
            if (theQueue.Count == 0) Console.WriteLine("\nCan not remove since there are currently nobody in line");
            else
                theQueue.Dequeue();
            Console.WriteLine("\nThere are currently: " + theQueue.Count + " people in line");
            foreach (var item in theQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
