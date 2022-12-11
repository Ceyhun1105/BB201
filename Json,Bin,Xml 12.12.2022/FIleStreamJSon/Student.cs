

using System.Runtime.Serialization;

namespace FIleStreamJSon
{
    [Serializable]
    public class Student 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

     
        public override string ToString()
        {
            return $"Name : {Name}   Surname : {Surname}  Id : {Id}";
        }
    }
}
