using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private static StudentContainer instance;

        private List<Student> Container { get; set; }

        public StudentContainer()
        {
            Container = new List<Student>();
        }

        public static StudentContainer Instance => instance ?? (instance = new StudentContainer());

        public Student Add(Student role)
        {

            Container.Add(role);

            return role;
        }



        public IEnumerable<Student> FindAll()
        {
    
            return Container;
        }

    }
}
