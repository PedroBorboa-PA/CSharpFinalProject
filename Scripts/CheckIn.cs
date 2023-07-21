namespace HotelCheckIn 
{
    class CheckInOut
    {
        public static void CheckIn()
        {
            Guest guest = new Guest();
            
            guest.Name = Inputs.GetName();
            guest.NumGuest = Inputs.GetNumGuests();
            guest.CheckIn = 'd';
            guest.CheckOut = 'd';
        }
    }
}