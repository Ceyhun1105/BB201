namespace ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new("hsfddgfd1213", 20);
            Client client2 = new("frsetgerg", 40);
            Client client3 = new("rggeehtghertht", 27);
            Client client4 = new("sfgdsdffgf", 30);
            Client client5 = new("grfgrfgergdr", 14);

            User user = new("Client");

            user.AddUser(client1, client2, client3, client4, client5);

            /*Console.WriteLine(user.GetUserById(3));*/

            user.RemoveUserById(3);

            user.ShowAllUser();

        }
    }
}