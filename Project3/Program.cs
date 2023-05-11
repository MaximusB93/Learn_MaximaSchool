using System;
using Project3.VacuumCleaners;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            VacuumCleaner[] vacuumCleaners =
            {
                new BuildingVacuumCleaner(Model.Bosch),
                new RobotVacuumCleaner(Model.Karcher),
                new WashingVacuumCleaner(Model.Samsung)
            };


            /*foreach (var element in vacuumCleaners)
          {
              Console.WriteLine(element.StartCleaning());
          }*/


            /*Console.WriteLine("Какой пылесос выберем?");
            for (int i = 0; i < vacuumCleaners.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {vacuumCleaners[i]}");
            }*/

            Console.WriteLine("Какую комнату желаете убрать?");
            int number = 1;

            foreach (var room in Enum.GetValues(typeof(Rooms)))
            {
                Console.WriteLine($"{number}) {room}");
                number++;
            }


            var roomIndex = Int32.Parse(Console.ReadLine()) - 1;
            var selectRoom = (Rooms)Enum.GetValues(typeof(Rooms)).GetValue(roomIndex);
            Console.WriteLine(vacuumCleaners[1].StartCleaning(selectRoom));
        }
    }
}