/**
 * AuthValidator.cs adalah fungsi untuk validasi
 * input untuk scope Login dan Register yang dapat 
 * digunakan di DTOs
*/
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace Backend.Features.Authentication.Shared.Validators
{

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class PasswordStandardAttribute : ValidationAttribute
    {
        // Value adalah property yang akan di validasi
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            /**
             * String value dijadikan sebagai variabel password agar atribut bisa
             * di custom atau atribut custom di assign ke String value.
             * Value dapat berisi string kosong jika input kosong
             */
            var password = value as string ?? "";

            //============== Atribut ==============//

            //Password harus terdiri dari minimal 8 karakter
            if (password.Length < 8)
                return new ValidationResult("Password must be 8 character minimum");

            // Password harus terdiri dari minimal 1 uppercase
            if (!Regex.IsMatch(password, "[A-Z]"))
                return new ValidationResult("Password must contain one uppercase");

            // Password harus terdiri dari minimal 1 lowercase
            if (!Regex.IsMatch(password, "[a-z]"))
                return new ValidationResult("Password must contain one lowercase");

            // Password harus terdiri dari minimal 1 angka
            if (!Regex.IsMatch(password, "[0-9]"))
                return new ValidationResult("Password must contain one number");

            // Password harus terdiri dari minimal 1 simbol
            if (!Regex.IsMatch(password, "[^A-Za-z0-9]"))
                return new ValidationResult("Password must contain one symbol");

            // return validation result success jika semua persayaratan terpenuhi
            return ValidationResult.Success;
        }
    }
}