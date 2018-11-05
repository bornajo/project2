using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.Code
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

        public Person Add(Person role)
        {

            Container.Add(role);

            return role;
        }



        public IEnumerable<Person> FindAll()
        {
            return Container.ToList();
        }


      
    }
}
