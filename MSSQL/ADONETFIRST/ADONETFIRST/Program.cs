
using System.Data.SqlClient;

namespace ADONETFIRST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetData(2);
            //Thread.Sleep(2000);
            //Console.Clear();
            //Thread.Sleep(2000);
            //Console.Clear();
            GetAllDatas();
            Insert();
            GetAllDatas();
            //Delete(11);
            Thread.Sleep(2000);
            Console.Clear();
            Update(29);
            GetAllDatas();
            //GetData(2);

        }

        public static void GetData(int id)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=BSUAcademy;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string commandString = $"select * from Students where Id={id}";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    Console.WriteLine($"{data[0]} {data[1]} {data[2]} {data[3]} {data[4]}");
                }
            }
        }
        public static void GetAllDatas()
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=BSUAcademy;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string commandString = $"select * from Students";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    Console.WriteLine($"{data[0]} {data[1]} {data[2]} {data[3]} {data[4]} {data[5]}");
                }
            }
        }
        public static void Insert()
        {
            int count = 0, Age, GroupId;
            bool check,checkAge, checkGroupId;
            int studentcount;
            string commandString = string.Empty;
            string addingString = string.Empty;
            do
            {
                Console.Write(" How many students do you want to insert (min : 1 , max : 10) ? Answer : ");
                check = int.TryParse(Console.ReadLine(), out studentcount);
            } while (studentcount < 1 || studentcount > 10 || !check);

            for(int i=1; i < studentcount + 1; i++)
            {
            Console.Write(" Enter Name : ");
            string Name = Console.ReadLine();
            Console.Write(" Enter Surname : ");
            string Surname = Console.ReadLine();
                do
                {
                    Console.Write(" Enter Age : ");
                    checkAge = int.TryParse(Console.ReadLine(), out Age);
                } while (!checkAge || Age<0);
                do 
                { 
                    Console.Write(" Enter GroupId : ");
                    checkGroupId= int.TryParse(Console.ReadLine(), out GroupId);
                } while (!checkGroupId || GroupId<1);

                Console.WriteLine();
                if(i==1) commandString = $"insert into Students values ('{Name}','{Surname}',{Age},'',{GroupId})";
                if(i>1)
                {
                    addingString = $", ('{Name}','{Surname}',{Age},'',{GroupId})";
                    commandString += addingString;
                }
            }

            string connectionString = "Server=.\\SQLEXPRESS;Database=BSUAcademy;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandString, connection);
                count = command.ExecuteNonQuery();
                if (count > 0) Console.WriteLine($" {studentcount} row inserted\n");
                else Console.WriteLine(" Error!\n");
            }
        }

        public static void Delete(int id)
        {
            
            string connectionString = "Server=.\\SQLEXPRESS;Database=BSUAcademy;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string commandString = $"delete from Students where Id={id}";
                SqlCommand command = new SqlCommand(commandString, connection);
                int count = command.ExecuteNonQuery();
                if (count > 0) Console.WriteLine($" 1 row deleted\n");
                else Console.WriteLine(" Error!\n");
            }
        }
        public static void Update(int id)
        {
            string commandString = string.Empty;
            string Name = string.Empty;
            string Surname = string.Empty;
            int Age = 0;
            int GroupId = 0;
        edit:
            Console.Write($" Which column do you want to Update on column with Id {id} ?\n" +
                " 1-Name\n 2-Surname\n 3-Age\n 4-GroupId\n Choice : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(" Enter New Name : ");
                    Name = Console.ReadLine();
                    commandString = $"update Students set Name='{Name}' where Id={id}";
                    break;
                case "2":
                    Console.Write(" Enter New Surname : ");
                    Surname = Console.ReadLine();
                    commandString = $"update Students set Surname='{Surname}' where Id={id}";
                    break;
                case "3":
                    bool checkAge;
                    do {
                        Console.Write(" Enter New Age : ");
                        checkAge = int.TryParse(Console.ReadLine(),out Age);
                    }while(!checkAge || Age<0);
                    commandString = $"update Students set Age={Age} where Id={id}";
                    break;
                case "4":
                    bool checkGroupId;
                    do
                    {
                        Console.Write(" Enter New GroupId : ");
                        checkGroupId = int.TryParse(Console.ReadLine(), out GroupId);
                    }while(!checkGroupId || GroupId<1);

                    commandString = $"update Students set GroupId='{GroupId}' where Id={id}";
                    break;
                default:
                    Console.WriteLine(" Wrong Choice ");
                    goto edit;
            }


            string connectionString = "Server=.\\SQLEXPRESS;Database=BSUAcademy;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandString, connection);
                int count = command.ExecuteNonQuery();
                if (count > 0) Console.WriteLine($" ID {id} - data updated\n");
                else Console.WriteLine(" Error!\n");
            }
        }

    }
}