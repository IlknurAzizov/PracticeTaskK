using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class MyHotel
    {
        public string name;
        private Room[] _rooms = new Room[0];

        public Room this[int indexer] { get { return _rooms[indexer]; } set { _rooms[indexer] = value; } }

        public MyHotel(string name)
        {
            this.name = name;
        }


        public void AddRoom(Room room)
        {           
             Array.Resize(ref _rooms, _rooms.Length + 1);
             _rooms[^1] = room;
        }

        //public void MakeReservation(int? roomId)
        //{
        //    Room room = new Room();
        //    if (roomId is null)
        //    {
        //        Console.WriteLine("Otaq boshdur. Reserv etmek olar.");
        //    }
        //    else
        //    {
        //        if (room.isAvailable == false)
        //        {
        //            Console.WriteLine("Otaq doludur. Reserv etmek mumkun deyil.");
        //        }
        //        else
        //        {
        //            room.isAvailable = true;
        //        }
        //    }

        //    foreach (var item in _rooms)
        //    {
        //        if (item.id == roomid)
        //        {
        //            Console.WriteLine("Otaq boshdur. Reserv etmek olar.");
        //        }
        //        else
        //        {

        //        }
        //    }

            public void MakeReservation(int? roomId)
            {
                if (roomId == null)
                {
                    throw new NullReferenceException();
                }

            foreach (var room in _rooms)
            {
                if (room.ID == roomId)
                {
                    room.isAvailable = false;
                }


            }
            
                if (_rooms[id].IsAvailable == false)
                {
                Console.WriteLine("\n The room you entered is already reserved. Please change your choice"); 
                }
                _rooms[id].IsAvailable = false;
            }
        }


    }
}
