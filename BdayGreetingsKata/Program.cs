using System;
using BdayGreetingsKata.Data.Helpers;
using BdayGreetingsKata.Data.Messaging.Internet;
using BdayGreetingsKata.Data.Repositories.IO;

namespace BdayGreetingsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var ioHelper = new FileHelper(); // StubFileHelper for testing
            var employeeRepo = new FileEmployeeRepository(ioHelper);
            var messagingService = new EmailMessagingService();
            var birthdayService = new BirthdayService(employeeRepo, messagingService);
            birthdayService.SendGreetings(DateTime.Today);
        }
    }
}
