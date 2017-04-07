using System;
using System.Collections.Generic;
using Ice.Reflection.Flexiability.Models;

namespace Ice.Reflection.Flexiability.Repositories.Interface
{
    public class DepartmentRepository : IRepository<Department>
    {
        public Department Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> ReadAll()
        {
                Console.WriteLine("DepartmentRepository Repositoy ReadAll is called");
                return new List<Department>{
                new Department{Name = "Product", Id = 1},
                new Department{Name = "Finance", Id = 2 },
                new Department{Name = "Customer Service", Id = 3}
            };
        }

        public Department Update(Department entity, int id)
        {
            throw new NotImplementedException();
        }
    }

}