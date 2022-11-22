
namespace PersonClass
{
    internal class Person
    {



        public Person(string fullname, sbyte age , string phonenumber)
        {
            this.Age = age;
            this.Phonenumber = phonenumber;
            this.Fullname = fullname;
        }

        private string _fullname;
        private sbyte _age;
        private string _phonenumber;
        
        public string Fullname
        {
            get { return _fullname; }
            set {
                if (Char.IsUpper(value[0])==true)
                _fullname = value;
                }
        }
        public sbyte Age
        {
            get { return _age; }
            set {
                if (value > 0 && value < 120)
                {
                    _age = value;
                }
            }
        }
        public string Phonenumber
        {
            get { return _phonenumber; }
            set {
                bool Canturn = int.TryParse(value, out int number);
                if (!String.IsNullOrWhiteSpace(value) && (value.Length == 9 | value.Length == 10) && Canturn == true)
                _phonenumber = value;
                }
        }


        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
        public string GetInfo()
        {
            return $"\n Fullname : {Fullname}\n Age : {Age}\n Phonenumber : {Phonenumber}";
        }
    }
}

