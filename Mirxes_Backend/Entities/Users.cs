namespace Mirxes_Backend.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Role { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
