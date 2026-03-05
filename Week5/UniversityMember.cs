namespace Week5;

public class UniversityMember
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? throw new Exception("Invalid Name") : value;
    }
    public string MemberId { get;  }
    protected List<string> ActionLog { get; set; }
    
    public virtual void PerformDuties()
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("You reached limit");
        }
    }
    
    
}