namespace Desktop.Model;

public class Users
{
    public int Id {get; set;}
    public int? InfoId {get; set;}
    public string Email {get; set;}
    public string Password {get; set;}
    public string Description {get; set;}
    public string Education {get; set;}
    public string Practice {get; set;}
    public int StatusId {get; set;}

    public Users(
        int id, 
        int infoId, 
        string email, 
        string password, 
        string description, 
        string education, 
        string practice,
        int statusId)
    {
        Id = id;
        InfoId = infoId;
        Email = email;
        Password = password;
        Description = description;
        Education = education;
        Practice = practice;
        StatusId = statusId;
    }
    
    public Users(
        int id,
        string email, 
        string password,
        int statusId)
    {
        Id = id;
        Email = email;
        Password = password;
        StatusId = statusId;
    }
}