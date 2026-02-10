using Desktop.Config;

namespace Desktop.Model;

public class Roles
{
    public int Id {set;get;}
    public string NameRole {set;get;}

    public Roles(int id = (int)States.Roles.Specialist, string nameRole = "Specialist")
    {
        Id = id;
        NameRole = nameRole;
    }
}