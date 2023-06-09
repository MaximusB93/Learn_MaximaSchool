using System;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner<string>
    {
        
        public override string Id { get; }
        public override int MaxVolume  => 80;
        public RobotVacuumCleaner(Model karcher)
        {
        }

        public RobotVacuumCleaner(Model model, int dustVolume) : base(model, dustVolume)
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