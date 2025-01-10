using System;

namespace Recombee.ApiClient
{
    /// <summary>Base class for exceptions that occur because of errors in requests reported by API or because of a timeout</summary>
    public class ApiException: Exception
    {
        public ApiException() {}

        public ApiException(string message): base(message) {}

        public ApiException(string message, Exception inner): base(message, inner) {}

    }
}
