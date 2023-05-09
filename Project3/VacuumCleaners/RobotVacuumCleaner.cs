using System;

namespace Project3.VacuumCleaners
{
    public class RobotVacuumCleaner: VacuumCleaner
    
    {
        public override Model model { get; }
        public override void StartCleaning()
        {
            Console.WriteLine($"Пылесос {model} начал уборку в {rooms} ");
        }
    }
}