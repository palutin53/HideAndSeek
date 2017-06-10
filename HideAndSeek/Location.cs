using System;

namespace HideAndSeek
{
    abstract class Location
    {
        public Location[] Exists;
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Location(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public virtual string Description
        {
            get
            {
                string description = "Usted esta en > " + Name + "." +
                    Environment.NewLine + "Puede ir hacia";
                for (int i = 0; i < Exists.Length; i++)
                {
                    description += " " + Exists[i].Name;
                    if (i != Exists.Length - 1)
                        description += " o/a";
                }
                description += ". ";
                return description;
            }
        }
    }
}