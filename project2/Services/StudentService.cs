using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace project2
{
    public class StudentService : BaseService<Student>
    {

        public StudentService() : base(Roles.Student)

        {
        }
        protected override Student AddSpecific(Student model)

        {
            bool valid;
            do
            {
                Console.WriteLine("What GPA student has?");
                valid = Console.ReadLine().IsValidFloat(out var GPA);
                model.GPA = GPA;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<Student> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(Student model)
        {
            Console.WriteLine($"{model.Id}: {model.LastName}, {model.FirstName}, {model.GPA}");
        }
    }
}