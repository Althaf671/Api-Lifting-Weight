/**
 * Exceptions adalah class untuk mempermudah 
 * menampilkan pesan log error yang akan digunakan 
 * di class lain yang ingin Throw error
 */

namespace Backend.Features.Authentication.Shared.Handler
{

    // Exception Login untuk menyimpan class error code & message
    public class LoginException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public LoginException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public LoginException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new LoginException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public LoginException(string message, Exception innerException) : base(message, innerException) { }

    }

    // Exception Register untuk menyimpan class error message
    public class RegisterException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public RegisterException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public RegisterException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new LoginException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public RegisterException(string message, Exception innerException) : base(message, innerException) { }
    }

}
