using Core.Controllers;
using Core.Exceptions;

namespace HotelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelController hotelController = new HotelController();
            RoomController roomController = new RoomController();

            bool checkmenu1 = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Sisteme giris");
                Console.WriteLine("0. Cixis");
                Console.WriteLine("");

                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 1:

                        bool checkmenu2 = true;

                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Menu");
                            Console.WriteLine("1. Hotel yarat");
                            Console.WriteLine("2. Butun Hotelleri gor");
                            Console.WriteLine("3. Hotel sec ");
                            Console.WriteLine("0. Cixis");
                            Console.WriteLine("");

                            string choiceStr2;
                            byte choice2;

                            do
                            {
                                Console.WriteLine("");
                                Console.Write("Sechim edin: ");
                                choiceStr2 = Console.ReadLine();
                            } while (!byte.TryParse(choiceStr2, out choice2));

                            switch (choice2)
                            {
                                case 1:

                                    Console.WriteLine("");
                                    Console.WriteLine("Hotel yarat");
                                    Console.WriteLine("");

                                    hotelController.Add();

                                    break;

                                case 2:

                                    Console.WriteLine("");
                                    Console.WriteLine("Butun Hotelleri gor");
                                    Console.WriteLine("");

                                    hotelController.ShowAllHotels();

                                    break;

                                case 3:

                                    Console.WriteLine("");
                                    Console.WriteLine("Hotel sec");
                                    Console.WriteLine("");

                                    hotelController.SelectedHotel();

                                    bool checkmenu3 = true;

                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Menu");
                                        Console.WriteLine("1. Room yarat");
                                        Console.WriteLine("2. Roomlari gor");
                                        Console.WriteLine("3. Rezervasya et");
                                        Console.WriteLine("4. Evvelki menuya qayit");
                                        Console.WriteLine("0. Exit");
                                        Console.WriteLine("");

                                        string choiceStr3;
                                        byte choice3;

                                        do
                                        {
                                            Console.WriteLine("");
                                            Console.Write("Sechim edin: ");
                                            choiceStr3 = Console.ReadLine();
                                        } while (!byte.TryParse(choiceStr3, out choice3));

                                        switch (choice3)
                                        {
                                            case 1:

                                                Console.WriteLine("");
                                                Console.WriteLine("Room yarat");
                                                Console.WriteLine("");

                                                roomController.Add();

                                                break;

                                            case 2:

                                                Console.WriteLine("");
                                                Console.WriteLine("Roomlari gor");
                                                Console.WriteLine("");

                                                roomController.ShowAllRooms();

                                                break;

                                            case 3:

                                                Console.WriteLine("");
                                                Console.WriteLine("Rezervasya et");
                                                Console.WriteLine("");

                                                roomController.Reservation();

                                                break;

                                            case 0:

                                                checkmenu3 = false;
                                                Console.WriteLine("");
                                                Console.WriteLine("Cixis");
                                                break;

                                            default:
                                                Console.WriteLine("");
                                                Console.WriteLine("Duzgun sechim et");
                                                break;

                                        }

                                    } while (checkmenu3);

                                    break;

                                case 0:

                                    checkmenu2 = false;
                                    Console.WriteLine("");
                                    Console.WriteLine("Cixis");
                                    break;

                                default:

                                    Console.WriteLine("");
                                    Console.WriteLine("Duzgun sechim et");
                                    break;

                            }

                        } while (checkmenu2);
                        break;

                    case 0:

                        checkmenu1 = false;
                        Console.WriteLine("");
                        Console.WriteLine("Cixis");
                        break;

                    default:

                        Console.WriteLine("");
                        Console.WriteLine("Duzgun sechim et");
                        break;
                }

            } while (checkmenu1);
        }
    }
}
