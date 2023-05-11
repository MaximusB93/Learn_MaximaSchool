using System;

namespace Project3.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner
    {

        public RobotVacuumCleaner(Model model) : base(model)
        {
            this.model = model;
        }

    }
}