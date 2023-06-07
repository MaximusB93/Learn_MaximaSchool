using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner
    {
        public override int MaxVolume  => 80;
        public RobotVacuumCleaner()
        {
        }

        public RobotVacuumCleaner(Model model, int dustVolume) : base(model, dustVolume)
        {
            this.model = model;
        }
        public override string StartCleaning()
        {
            return "Робот пылесос начал уборку";
        }
    }
}