namespace SLMP.Exceptions {
    /// <summary>
    /// This exception is thrown to indicate that the library is trying
    /// to process invalid data.
    /// </summary>
    /// <seealso cref="Exception" />
    public class InvalidPlcDataException: Exception {
        public InvalidPlcDataException() : base() {
        }

        public InvalidPlcDataException(string message)
            : base(message) { }

        public InvalidPlcDataException(string? message, Exception? innerException) : base(message, innerException) {
        }
    }
}
