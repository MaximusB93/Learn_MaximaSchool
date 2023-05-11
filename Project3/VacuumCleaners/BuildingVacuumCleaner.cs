using Project3.VacuumCleaners;

namespace Project3
{
    public class BuildingVacuumCleaner : VacuumCleaner
    {
        public string StartCleaning()
        {
            return base.StartCleaning();
        }

        public BuildingVacuumCleaner(Model model) : base(model)
        {
            this.model = model;
        }
    }
}