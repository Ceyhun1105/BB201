
namespace ClassLibrary
{
    public class User
    {
        public User(string userName)
        {
            Username = userName;
        }

        
        
        private string _username;
        private string _password;

        public string Username { get => _username;
            set
            {   if (!String.IsNullOrWhiteSpace(value) && value.Length >= 6 && value.Length <= 25)
                {
                    _username = value;
                }
            }
        }
        public string Password {
            get => _password;
            set
            {
                if(!String.IsNullOrWhiteSpace(value) && value.Length>=8 && value.Length <= 25)
                {
                    _password = value;
                }
            }
        }

        public static bool HasDigit(string str)
        {
            bool have=false;
            for(int i=0;i<str.Length;i++) 
            {
                have = Char.IsDigit(str[i]);
                if (have) break;
            }
            return have;
        }
        public static bool HasUpper(string str)
        {
            bool have = false;
            for (int i = 0; i < str.Length; i++)
            {
                have = Char.IsUpper(str[i]);
                if (have) break;
            }
            return have;
        }
        public static bool HasLower(string str)
        {
            bool have = false;
            for (int i = 0; i < str.Length; i++)
            {
                have = Char.IsLower(str[i]);
                if (have) break;
            }
            return have;
        }



        // Addition


        private string _bio;

        public string Bio { get; set; }
        public void ChangePhoto()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(" Your Profile Photo are changed ");
            Console.ResetColor();
        }
        public void ChangeBio()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write(" Enter new Bio : ");
            string bio = Console.ReadLine();
            if (!String.IsNullOrEmpty(bio))
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" Bio are changed ... ");
                Bio = bio;
            }

            Console.ResetColor();
        }
        public void ShowBio() 
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            if (String.IsNullOrEmpty(Bio))
            {
                Console.WriteLine(" You have not Bio ... You can Add ...");
            }
            else
            {
                Console.WriteLine($" Your Bio : {Bio}");
            }
            Console.ResetColor();
        }


        
    }
}
