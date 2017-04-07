using Ice.Reflection.Flexiability.Repositories.Interface;

namespace Ice.Reflection.Flexiability.Repositories
{
    public class RepositoryFactory
    {
        public CompanyRepository GetCompanyRepository()
        {
            return new CompanyRepository();
        }

        public DepartmentRepository GetDepartmentRepository()
        {
            return new DepartmentRepository();
        }

        public EmployeeRepository GetEmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }

}