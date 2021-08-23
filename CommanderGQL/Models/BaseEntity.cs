using System;

namespace CommanderGQL.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreatedBy = "Vini";
            this.UpdatedBy = "Vini";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public string CreatedBy { get; private set; }
        public string UpdatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}