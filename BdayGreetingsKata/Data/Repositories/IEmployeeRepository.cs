using System.Collections.Generic;
using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Repositories
{
    internal interface IEmployeeRepository
    {
        IList<Employee> FindEmployeesBornOn(int month, int day);
    }
}
