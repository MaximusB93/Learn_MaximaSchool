namespace CleaningRoomsVacuumCleners.VacuumCleaners
{
    public interface IVacuumCleanerName<T>
    {
        public virtual T Id
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}