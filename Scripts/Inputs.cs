using System.Text.RegularExpressions;

namespace HotelCheckIn 
{
    class Inputs
    {
        public static string GetName()
        {
            string? Name;
            while (true)
            {
                Console.Write("Enter a name: ");
                Name = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(Name) && Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
                {
                    break;
                }

                Console.WriteLine("Entrada inválida. Por favor, ingrese un nombre válido.");
            }

            return Name;
        }
        public static int GetRoom()
        {
            int Room = new int();
            Room = Console.Read();
            return 0;
        }
        public static int GetNumGuests()
        {
            int Room = new int();
            Room = Console.Read();
            return Room;
        }
    }
}