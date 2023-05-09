using System;

namespace Project3.VacuumCleaners
{
    public class VacuumCleaner
    {
        public virtual Model model { get; }
        public Rooms rooms { get; }
        public string Title => rooms.ToString();
        

        public virtual void StartCleaning()
        {
            Console.WriteLine("Началась уборка");
        }

        public virtual void StartCleaning(string Kitchen)
        {
        }


    }
    public enum Model
    {
        Samsung,
        Redmond,
        Philips,
        Bosch,
        Karcher
    }
}