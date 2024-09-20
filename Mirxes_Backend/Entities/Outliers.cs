namespace Mirxes_Backend.Entities
{
    public class Outliers
    {
        public int Id { get; set; }
        public int PO_Number { get; set; }
        public DateOnly Posting_Date { get; set; }
        public DateOnly Required_Date { get; set; }
        public DateOnly GRN_Date { get; set; }
        public int GRN_to_Post_Date { get; set; }
        public int GRN_to_Required_Date { get; set; }
        public int Required_to_Post_Date { get; set; }
        public string? Vendor { get; set; }
        public string? Country { get; set; }
        public bool Oversea { get; set; }
        public string? Item_Name { get; set; }
        public int Part_No { get; set; }
        public int Quantity { get; set; }
        public DateOnly Date_Exhaustion { get; set; }
        public DateOnly Last_Procurement { get; set; }
        public bool IsDeleted { get; set; }
    }
}
