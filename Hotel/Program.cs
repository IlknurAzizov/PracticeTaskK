using Hotel.Models;
using System;

namespace HotelPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("Room#1", 120, 50, true);
            Console.WriteLine(room.ShowInfo());

            //MyHotel hotel = new MyHotel("Sahil");
            //hotel.AddRoom(room);
            //hotel.MakeReservation(1);
            Room room1 = new Room("Sahil", 120, 50, true);
            Console.WriteLine(room1.ShowInfo());
        }
    }
}
