using Microsoft.OData.Edm;
using Repositories.Entity;

namespace WebApi.Models
{
    public class ParentModel
    {
        public string? IdNumberParent { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? MaleOrFemale { get; set; }

        public string? Hmo { get; set; }

        public virtual ICollection<Child> Children { get; } = new List<Child>();
    }
}
