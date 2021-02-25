using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryListItem
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreateUtc { get; set; }
    }
}
