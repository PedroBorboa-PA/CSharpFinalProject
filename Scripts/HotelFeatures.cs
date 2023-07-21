namespace HotelCheckIn 
{
    public static class HotelFeatures
    {
        public const int Floors = 3;
        public const int RoomPerFloor = 5;
        static Guest[,] HotelRooms = new Guest[Floors, RoomPerFloor];

        /*This method initializes the HotelRooms array 
        with all rooms with status false*/
        public static void InitHotel()
        {
            for(int i = 0; i < Floors; i++)
            {
                for(int j = 0; i < RoomPerFloor; j++)
                {
                    HotelRooms[Floors,RoomPerFloor].RoomStatus = false;
                }
            }    
        }
    }
}