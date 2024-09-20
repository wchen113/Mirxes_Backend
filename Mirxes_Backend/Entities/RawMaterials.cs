namespace Mirxes_Backend.Entities
{
    public class RawMaterials
    {
        public int Id { get; set; }
        public string? PartNo { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
