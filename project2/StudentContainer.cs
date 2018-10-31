using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace project2
{
    public class StudentContainer
    {
        private static StudentContainer instance;

        private List<Person> Container { get; set; }

        private StudentContainer()
        {
            Container = new List<Person>();
        }

        public static StudentContainer Instance => instance ?? (instance = new StudentContainer());

        public Student Add(Person student)
        {
            Container.Add(student);

            return student;
        }


        public IEnumerable<Student> Find(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                return Container.Where(e => e.LastName == Person).ToList();
            }

            return Container.Where(e => e.LastName != Person).ToList();
        }

        public IEnumerable<Person> FindAll()
        {
            return Container.ToList();
        }

        public Student Get(string Persons, string Person)
        {
            if (string.IsNullOrEmpty(Person))
            {
                return Container.FirstOrDefault(e => Persons == Person);
            }

            return Container.FirstOrDefault(e => Persons == Person);
        }

    }
}
