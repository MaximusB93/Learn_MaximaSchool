using System;
using System.Collections.Generic;
using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            var rand = new Random();

            VacuumCleaner<string>[] StrVacuumCleaners =
            {
                new BuildingVacuumCleaner(Model.Bosch, 70, "Vaccum01"),
                new WashingVacuumCleaner(Model.Samsung, 100, "Vaccum02")
            };
            VacuumCleaner<int>[] IntVacuumCleaners =
            {
                new RobotVacuumCleaner(Model.Karcher, 90, 03),
            };

            foreach (var vacuumCleaner in StrVacuumCleaners)

                try
                {
                    Console.WriteLine(
                        vacuumCleaner.StartCleaning(Rooms.Bathroom));
                }
                catch (ExceedingMaximumDustVolume e)
                {
                    Console.WriteLine(e.Message);
                }

            Console.WriteLine("____________________");
            Console.ReadLine();
        }
    }
}