using System;

namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Reason { get; }
        public string Code { get; }

        protected CreateActivityRejected()
        {
        }

        public CreateActivityRejected(Guid id, Guid userId, string category, string description, string name,
            DateTime createdAt, string reason, string code)
        {
            Id = id;
            UserId = userId;
            Name = Name;
            Category = category;
            Description = description;
            CreatedAt = createdAt;
            Reason = reason;
            Code = code;
        }
    }
}
