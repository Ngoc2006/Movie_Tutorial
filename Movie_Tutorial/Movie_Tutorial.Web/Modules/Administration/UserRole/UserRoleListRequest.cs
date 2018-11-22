
namespace Movie_Tutorial.Administration
{
    using Serenity.Services;

    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}