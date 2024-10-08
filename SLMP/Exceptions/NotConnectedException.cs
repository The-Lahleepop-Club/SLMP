namespace SLMP.Exceptions {
    /// <summary>
    /// This exception is thrown in the case where `send` and `recv` data
    /// functions are called but there's no valid connection to operate on.
    /// </summary>
    /// <seealso cref="Exception" />
    public class NotConnectedException: Exception {
        public NotConnectedException()
            : base("Not connected to PLC") { }

        public NotConnectedException(string? message) : base(message) {
        }

        public NotConnectedException(string? message, Exception? innerException) : base(message, innerException) {
        }
    }
}
