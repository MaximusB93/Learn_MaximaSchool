using System;
using CleaningRoomsVacuumCleners.VacuumCleaners;

namespace CleaningRoomsVacuumCleners
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultMethod();
            OverloadMethod();
            HiddenMethod();
        }

        //Метод по умолчанию
        private static void DefaultMethod()
        {
            VacuumCleaner[] vacuumCleaners2 =
                { new BuildingVacuumCleaner(), new RobotVacuumCleaner(), new WashingVacuumCleaner() };
            foreach (var vacuumCleaner in vacuumCleaners2)
                Console.WriteLine(vacuumCleaner.StartCleaning());

            Console.WriteLine("____________________");
        }

        //Перегрузка метода StartCleaning
        private static void OverloadMethod()
        {
            var rand = new Random();
            VacuumCleaner[] vacuumCleaners =
            {
                new BuildingVacuumCleaner(Model.Bosch), new RobotVacuumCleaner(Model.Karcher),
                new WashingVacuumCleaner(Model.Samsung)
            };
            foreach (var vacuumCleaner in vacuumCleaners)
                Console.WriteLine(
                    vacuumCleaner.StartCleaning((Rooms)Enum.GetValues(typeof(Rooms)).GetValue(rand.Next(4))));

            Console.WriteLine("____________________");
        }

        //Скрытый метод
        private static void HiddenMethod()
        {
            WashingVacuumCleaner washingVacuumCleaner = new WashingVacuumCleaner();
            Console.WriteLine(washingVacuumCleaner.StartCleaning(Rooms.Childish));
        }
    }
}