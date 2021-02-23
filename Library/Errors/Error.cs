using System;
namespace Library.Errors
{
    class Error: Exception
    {
        public Error(string message): base(message) { }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
