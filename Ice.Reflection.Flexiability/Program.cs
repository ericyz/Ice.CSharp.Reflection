using System;
using System.Collections;
using Ice.Reflection.Flexiability.Repositories;

namespace Ice.Relfection.Flexiability
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new RepositoryFactory();

            var companies = repository.GetCompanyRepository().ReadAll();
            var departments = repository.GetDepartmentRepository().ReadAll();
            var employees = repository.GetEmployeeRepository().ReadAll();

            // Do your cool stuff
        }


    }
}
