using System.Collections.Generic;
namespace Week5
{
    public class UniversityRegistry
    {
        private List<UniversityMember> members = new List<UniversityMember>();
        public void AddMember(UniversityMember um)
        {
            members.Add(um);
        }
        public void ExecuteAllDuties()
        {
            foreach (var member in members)
            {
                member.PerformDuties();
            }
        }
        public string GetMemberStatistics()
        {
            int total = 0;
            foreach (var um in members)
            {
                total += um.ActionsCount;
            }
            return $"Total actions: {total}";
        }
    }
}