using GridDemo.Models.NorthwindEmployees;

namespace GridDemo.NorthwindEmployees
{
    public class MockNorthwindEmployeesService : INorthwindEmployeesService
    {
        public Task<List<EmployeeString<>f__AnonymousType9>> GetEmployeeString<>f__AnonymousType9()
        {
            return Task.FromResult<List<EmployeeString<>f__AnonymousType9>>(new());
        }

        public Task<List<Employee_Titles>> GetEmployee_Titles()
        {
            return Task.FromResult<List<Employee_Titles>>(new());
        }
    }
}