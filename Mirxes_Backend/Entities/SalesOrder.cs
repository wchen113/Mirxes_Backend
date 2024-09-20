namespace Mirxes_Backend.Entities
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public string? CustCode { get; set; }
        public string? CustName { get; set; }
        public string? SalesType { get; set; }
        public int SONo { get; set; }
        public string? RowStatus { get; set; }
        public string? CustomerRefNo { get; set; }
        public DateOnly PostingDate { get; set; }
        public DateOnly POReceivedDate { get; set; }
        public string? TurnaroundDays { get; set; }
        public string? ItemNo { get; set; }
        public string? ItemServiceDescription { get; set; }
        public int Department { get; set; }
        public DateOnly? RowDeliveryDate { get; set; }
        public DateOnly? CommittedDelDate { get; set; }
        public string? Unit { get; set; }
        public decimal QtyOrdered { get; set; }
        public decimal Delivered { get; set; }
        public int BackOrderQty { get; set; }
        public decimal FulfillmentRate { get; set; }
        public string? ShiptoCode { get; set; }
        public string? ShipTo { get; set; }
        public int? EstimatedLeadTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
