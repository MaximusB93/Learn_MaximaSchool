using System;
using System.Runtime.Serialization;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class ExceedingMaximumDustVolume : Exception
    {
        int DustVolume;
        int MaxVolume;

        public ExceedingMaximumDustVolume(int dustVolume, int maxVolume)
        {
            DustVolume = dustVolume;
            MaxVolume = maxVolume;
        }

        public override string Message =>
            $"Ошибка. Количество пыли в комнате {DustVolume}, а пылесос потребляет не более {MaxVolume}";

        /*public static string MessageException(int dustVolume,int maxVolume)
        {
            return $"Ошибка. Количество пыли в комнате {dustVolume}, а пылесос потребляет не более {maxVolume}";
        }*/
    }
}