﻿
using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class HotelService: IHotelService
    {
        public void AddHotel(Hotel hotel)
        {
            AppDb.Hotels.Add(hotel);
        }

        public List<Hotel> FindAllHotels()
        {
            return AppDb.Hotels;
        } 

        public Hotel FindHotel(string hotelname)
        {
            Hotel hotel = AppDb.Hotels.Find(item => item.Name == hotelname);
            return hotel;
        }
    }
}
