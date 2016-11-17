using System;
using BdayGreetingsKata.Data.Messaging.Internet;
using BdayGreetingsKata.Data.Repositories.IO;

namespace BdayGreetingsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new FileEmployeeRepository();
            var messagingService = new EmailMessagingService();
            var birthdayService = new BirthdayService(employeeRepo, messagingService);
            birthdayService.SendGreetings(DateTime.Today);
        }
    }
}
