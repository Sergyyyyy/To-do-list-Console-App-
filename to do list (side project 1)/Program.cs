using System;
using System.Collections.Generic;

namespace to_do_list__side_project_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--TO DO LIST PROGRAM--");
            Console.WriteLine();
            Console.WriteLine();


            List<string> list = new List<string>();
            bool e = true;

            while (e) 
            {
                Console.WriteLine("Choose Options:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View Task");
                Console.WriteLine("4. exit");
                Console.WriteLine();

                Console.Write("[]> ");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                    {
                    case 1:
                        Console.WriteLine("Input your task: ");
                        list.Add(Console.ReadLine());

                        Console.WriteLine("Task added to the list!");
                        Console.WriteLine();
                        break;
                    case 2:
                        bool remove = true;
                        while (remove)
                        {
                            Console.Write("Enter the index to the list item you want to remove: ");

                            if (int.TryParse(Console.ReadLine(), out int index))
                            {
                                if (index >= 0 && index < list.Count)
                                {
                                    list.RemoveAt(index);
                                    Console.WriteLine("You have removed item " + index);
                                    remove = false;
                                }
                                else
                                {
                                    Console.WriteLine("enter a valid index!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error input an integer!");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Your List:");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. "+ list[i]);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using this program!");
                        e = false;
                        break;
                    default: 
                        Console.WriteLine("please input a valid option");
                        break;
                    }   
            }
            Console.ReadKey();
        }
    }
}
