namespace dotnet_api.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string Action { get; set; } = string.Empty;  // WHAT action? (example : Create, Delete, Login, ChangePassword)
        public string Entity { get; set; } = string.Empty;  // TARGET object or table that was affected by the action (example : UserAccount, Product, Invoice)
        public string UserId { get; set; } = string.Empty;  // WHO did the action
        public DateTime CreatedAt { get; set; }             // WHEN
    }
}
