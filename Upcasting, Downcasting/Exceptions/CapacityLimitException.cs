
namespace Upcasting__Downcasting.Exceptions
{
    internal class CapacityLimitException : Exception
    {
        public CapacityLimitException() { }
        public CapacityLimitException(string message): base(message) { }
        public CapacityLimitException(string message, Exception innerException) : base(message, innerException) { }
    }
}
