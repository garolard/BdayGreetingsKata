using System;
using System.Collections.Generic;
using System.Linq;
using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Repositories.Fake
{
    internal class FakeEmployeeRepository : IEmployeeRepository
    {
        public IList<Employee> FindEmployeesBornOn(int month, int day)
        {
            return Enumerable
                .Range(0, 10)
                .Select(n =>
                        new Employee($"Employee {n}", "LastName", new DateTime(1991, month, day), "employee@contoso.com"))
                .ToList();
        }
    }
}
