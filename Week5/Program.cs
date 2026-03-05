namespace Week5
{
    public class Program
    {
        public static void Main()
        {
            var universityRegistry = new UniversityRegistry();

            var professor = new Professor("Jane Doe", "552");
            var undergraduateStudent = new UndergraduateStudent("Dylan", "228");
            var graduateStudent = new GraduateStudent("Mykyta Sidorov", "67");

            universityRegistry.AddMember(professor);
            universityRegistry.AddMember(undergraduateStudent);
            universityRegistry.AddMember(graduateStudent);
            
            universityRegistry.ExecuteAllDuties();
            Console.WriteLine(universityRegistry.GetMemberStatistics());
        }
    }
}