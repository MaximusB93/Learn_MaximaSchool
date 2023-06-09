using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class VacuumCleaner<T>
    {
        public int DustVolume { get; set; }
        public virtual T Id { get; }
        public virtual Model model { get; protected set; }
        public Rooms rooms { get; set; }
        public string Title => rooms.ToString();
        public virtual int MaxVolume { get; }

        public VacuumCleaner()
        {
        }

        public VacuumCleaner(Model model, int dustVolume)
        {
            this.model = model;
            DustVolume = dustVolume;
        }

        public virtual string StartCleaning()
        {
            return "Началась уборка";
        }

        public string StartCleaning(Rooms room)
        {
            
            if (DustVolume > MaxVolume)
            {
                throw new ExceedingMaximumDustVolume(DustVolume,MaxVolume);
            }
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