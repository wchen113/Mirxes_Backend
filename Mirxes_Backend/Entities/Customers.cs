namespace Mirxes_Backend.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string? CustCode { get; set; }
        public string? CustName { get; set; }
        public string? ShipTo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
