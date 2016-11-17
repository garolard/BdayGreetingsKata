using System;
using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Messaging
{
    internal class FakeMessageService : IMessagingService
    {
        public void SendMessageTo(Employee dest, string msg)
        {
            Console.WriteLine($"Message {msg} sended to {dest.FirstName} {dest.LastName}");
        }
    }
}
