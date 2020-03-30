using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class ExamineStackMethods
    {
        public static void ReverseText(string text)
        {
            Stack<char> stack = new Stack<char>(text.ToCharArray());

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
