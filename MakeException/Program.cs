using MakeException.Exceptions;

namespace MakeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Monte-Maerio", 150, 10);
            Room room2 = new Room("Kleopatra", 340, 12);

            Hotel hotel = new Hotel("Icerisheher");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);



            hotel.CatchError(null);
            hotel.CatchError(1);
            hotel.CatchError(2);
            hotel.CatchError(3);
            hotel.CatchError(2);
            hotel.CatchError(1);
            


        }
    }
}