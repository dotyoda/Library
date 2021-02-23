using System;
namespace Library.Errors
{
    class AlreadyRegistered: Error
    {
        public AlreadyRegistered(string message) : base(message) {}
    }
}
