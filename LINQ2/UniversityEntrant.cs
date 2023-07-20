namespace LINQ2
{
    public class UniversityEntrant
    {
        public string Surname { get; }

        public int YearAdmission { get; }

        public int NumberSchool { get; }
        public int Id { get; }

        public UniversityEntrant(string surname, int yearAdmission, int numberSchool,int id)
        {
            Surname = surname;
            YearAdmission = yearAdmission;
            NumberSchool = numberSchool;
            Id = id;
        }
    }
}