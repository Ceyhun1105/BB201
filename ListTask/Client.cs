using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    internal class Client : IBase
    {
        static int _id;
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
        public byte Age { get; set; }

        public Client(string password,byte age)
        {
            Id = ++_id;
            Password = password;
            Age = age;
        }

        public override string ToString()
        {
            return $" Id: {Id} Name : {Name} Password: {Password} Age : {Age}";
        }

    }
}
