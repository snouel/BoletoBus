namespace BoletoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        protected AuditableEntity()
        {
            CreationDate = DateTime.Now;
            Deleted = false;
        }

        public int CreationUser { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int? UserMod { get; set; }

        public int? UserDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool Deleted { get; set; }

    }
}
