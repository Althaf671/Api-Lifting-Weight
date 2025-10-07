/**
 * Exceptions adalah class untuk mempermudah 
 * menampilkan pesan log error yang akan digunakan 
 * di class lain yang ingin Throw error
 */

namespace Backend.Features.Authentication.Shared.Handler
{

    //========== Exception Login untuk menyimpan class error code & message ==========//
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
        /// variabel atau fungsi. Contoh: "throw new RegisterException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public RegisterException(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Forgot Password untuk menyimpan class error message ==========//
    public class ForgotPwdException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public ForgotPwdException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public ForgotPwdException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new ForgotPwdException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public ForgotPwdException(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Reset Password untuk menyimpan class error message ==========//
    public class ResetPwdException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public ResetPwdException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public ResetPwdException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new ResetPwdException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public ResetPwdException(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Captcha untuk menyimpan class error message ==========//
    public class CaptchaException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public CaptchaException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public CaptchaException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new CaptchaException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public CaptchaException(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Admin Login untuk menyimpan class error message ==========//
    public class AdminLogin : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public AdminLogin(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public AdminLogin(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new AdminLogin("Failed to receive ip address", ipAddress);"
        /// </summary>
        public AdminLogin(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Session Rotation untuk menyimpan class error message ==========//
    public class SessionException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public SessionException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public SessionException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new SessionException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public SessionException(string message, Exception innerException) : base(message, innerException) { }
    }

    //========== Exception Session Rotation untuk menyimpan class error message ==========//
    public class TwoFactorAuthException : Exception
    {
        /// <summary>
        /// Kode error custom seperti di "code" di TS
        /// </summary>
        public string? ErrorCode { get; }

        /// <summary>
        /// Untuk menampilkan error message saja/konstruktor error message
        /// <param name="message">Error message</param>
        public TwoFactorAuthException(string message) : base(message) { }

        /// <summary>
        /// Untuk menampilkan kode dan error message/konstruktor code dan error message
        /// </summary>
        /// <param name="errorCode">Error code</param>
        /// <param name="message">Error message</param>
        public TwoFactorAuthException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Untuk menampilkan error message dan wrapper untuk error default dari suatu
        /// variabel atau fungsi. Contoh: "throw new TwoFactorAuthException("Failed to receive ip address", ipAddress);"
        /// </summary>
        public TwoFactorAuthException(string message, Exception innerException) : base(message, innerException) { }
    }

}
