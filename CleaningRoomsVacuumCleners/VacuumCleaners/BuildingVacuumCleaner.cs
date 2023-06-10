using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    public class BuildingVacuumCleaner : VacuumCleaner<string>
    {
        public override int MaxVolume  => 100;


        public override string StartCleaning()
        {
            return base.StartCleaning();
        }

        public BuildingVacuumCleaner(Model bosch)
        {
        }

        public BuildingVacuumCleaner(Model model, int dustVolume, string id) : base(model, dustVolume, id)
        {
            this.model = model;
        }
    }
}