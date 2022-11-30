

namespace MakeException.Exceptions
{
    internal class Hotel
    {
        public string Name { get; set; }

        private Room[] rooms;


        public Hotel(string name)
        {
            Name = name;
            rooms = Array.Empty<Room>();
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[^1] = room;
        }
        public Room[] GetRooms()
        {
            return rooms;
        }

        public void MakeReservation(int? roomid)
        {
            bool have = false;
            Nullable<int> num = null;
            if (roomid != num)
            {
                foreach (Room froom in rooms)
                {
                    if (froom.Id == roomid)
                    {
                        have = true;
                        if (froom.IsAvalible == true)
                        {
                            Console.WriteLine(" Room is reserved by you ");
                            froom.IsAvalible = false;
                        }
                        else
                        {
                            throw new NotAvalibleException(" Room is not avalible for reservation.");
                        }
                        break;
                    }
                }
                if (!have)
                {
                    throw new HaveNotInArrayException(" There are not any room with this Id !");
                }
            }
            else
            {
                throw new NullReferenceException(" Value must'n be null");
            }
        }

        public void CatchError(int? num)
        {
            try
            {
                this.MakeReservation(num);

            }
            catch (HaveNotInArrayException ex) { Console.WriteLine(ex.Message); }

            catch (NotAvalibleException ex) { Console.WriteLine(ex.Message); }

            catch (NullReferenceException ex) { Console.WriteLine(ex.Message); }

            catch(Exception) { Console.WriteLine(" Unknown Error"); }

        }


    }
}
