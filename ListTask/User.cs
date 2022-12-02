

namespace ListTask
{
    internal class User : IUser, IBase
    {
        static int _id;
        public List<Client> clients = new List<Client>();
        public User(string status)
        {
            Status = status;
            Id = ++_id;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public void AddUser(params Client[] client)
        {
            foreach(Client client1 in client)
            clients.Add(client1);
        }

        public Client GetUserById(int id)
        {
            foreach (Client client in clients)
            {
                if (client.Id == id)
                    return client;
                
            }
            return null;
        }
        

        public void RemoveUser(Client client)
        {
            clients.Remove(client);
        }

        public void RemoveUserById(int id)
        {
            foreach(Client client in clients)
            {
                if (client.Id == id)
                {
                    clients.Remove(client);
                    break;
                }
            }
        }

        public void ShowAllUser()
        {
            foreach(Client client in clients)
            {
                Console.WriteLine(client);
            }
        }




       


    }
}
