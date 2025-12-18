using dotnet_api.Models;

namespace dotnet_api.Services
{
    public class AuditLogService
    {
        private readonly List<AuditLog> _logs = new();
        private int _currentId = 1;
        public void Log(string action, string entity, string userId)
        {
            var log = new AuditLog
            {
                Id = _currentId++,
                Action = action,
                Entity = entity,
                UserId = userId,
                CreatedAt = DateTime.UtcNow
            };
            _logs.Add(log);
        }
        public IReadOnlyList<AuditLog> GetAll()
        {
            return _logs;
        }
        public IReadOnlyList<AuditLog> GetByUser(string userId)
        {
            return _logs.Where(x => x.UserId == userId).ToList();
        }
    }
}
