namespace PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = String.Empty;
            string surname = String.Empty;

            while (String.IsNullOrWhiteSpace(name)==true || String.IsNullOrWhiteSpace(surname)==true)
            {
                Console.Write(" Enter your name correctly : ");
                name = Console.ReadLine();
                Console.Write(" Enter your surname correctly : ");
                surname = Console.ReadLine();
                Console.WriteLine();
            }

            name = Char.ToUpper(name[0])+name.Substring(1);
            surname = Char.ToUpper(surname[0]) + surname.Substring(1);

            Console.Write(" Enter your age : ");
            sbyte age = Convert.ToSByte(Console.ReadLine());
            Console.Write(" Enter your Phone number : ");
            string phonenumber = Console.ReadLine();
            
            string fullname = name + " " + surname;

            Person person = new Person(fullname,age,phonenumber);


            person.ShowInfo();
        }
    }
}