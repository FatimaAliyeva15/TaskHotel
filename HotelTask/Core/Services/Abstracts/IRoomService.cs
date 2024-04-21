using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface IRoomService
    {
        public void AddRoom(Room room);
        public List<Room> FindAllRooms(Predicate<Room> findroom);
        public void MakeReservation(int? roomId, int perconcapacity);

    }
}
