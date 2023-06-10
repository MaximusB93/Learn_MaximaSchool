using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    public class WashingVacuumCleaner : VacuumCleaner<string>
    {
        public override int MaxVolume  => 90;
        public WashingVacuumCleaner(Model samsung)
        {
        }

        public WashingVacuumCleaner(Model model, int dustVolume, string id) : base(model, dustVolume, id)
        {
            this.model = model;
        }

        public new string StartCleaning(Rooms room)
        {
            return $"Моющий пылесос начал уборку в {room}";
        }
    }
}