
namespace UserCheckPassword
{
    internal class User : IAccount
    {
        static int i = 1;
        public User(string email, string password)
        {
            E_mail = email;
            Password = password;
            Id = i;
            i++;
        }


        public int Id { get; private set; }


        private string _fullname;
        public string FullName
        {
            get => _fullname;
            set
            {
                if (!string.IsNullOrEmpty(value)) _fullname = value;
                else _fullname = $"User{i}";
            }
        }


        private string _email;
        public string E_mail
        {
            get => _email;
            set
            {
                if (EmailChecker(value)) _email = value;
                else _email = "Email is not avalible";
            }

        }



        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value)) _password = value;
                else _password = $"User{i}{i}{i}{i}";
            }
        }

        public bool PasswordChecker(string password)
        {
            bool lower = false;
            bool upper = false;
            bool number = false;
            bool avalible = false;

            foreach (char character in password)
            {
                if (char.IsLower(character)) lower = true;
                if (char.IsUpper(character)) upper = true;
                if (char.IsDigit(character)) number = true;
                if (lower && upper && number)
                {
                    avalible = true;
                    break;
                }
            }

            if (password.Length > 7 && avalible)
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Id : {Id}   Full Name : {FullName}   E-mail : {E_mail} ");
        }

        private bool EmailChecker(string email)
        {
            bool avalible = false;
            foreach (char ch in email)
            {
                if (ch == '@') avalible = true;
            }
            if (avalible && email.Length > 10) return true;

            return false;
        }


    }
}
