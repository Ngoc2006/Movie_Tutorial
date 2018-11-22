using Serenity.Services;

namespace Movie_Tutorial.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}