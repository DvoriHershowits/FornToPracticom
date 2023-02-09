using Repositories.Entity;

namespace WebApi.Models
{
    public class ChildModel
    {
        public string? IdNumberChild { get; set; }

        public string? Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? IdParent { get; set; }

    }
}
