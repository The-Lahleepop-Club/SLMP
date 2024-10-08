namespace SLMP.Exceptions {
    /// <summary>
    /// This exception encapsulates the SLMP End Code for the further
    /// inspection of the error happened in the server (PLC/SLMP-compatible device) side.
    /// </summary>
    /// <seealso cref="Exception" />
    public class SLMPException: Exception {
        public int SLMPEndCode { get; set; }

        public SLMPException(int endCode)
            : base($"Received non-zero SLMP EndCode: {endCode:X4}H") {
            SLMPEndCode = endCode;
        }

        public SLMPException() : base() {
        }

        public SLMPException(string? message) : base(message) {
        }

        public SLMPException(string? message, Exception? innerException) : base(message, innerException) {
        }
    }
}
