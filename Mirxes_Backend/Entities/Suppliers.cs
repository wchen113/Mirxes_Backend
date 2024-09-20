namespace Mirxes_Backend.Entities
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string? BPCode { get; set; }
        public string? BPName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? ContactPerson { get; set; }
        public string? Telephone { get; set; }
        //public decimal Lat { get; set; }
        //public decimal Lng { get; set; }
        public bool IsDeleted { get; set; }
    }
}
