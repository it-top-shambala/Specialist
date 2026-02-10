namespace Desktop.Model;

public class InfoUser
{
    public int Id {set;get;}
    public string Name {set;get;}
    public string LastName {set;get;}
    public string? Sex {set;get;}
    public DateOnly? Birthday {set;get;}
    public string? Phone {set;get;}

    public InfoUser(
        int id, 
        string name, 
        string lastName, 
        string sex, 
        DateOnly birthday, 
        string phone)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Sex = sex;
        Birthday = birthday;
        Phone = phone;
    }
    
    public InfoUser(
        int id, 
        string name, 
        string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
}