using System.Runtime.Serialization.Formatters.Binary;

namespace FileStreamLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student();
            student1.Name = "Aliaga";
            student1.Surname = "Qurbanov";
            student1.Id= 65;


            /*ChangeToBinary(student1);*/


            Student student2 = ChangeToCsharp();
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Surname);
            Console.WriteLine(student2.Id);
        }
        static void ChangeToBinary(Student student)
        {

            Stream stream = new FileStream("C:\\Users\\Ceyhun\\Desktop\\student.bin", FileMode.Create);
            BinaryFormatter binaryFormatter= new BinaryFormatter();
            binaryFormatter.Serialize(stream, student);
        }

        static Student ChangeToCsharp()
        {
            Stream stream = new FileStream("C:\\Users\\Ceyhun\\Desktop\\student.bin", FileMode.Open);
            BinaryFormatter binaryFormatter= new BinaryFormatter();
            return (Student)binaryFormatter.Deserialize(stream);
        }
    }
}