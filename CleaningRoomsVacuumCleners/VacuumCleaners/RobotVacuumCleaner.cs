using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner
    {
        public RobotVacuumCleaner()
        {
        }

        public RobotVacuumCleaner(Model model) : base(model)
        {
            this.model = model;
        }
        public override string StartCleaning()
        {
            return "Робот пылесос начал уборку";
        }
    }
}