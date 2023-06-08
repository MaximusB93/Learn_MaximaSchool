using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    public class BuildingVacuumCleaner : VacuumCleaner
    {
        public override int MaxVolume  => 100;


        public override string StartCleaning()
        {
            return base.StartCleaning();
        }

        public BuildingVacuumCleaner(Model bosch)
        {
        }

        public BuildingVacuumCleaner(Model model, int dustVolume) : base(model, dustVolume)
        {
            this.model = model;
        }
    }
}