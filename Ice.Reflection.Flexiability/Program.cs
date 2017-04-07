using Ice.Reflection.Flexiability.Models;
using Ice.Reflection.Flexiability.Repositories;

namespace Ice.Relfection.Flexiability
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new RepositoryFactory();

            var companies = repository.GetRepository<Company>().ReadAll();
            var departments = repository.GetRepository<Department>().ReadAll();
            var employees = repository.GetRepository<Employee>().ReadAll();

            // Do your cool stuff
        }


    }
}
