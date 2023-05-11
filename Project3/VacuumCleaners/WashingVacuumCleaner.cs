using Project3.VacuumCleaners;

namespace Project3
{
    public class WashingVacuumCleaner: VacuumCleaner
    {
            public new string StartCleaning()
            {
                return "Запуск пылесоса";
            }
            
            public WashingVacuumCleaner (Model model) : base(model)
            {
                this.model = model;
            }
    }
}