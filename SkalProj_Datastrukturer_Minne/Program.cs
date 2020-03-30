using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        //1. 
        //2. Value type är exempelvis bool, int och double, value types innehåller datat i sitt egna minnesutrymme. Reference type är exempelvis strings,
        //arrays och klasser, reference types innehåller inget data utan en "adress" till ett minnesutymme där datat existerar.
        //3. Den första metoden returnerar 3 då x variabelns värde tilldelas till y men x tilldelas inte ett nytt värde. Den andra metoden returnerar 4 då
        //y tilldelas x's referens till minnesutrymmet och sedan sätts värdet till 4. Både x och y pekar mot värdet 4.
        //Övning 1
        //2. När listans kapacitets överskrids
        //3. Kapaciteten fördubblas
        //4. För datorer/minne jobbar i tvåpotens då allting är bits, 1 eller 0. En array som utökas blir alltid dubbelt så stor som tidigare.
        //5. Nej, minnesallokationens utrymme är reserverad så länge listan existerar.
        //6. När man vet exakt hur stor arrayen kommer behöva vara.
        //Övning 3
        //1. För att den som står först i kön kommer att hanteras sist.
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.Substring(1);

            while (true)
            {
                Console.WriteLine("Please add or remove a user by typing their firstname with a + or - operator or press 0 to exit to main menu");
                string input = Console.ReadLine();
                if (input == "0")  break;

                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        ExamineListMethods.AddUser(theList, value);
                        break;
                    case '-':
                        ExamineListMethods.RemoveUser(theList, value);
                        break;
                    default:
                        Console.WriteLine("Please use only + or - operator");
                        break;
                }
            }
            //switch (nav) {...}
        }
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> theQueue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Add to the queue with a + operator or use - operator to remove the first person in line. Press 0 to exit to main menu");
                string input = Console.ReadLine();
                if (input == "0") break;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        ExamineQueueMethods.EnqueueUser(theQueue, value);
                        break;
                    case '-':
                        ExamineQueueMethods.DequeueUser(theQueue);
                        break;
                    default:
                        Console.WriteLine("Please use only + or - operator");
                        break;
                }
            }

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            while (true)
            {
                Console.WriteLine("Type in a name or text using + operator for it to be reversed. Press 0 to exit to main menu");
                var input = Console.ReadLine();
                //var checkInput = String.IsNullOrEmpty(input)
                if (input == "0") break;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        ExamineStackMethods.ReverseText(value);
                        break;
                    default:
                        Console.WriteLine("Please use only + operator");
                        break;
                }
            }

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */


        }

    }
}

