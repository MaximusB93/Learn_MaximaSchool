using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    public class BuildingVacuumCleaner : VacuumCleaner
    {
        public override string StartCleaning()
        {
            return base.StartCleaning();
        }
        public BuildingVacuumCleaner()
        {
        }

        public BuildingVacuumCleaner(Model model) : base(model)
        {
            this.model = model;
        }
        
    }
}