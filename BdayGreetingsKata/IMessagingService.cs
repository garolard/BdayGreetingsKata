using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Messaging
{
    internal interface IMessagingService
    {
        void SendMessageTo(Employee dest, string msg);
    }
}
