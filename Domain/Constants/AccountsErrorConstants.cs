using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public class AccountsErrorConstants
    {
        public const string IncorrectSignIn = "Email or password is incorrect";
        public const string Unauthorized = "Unauthorized";
        public const string Forbidden = "Forbidden";
        public const string TokenRequired = "Token is required";
        public const string InActive = "Account is inactive";
        public const string InvalidToken = "Invalid token";
        public const string BusyPin = "Pin already exists";
        public const string VerificationFailed = "Verification failed";
        public const string NotFound = "Account not found";
        public const string RoleNotFound = "Role not found!";
        public const string NotValidPassword = "Password must contain at least 8 symbols (1 uppercase letter, 1 number, 1 special character)";

        public static string GetBusyPinMessage(string pin) => $"Pin '{pin}' is already registered";

        public static string GetIncorrectRef1Message(long? refId) => $"Ref1Id {refId}    ";

        public static string GetIncorrectRef2Message(long? refId) => $"Ref2Id {refId}    ";

        public static string GetBusyEmailMessage(string email) => $"Email '{email}' is already registered";

        public static string GetAccountNotFoundMessage(long id) => $"Account with id {id} not found!";
    }
}
