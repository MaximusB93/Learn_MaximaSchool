using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner<int>
    {
        public override int MaxVolume  => 80;
        public RobotVacuumCleaner(Model karcher)
        {
        }

        public RobotVacuumCleaner(Model model, int dustVolume, int id) : base(model, dustVolume, id)
        {
            this.model = model;
            DustVolume = dustVolume;
        }
        public override string StartCleaning()
        {
            return "Робот пылесос начал уборку";
        }
    }
}