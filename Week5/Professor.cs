namespace Week5
{
    public class Professor : UniversityMember
    {
        public Professor(string name, string memberId) : base(name, memberId) { }

        public override void PerformDuties()
        {
            base.PerformDuties();
            ActionLog.Add("Lecture delivered");
        }

        public void ConductResearch(string topic)
        {
            ActionLog.Add($"Research conducted: {topic}");
        }
    }
}