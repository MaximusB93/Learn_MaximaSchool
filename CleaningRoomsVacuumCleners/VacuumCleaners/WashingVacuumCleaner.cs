using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    public class WashingVacuumCleaner : VacuumCleaner<string>
    {
        public override int MaxVolume  => 90;
        public WashingVacuumCleaner(Model samsung)
        {
        }

        public WashingVacuumCleaner(Model model, int dustVolume) : base(model, dustVolume)
        {
            this.model = model;
        }

        public new string StartCleaning(Rooms room)
        {
            return $"Моющий пылесос начал уборку в {room}";
        }
    }
}