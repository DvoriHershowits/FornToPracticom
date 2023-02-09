using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto_s
{
    public class ChildDto
    {
        public int Id { get; set; }

        public string? IdNumberChild { get; set; }

        public string? Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? IdParent { get; set; }

        public virtual ParentDto? IdParentNavigation { get; set; }
    }
}
