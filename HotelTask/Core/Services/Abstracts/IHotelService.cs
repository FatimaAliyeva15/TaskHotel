using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface IHotelService
    {
        public void AddHotel(Hotel hotel);
        public List<Hotel> FindAllHotels();
        public Hotel FindHotel(string hotelname);
    }
}
