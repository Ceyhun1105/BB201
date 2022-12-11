using System.Xml.Serialization;

namespace FileStreamLessonXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ruslan";
            student1.Surname = "Qurbanov";
            student1.Id = 12;

            /*ChangeToXml(student1);*/
            Student student2 = ChangeToCSharpFromXml();
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Surname);
            Console.WriteLine(student2.Id);
        }

        static void ChangeToXml(Student student)
        {
            Stream stream = new FileStream("C:\\Users\\Ceyhun\\Desktop\\student.xml", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(stream, student);
        }
        static Student ChangeToCSharpFromXml()
        {
            Stream stream = new FileStream("C:\\Users\\Ceyhun\\Desktop\\student.xml", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            return (Student)xmlSerializer.Deserialize(stream);
        }
    }
}