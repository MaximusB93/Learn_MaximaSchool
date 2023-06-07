using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class VacuumCleaner
    {
        private int DustVolume;
        public virtual Model model { get; protected set; }
        public Rooms rooms { get; set; }
        public string Title => rooms.ToString();
        public virtual int MaxVolume { get;}
        
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
            return $"Пылесос {model} начал уборку в {room}";
        }

        public void CheckingVolumeDustInRoom()
        {
            if (DustVolume > MaxVolume)
            {
                throw new ExceedingMaximumDustVolume();
            }
            return;
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