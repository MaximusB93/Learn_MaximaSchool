using System;
using System.Runtime.Serialization;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class ExceedingMaximumDustVolume : Exception
    {
        private int _dustVolume;
        private int _maxVolume;

        public ExceedingMaximumDustVolume(int dustVolume, int maxVolume)
        {
            _dustVolume = dustVolume;
            _maxVolume = maxVolume;
        }

        public override string Message =>
            $"Ошибка. Количество пыли в комнате {_dustVolume}, а пылесос потребляет не более {_maxVolume}";
    }
}