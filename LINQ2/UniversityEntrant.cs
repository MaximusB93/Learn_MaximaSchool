namespace LINQ2
{
    public class UniversityEntrant
    {
        public string Surname { get; }

        public int YearAdmission { get; }

        public int NumberSchool { get; }
        public UniversityEntrant(string surname, int yearAdmission, int numberSchool)
        {
            Surname = surname;
            YearAdmission = yearAdmission;
            NumberSchool = numberSchool;
            
        }
    }
}