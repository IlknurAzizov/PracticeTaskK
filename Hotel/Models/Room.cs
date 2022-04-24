using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Room
    {
        private static int _id;
        public bool isAvailable = false;

        public int ID { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapasity { get; set; }


        static Room()
        {
            _id = 0;
        }
        public Room()
        {
            ID = ++_id;
        }
        public Room(string name, double price, int personCapacity, bool isAvailable) : this()
        {
            Name = name;
            Price = price;
            PersonCapasity = personCapacity;
            this.isAvailable = isAvailable;
        }


        public string ShowInfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"\n Room ID: {ID} \n Room name: {Name} \n Room price: {Price} \n Room Person Capacity: {PersonCapasity} \n Is Available: {isAvailable}";
        }
    }
}
