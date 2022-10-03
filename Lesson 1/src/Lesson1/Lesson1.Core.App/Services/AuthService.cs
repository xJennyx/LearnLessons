using System.Collections.Generic;

namespace Lesson1.Core.App.Services
{
    public class AuthService
    {
        public AuthService()
        {
            Employees = new List<string>
            {
                "Петров",
                "Иванов",
                "Сидоров"
            };
        }

        public List<string> Employees { get; private set; }

        public bool Login(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            var isEmployeeExist = Employees.Contains(lastName);

            if (isEmployeeExist)
            {
                UserSession.Sessions.Add(lastName);
            }

            return isEmployeeExist;
        }
    }
    public static class UserSession
    {
        public static HashSet<string> Sessions { get; set; } = new HashSet<string>();
    }
}

