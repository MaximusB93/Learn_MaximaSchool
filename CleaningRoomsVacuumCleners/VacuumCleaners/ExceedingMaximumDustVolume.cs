using System;
using System.Runtime.Serialization;

namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public class ExceedingMaximumDustVolume : ArithmeticException
    {
        public ExceedingMaximumDustVolume()
        {
        }

        protected ExceedingMaximumDustVolume(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ExceedingMaximumDustVolume(string message) : base(message)
        {
        }

        public ExceedingMaximumDustVolume(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}