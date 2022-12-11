


using System.Runtime.Serialization;

namespace FileStreamLessonXml
{
    [Serializable]
    public class Student : ISerializable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name,typeof(string));
            info.AddValue("Surname",Surname,typeof(string));
            info.AddValue("Id",Id,typeof(int));
        }

        public Student(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
            Id = (int)info.GetValue("Id", typeof(int));
        }

        public Student()
        {

        }
    }
}
