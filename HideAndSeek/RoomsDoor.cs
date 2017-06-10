namespace HideAndSeek
{
    class RoomsDoor : Rooms, WithDoor
    {
        // Constructor
        public RoomsDoor(string name, int x, int y) : base(name, x, y)
        {
        }
        
        public Location DoorLocation { get; set; }
    }
}
