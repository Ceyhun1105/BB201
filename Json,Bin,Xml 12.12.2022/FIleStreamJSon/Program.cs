
using Newtonsoft.Json;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FIleStreamJSon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Surname = "Aliyev";
            student.Name= "Abbas";
            student.Id= 1;

            string path = "C:\\Users\\Ceyhun\\Desktop\\student.json";
            FileStream file1 = File.Create(path);
            file1.Close();
            var studentjson = JsonConvert.SerializeObject(student);
            File.WriteAllText(path, studentjson);

            string lines=File.ReadAllText(path);
            Student studentjsondes = new Student();
            studentjsondes = JsonConvert.DeserializeObject<Student>(lines);
            Console.WriteLine(studentjsondes);
        }
       
     
    }
}