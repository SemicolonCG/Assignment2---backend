using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoteText { get; set; }
        public DateTime? CreatedOn { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Reply> Replies { get; set; }
    }
}
