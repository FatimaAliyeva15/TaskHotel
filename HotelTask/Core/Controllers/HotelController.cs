using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;
using Core.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Controllers
{
    public class HotelController
    {
        IHotelService _hotelService = new HotelService();

        public void Add()
        {
            Console.Write("Hotel name: ");
            string name = Console.ReadLine();

            Hotel hotelname = AppDb.Hotels.Find(item => item.Name == name);
            if (hotelname != null)
            {
                Console.WriteLine("");
                Console.WriteLine("There is already a hotel with the same name.");
                return;
            }

            Hotel hotel = new Hotel(name);
            _hotelService.AddHotel(hotel);  
        }


        public void ShowAllHotels()
        {
            _hotelService.FindAllHotels().ForEach(hotel => Console.WriteLine(hotel));
        }

        public void SelectedHotel()
        {
            Console.Write("Enter the name of the hotel you want to select: ");
            string selectedname = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine( _hotelService.FindHotel(selectedname));
        }
    }
}
