using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum AccountsErrorType
    {
        [DifferentLanguageDescriptionAttribute("Email or password is incorrect", "Неверный email или пароль", "Электрондук почта же пароль туура эмес")]
        IncorrectPasswordOrEmail = 0,

        [DifferentLanguageDescriptionAttribute("Permission denied", "Доступ запрещен", "Рұқсат жоқ")]
        PermissionDenied = 1,

        [DifferentLanguageDescriptionAttribute("Invalid token", "Недействительный токен", "Жарамсыз токен")]
        InvalidToken = 2
    }
}
