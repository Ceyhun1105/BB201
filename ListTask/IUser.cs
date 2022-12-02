using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    internal interface IUser
    {
        public void AddUser(params Client[] client);
        public void RemoveUser(Client client);
        public void RemoveUserById(int id);
        public void ShowAllUser();
        public Client GetUserById(int id);

    }
}
