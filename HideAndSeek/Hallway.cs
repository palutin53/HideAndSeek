namespace HideAndSeek
{
    class Hallway : Location
    {
        public Hallway(string name, int x, int y) : base(name, x, y)
        {
        }
        
        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                return base.Description;
            }
        }
    }
}
