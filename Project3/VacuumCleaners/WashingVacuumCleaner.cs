using Project3.VacuumCleaners;

namespace Project3
{
    public class WashingVacuumCleaner : VacuumCleaner
    {
        public WashingVacuumCleaner()
        {
        }

        public WashingVacuumCleaner(Model model) : base(model)
        {
            this.model = model;
        }

        public new string StartCleaning(Rooms room)
        {
            return $"Моющий пылесос начал уборку в {room}";
        }
    }
}