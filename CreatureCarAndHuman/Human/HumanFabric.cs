namespace CreatureCarAndHuman
{
    public class HumanFabric
    {
        private static int _number;
        
        public static int Number
        {
            get => _number;
            set => _number = value;
        }
        
        /// <summary>
        /// Счетчик
        /// </summary>
        /// <returns></returns>
        public static int GetNumber()
        {
            return _number;
        }
    }
}