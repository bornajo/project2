using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace project2
{
    public abstract class BaseService<T> where T : Person
    {
        private readonly string roleName;
        private readonly StudentContainer container;




        protected BaseService(string roleName)
        {
            this.roleName = roleName;
            container = StudentContainer.Instance;
        }

        protected StudentContainer GetStorageInstance() => container;

        public virtual T Add()
        {
            var model = person.Create(roleName) as T; // cast is required because of AddSpecific(model) method

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


            model.Roles = roleName;

            model = AddSpecific(model);

            return container.Add(model) as T;
        }

        public virtual IEnumerable<T> Find()
        {
            var result = container.Find(roleName).Cast<T>().ToList();

            if (result != null && result.Any())
            {
                DisplayList(result);
            }

            return result;
        }

        protected IEnumerable<Student> FindAll()
        {
            return container.FindAll();
        }

        public virtual T Get(int id)
        {
            var result = container.Get(id, Id) as T;

            if (result != null)
            {
                DisplaySingle(result);
            }

            return result;
        }

        /// <summary>
        /// Implement role specific value binding
        /// </summary>
        /// <param name="model">Model with generic value binding.</param>
        /// <returns>Role model with all data</returns>
        protected abstract T AddSpecific(T model);

        /// <summary>
        /// Implement to display role specific employee data
        /// </summary>
        /// <param name="list">List with role employees</param>
        protected abstract void DisplayList(IEnumerable<T> list);

        /// <summary>
        /// Implement to display single role specific employee data
        /// </summary>
        /// <param name="model">Model with employee data</param>
        protected abstract void DisplaySingle(T model);

    }
}
