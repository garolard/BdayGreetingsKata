using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Repositories.IO
{
    public class FileEmployeeRepository : IEmployeeRepository
    {
        private const int FirstNameColumn = 1;
        private const int LastNameColumn = 0;
        private const int BirthdateColumn = 2;
        private const int EmailColumn = 3;
        private const int HeaderLines = 1;

        private const char ColumnSeparator = ',';

        private const string FilePath = @"Data\database.txt";


        public IList<Employee> FindEmployeesBornOn(int month, int day)
        {
            var fileLines = File.ReadLines(FilePath).ToList();
            if (!fileLines.Any() || fileLines.Count == 1)
            {
                return new List<Employee>();
            }

            return fileLines
                .Skip(HeaderLines)
                .Select(GetEmployeeFromLine)
                .Where(e => IsEmployeeBirthday(e, month, day))
                .ToList();
        }

        private Employee GetEmployeeFromLine(string line)
        {
            var data = line.Split(ColumnSeparator);
            var firstName = data[FirstNameColumn].Trim();
            var lastName = data[LastNameColumn].Trim();
            var email = data[EmailColumn].Trim();
            var birthDate = DateTime.ParseExact(data[BirthdateColumn].Trim(), "yyyy/dd/MM", null);

            return new Employee(firstName, lastName, birthDate, email);
        }

        private bool IsEmployeeBirthday(Employee employee, int month, int day)
        {
            return employee.DateOfBirth.Month == month &&
                   employee.DateOfBirth.Day == day;
        }
    }
}
