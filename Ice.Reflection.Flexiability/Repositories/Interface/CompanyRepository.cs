using System;
using System.Collections.Generic;
using Ice.Reflection.Flexiability.Models;

namespace Ice.Reflection.Flexiability.Repositories.Interface
{
    public class CompanyRepository : IRepository<Company>
    {
        public Company Add(Company entity)
        {
            throw new NotImplementedException();
        }

        public Company Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Company> ReadAll()
        {
            Console.WriteLine("Company Repositoy ReadAll is called");
            return new List<Company>{
                new Company{Id = 1, Name = "IceProduction"}
            };
        }

        public Company Update(Company entity, int id)
        {
            throw new NotImplementedException();
        }
    }

}