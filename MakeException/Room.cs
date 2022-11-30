

namespace MakeException
{
    internal class Room
    {
        static int i;
        public int Id { get;}
        public string Name { get; set; }
        public double Price  { get; set; }
        public byte PersonCapacity { get; set; }

        public bool IsAvalible = true;

        public Room(string name , double price , byte personCapacity)
        {
            Id = ++i;

            Name = name;
            Price = price;
            PersonCapacity = personCapacity;

        }
        
        public string ShowInfo()
        {
            return $" Id : {Id} - Name : {Name}\n Price : {Price}\n Human Capacity : {PersonCapacity}\n";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
