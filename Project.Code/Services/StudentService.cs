﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.Code
{
    public class StudentService
    {
        public void HandleAdd()
        {
            string role;
            do
            {
                Console.WriteLine("Select person:");
                role = Console.ReadLine();


            } while (role != "student");


            switch (role.ToUpper())
            {
                case "STUDENT":
                     Add();
                    break;

            }

        }

        public virtual Student Add()
        {
            Student model = new Student();
            model.Id = StudentIdGenerator.Instance.GetUniqueId();


            var valid = false;
            do
            {
                Console.WriteLine("First name");
                valid = Console.ReadLine().IsValidString(out var firstName);
                model.FirstName = firstName;
            } while (!valid);

            do
            {
                Console.WriteLine("Last name");
                valid = Console.ReadLine().IsValidString(out var lastName);
                model.LastName = lastName;
            } while (!valid);
            do
            {
                Console.WriteLine("What GPA student has?");
                valid = Console.ReadLine().IsValidFloat(out float GPA);
                model.GPA = GPA;
            } while (!valid);


            return StudentContainer.Instance.Add(model) as Student;
        }



   

        public IEnumerable<Person> FindAll()
        {
            return StudentContainer.Instance.FindAll();
        }



        public IEnumerable<Student> HandleDisplay()
        {
         
            var List = StudentContainer.Instance.FindAll().Cast<Student>().ToArray();

            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine($"# {List[i].Id}: {List[i].LastName}, {List[i].FirstName}, {List[i].GPA}");
            }
            return List;
        }

    }
}