namespace HotelCheckIn 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Hello word");
            var test = new Guest();
            test.Name = Inputs.GetName();

            Console.WriteLine($"get room");
            test.NumGuests = Console.Read();
            Console.WriteLine(test.NumGuests);

            test.CheckIn = 'd';
            test.CheckOut = 'd';
            test.RoomStatus = true;
            Console.WriteLine(test.Name);
        }
    }
}