using System.Collections.Generic;
namespace Week5
{
    public class UniversityMember
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = string.IsNullOrWhiteSpace(value) ? throw new System.Exception("Invalid Name") : value;
        }
        
        public string MemberId { get; }
        protected List<string> ActionLog;
        public int ActionsCount => ActionLog.Count;

        public UniversityMember(string name, string memberId)
        {
            Name = name;
            MemberId = memberId;
            ActionLog = new List<string>();
        }

        public virtual void PerformDuties()
        {
            if (ActionLog.Count >= 5)
            {
                throw new System.Exception("Daily action limit reached");
            }
        }
    }
}