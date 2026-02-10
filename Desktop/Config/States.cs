namespace Desktop.Config;

public static class States
{
    public enum Status
    {
        Active = 1,
        Frozen = 2,
        Banned = 3
    }
    
    public enum Roles
    {
        Admin = 1,
        Specialist = 2,
        Guest = 3
    }
}