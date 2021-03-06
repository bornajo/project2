﻿using Project.Code;
using System;

namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new StudentService();
            string operation;
            do
            {
                Console.Write("Operations: ");

                operation = Console.ReadLine();
                operation = operation.ToUpper();
                switch (operation)
                {
                    case Operations.Enlist:
                        service.HandleAdd();
                        break;
                    case Operations.Display:
                        service.HandleDisplay();
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        HandleHelp();
                        break;
                }
            } while (operation != Operations.Exit);

        }
        static void HandleHelp()
        {
            Console.WriteLine("Possible commands are:");
            Console.WriteLine("-- Enlist");
            Console.WriteLine("---- will route you to add a student");
            Console.WriteLine("-- Display");
            Console.WriteLine("---- will display all students");
        }
    }
}
