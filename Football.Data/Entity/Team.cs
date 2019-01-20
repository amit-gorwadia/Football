using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Football.Data.Entity
{
    public class Team
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(70)]
        public string Name { get; set; }
        [Required]
        public County TeamCounty { get; set; }
        
    }
}
