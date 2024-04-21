using Core.Exceptions;
using Core.Models;
using Core.Services.Abstracts;
using Core.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class RoomController
    {
        IRoomService _roomService = new RoomService();

        public void Add()
        {
            Console.Write("Room Name: ");
            string name = Console.ReadLine();

            
            string priceStr = "";
            double price;

            do
            {
                Console.Write("Room Price: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price));

            string personcapacityStr = "";
            int personcapacity;

            do
            {
                Console.Write("Room Person Capacity: ");
                personcapacityStr = Console.ReadLine();
            } while (!int.TryParse(personcapacityStr, out personcapacity));



            Room room = new Room(name, price, personcapacity);

            _roomService.AddRoom(room);
        }

        public void ShowAllRooms()
        {
            _roomService.FindAllRooms(item => true).ForEach(room => Console.WriteLine(room));
        }

        public void Reservation()
        {
            string idStr = "";
            int id;
            do
            {
                Console.Write("Enter the desired room id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            Console.WriteLine("");

            string personcapacityStr = "";
            int personcapacity;
            do
            {
                Console.Write("Enter your desired room capacity: ");
                personcapacityStr = Console.ReadLine();
            } while (!int.TryParse(personcapacityStr, out personcapacity));

            try
            {
                _roomService.MakeReservation(id, personcapacity);
                Console.WriteLine("Booked!");
                Console.WriteLine("");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occurred!");
            }
        }
    }
}
