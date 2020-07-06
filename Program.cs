using System;
using System.Collections.Generic;

namespace Lab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            List<string> taskList = new List<string>();

            for (int i = 0; i < weekDay.Length; i++)
            {
                Console.WriteLine("Type in a new task for " + weekDay[i]);
                string inputTask = Console.ReadLine();
                taskList.Add(inputTask);
            }

            for (int i = 0; i < weekDay.Length; i++)
            {
                Console.WriteLine(weekDay[i] + ": " + taskList[i]);
            }

        }
    }
}
