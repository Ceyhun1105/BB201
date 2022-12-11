
using System.Runtime.Serialization;

namespace FileStreamLesson
{
    [Serializable]
    public class Student : ISerializable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name, typeof(string));
            info.AddValue("surname", Surname, typeof(string));
            info.AddValue("id",Id, typeof(int));
        }
        public Student(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("name", typeof(string));
            Surname= (string)info.GetValue("surname", typeof(string));
            Id= (int)info.GetValue("id", typeof(int));
        }
        public Student()
        {

        }
    }
}
