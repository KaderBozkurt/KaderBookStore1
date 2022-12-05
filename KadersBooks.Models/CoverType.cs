using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace KadersBooks.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "CoverType Name")]
     
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
