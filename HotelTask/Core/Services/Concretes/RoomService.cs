using Core.DataAccessLayer;
using Core.Exceptions;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class RoomService: IRoomService
    {
        public void AddRoom(Room room)
        {
            AppDb.Rooms.Add(room);
        }

        public List<Room> FindAllRooms(Predicate<Room> findroom)
        {
            return AppDb.Rooms.FindAll(findroom);
        }

        public void MakeReservation(int? roomId, int perconcapacity)
        {
            if(roomId == null)
            {
                throw new NullReferenceException();
            }

            Room room = AppDb.Rooms.Find(item => item.Id == roomId);

            if(room == null || !room.IsAvialable || room.PersonCapacity < perconcapacity)
            {
                throw new NotAvailableException("room is not avilable");
            }

            room.IsAvialable = false;
        }
    }
}
