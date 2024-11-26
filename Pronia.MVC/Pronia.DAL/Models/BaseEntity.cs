namespace Pronia.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastMOdifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IdDeleted { get; set; }

    }
}
