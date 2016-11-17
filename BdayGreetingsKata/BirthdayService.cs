using System;
using BdayGreetingsKata.Data.Messaging;
using BdayGreetingsKata.Data.Repositories;

namespace BdayGreetingsKata
{
    internal class BirthdayService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMessagingService _messagingService;

        public BirthdayService(IEmployeeRepository employeeRepository, IMessagingService messagingService)
        {
            _employeeRepository = employeeRepository;
            _messagingService = messagingService;
        }

        public void SendGreetings(DateTime dateOfBirth)
        {
            var destinataries = _employeeRepository.FindEmployeesBornOn(dateOfBirth.Month, dateOfBirth.Day);
            foreach (var employee in destinataries)
            {
                var msg = $"Happy birthday, dear {employee.FirstName}!";
                _messagingService.SendMessageTo(employee, msg);
            }
        }
    }
}
