using System;
using Project3.VacuumCleaners;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            VacuumCleaner[] vacuumCleaners =
                { new BuildingVacuumCleaner(), new RobotVacuumCleaner(), new WashingVacuumCleaner() };
            
          
            foreach (var element in vacuumCleaners)
            {
                element.StartCleaning("Комната");
            }
            
            
            
            
            
            
            
            /*Console.WriteLine("Какой пылесос выберем?");
            for (int i = 0; i < vacuumCleaners.Length; i++)
            {
                Console.WriteLine($"{i+1}) {vacuumCleaners[i]}");  
            }
            
            Console.WriteLine("Какую комнату желаете убрать?");
            for (int i = 0; i < ; i++)
            {
                Console.WriteLine($"{i+1}) {vacuumCleaners[i]}");  
            }

            int VacuumCleanerType = Int32.Parse(Console.ReadLine());

            switch (VacuumCleanerType)
            {
                case 1:
                    RobotVacuumCleaner RobotVacuumCleaner = new RobotVacuumCleaner() ;
                    break;
            }*/
            
        }
    }
}