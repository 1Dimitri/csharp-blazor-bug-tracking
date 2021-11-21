using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(length:10)]
        public string Description { get; set; }

        [Required]
        [Range(maximum:5,minimum:1)]
        public int Priority { get; set; }
    }
}
