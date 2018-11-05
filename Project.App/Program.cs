using Project.Code;
using Project.Code.Common;
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
                        Console.WriteLine("Invalid command!");
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
            Console.WriteLine("-- List");
            Console.WriteLine("---- will display all employees excluding you");
            Console.WriteLine("-- <role>List");
            Console.WriteLine("---- will display role specific employees. Example: CeoList, PmList");
        }
    }
}
