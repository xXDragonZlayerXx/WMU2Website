using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBustersWMU2WebSite.Models
{
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BeginDateTime { get; set; }
        [MaxLength(50)]
        public string DeadlineDateTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Requirements { get; set; }

    }
}
