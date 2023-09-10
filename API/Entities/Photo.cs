using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")] //added just to override the name for this table to make consistent
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}