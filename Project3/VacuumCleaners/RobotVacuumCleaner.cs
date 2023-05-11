using System;

namespace Project3.VacuumCleaners
{
    public class RobotVacuumCleaner : VacuumCleaner

    {
        public override Model model { get; }

        public override string StartCleaning()
        {
            return $"Пылесос {model} начал уборку в {rooms}";
        }
    }
}