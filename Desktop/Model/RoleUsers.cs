using Desktop.Config;

namespace Desktop.Model;

public class RoleUsers
{
    public int UserId {set;get;}
    public int RoleId {set;get;}

    public RoleUsers(int userId, int roleId)
    {
        UserId = userId;
        RoleId = roleId;
    }
}