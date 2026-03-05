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
    
     
}