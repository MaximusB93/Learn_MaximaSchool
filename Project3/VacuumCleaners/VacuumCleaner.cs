using System;

namespace Project3.VacuumCleaners
{
    public abstract class VacuumCleaner
    {
        public virtual Model model { get; protected set; }
        public Rooms rooms { get; set; }
        public string Title => rooms.ToString();

        public VacuumCleaner(Model model)
        {
            this.model = model;
        }

        public virtual string StartCleaning()
        {
            return "Началась уборка";
        }

        public string StartCleaning(Rooms room)
        {
            return $"Пылесос {model} начал уборку в {room}";
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