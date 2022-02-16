using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_RoyceCotcher.Models
{
    public class MovieSubmit
    {
        [Key]
        [Required]
        public uint MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25, ErrorMessage = "25 character max for Notes field")]
        public string Notes { get; set; }
    }
}
