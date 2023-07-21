namespace HotelCheckIn 
{
    class Guest
    {
        public bool RoomStatus;
        public string? Name; //No nullable
        public int NumGuests;
        public char CheckIn;
        public char CheckOut;

        public int NumGuest { get; internal set; }

        // public int NumGuest { get; internal set; }
    }
}