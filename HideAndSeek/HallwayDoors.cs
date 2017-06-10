namespace HideAndSeek
{
    class HallwayDoors : Hallway, WithDoor
    {
        public HallwayDoors(string name, int x, int y) : base(name, x, y)
        {
        }
        
        public Location DoorLocation { get; set; }
    }
}