using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Room
    {
        private static int _id;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvialable { get; set; } = true;

        public Room(string name, double price, int personcapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}";
        }


    } 
}
