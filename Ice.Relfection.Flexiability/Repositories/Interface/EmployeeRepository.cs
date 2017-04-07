using System;
using System.Collections.Generic;
using Ice.Reflection.Flexiability.Models;

namespace Ice.Reflection.Flexiability.Repositories.Interface
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public Employee Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();

        }

        public IEnumerable<Employee> ReadAll()
        {
            return new List<Employee>{
                new Employee{Name = "Eric", Id = 1},
            };
        }

        public Employee Update(Employee entity, int id)
        {
            throw new NotImplementedException();
        }
    }

}