using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto_s
{
    public class ParentDto
    {
        public int Id { get; set; }

        public string? IdNumberParent { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string? MaleOrFemale { get; set; }

        public string? Hmo { get; set; }

        public virtual ICollection<ChildDto> Children { get; } = new List<ChildDto>();
    }
}
