using Desktop.Config;

namespace Desktop.Model;

public class Statuses
{
    public int Id {set;get;}
    public string Name {set;get;}
    
    public Statuses(int id = (int)States.Status.Active, string name = "Active")
    {
        Id = id;
        Name = name;
    }
}