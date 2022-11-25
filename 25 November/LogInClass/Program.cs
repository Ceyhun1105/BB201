using ClassLibrary;
namespace LogInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = String.Empty;
            string password = String.Empty;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Username : ");
                Console.ResetColor();
                username = Console.ReadLine();
                if (username.Length < 6 | username.Length>25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Username must be minimum 6 and maximum 25 letters !");
                    Console.ResetColor();
                }

            } while (String.IsNullOrWhiteSpace(username) | username.Length<6 | username.Length > 25);


            bool checkpassword = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Password : ");
                Console.ResetColor();
                password = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(username) && password.Length >= 8 && password.Length <= 25 &&
                   User.HasDigit(password) && User.HasUpper(password) && User.HasLower(password))
                {
                    checkpassword = true;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    if (password.Length < 8 | password.Length > 25)
                    {
                        Console.WriteLine(" Password must be minimum 8 and maximum 25 letters !");
                    }
                    else
                    {
                        Console.WriteLine(" Your password must contain :\n" +
                            " at least 1 lowercase letter\n at least 1 uppercase letter\n at least 1 digit  ");
                    }
                    Console.ResetColor();
                }

            } while (!checkpassword);


            User user1 = new User(username);
            user1.Password = password;

            //Addition 

            Console.WriteLine($" Welcome {user1.Username} . We hope you are Excellent...\n Loading ...");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            System.Threading.Thread.Sleep(1000);
            user1.ChangePhoto();

            user1.ShowBio();

            user1.ChangeBio();

            user1.ShowBio();

            
        }

    }
}