using System;
using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadMethod();
            /*DefaultMethod();
            HiddenMethod();*/
        }

        //Метод по умолчанию
        /*private static void DefaultMethod()
        {
            VacuumCleaner[] vacuumCleaners2 =
                { new BuildingVacuumCleaner(), new RobotVacuumCleaner(), new WashingVacuumCleaner() };
            foreach (var vacuumCleaner in vacuumCleaners2)
                Console.WriteLine(vacuumCleaner.StartCleaning());

            Console.WriteLine("____________________");
        }*/

        //Перегрузка метода StartCleaning
        private static void OverloadMethod()
        {
            var rand = new Random();
            VacuumCleaner[] vacuumCleaners =
            {
                new BuildingVacuumCleaner(Model.Bosch, 70), new RobotVacuumCleaner(Model.Karcher, 90),
                new WashingVacuumCleaner(Model.Samsung, 100)
            };


            foreach (var vacuumCleaner in vacuumCleaners)

                try
                {
                    Console.WriteLine(
                        vacuumCleaner.StartCleaning(Rooms.Bathroom));
                    /*Console.WriteLine(
                        vacuumCleaner.StartCleaning((Rooms)Enum.GetValues(typeof(Rooms)).GetValue(rand.Next(4))));*/
                }
                catch (ExceedingMaximumDustVolume e)
                {
                    Console.WriteLine(e.Message);
                }
            
            Console.WriteLine("____________________");
            Console.ReadLine();
        }

        //Скрытый метод
        /*private static void HiddenMethod()
        {
            WashingVacuumCleaner washingVacuumCleaner = new WashingVacuumCleaner();
            Console.WriteLine(washingVacuumCleaner.StartCleaning(Rooms.Childish));
        }*/
    }
}