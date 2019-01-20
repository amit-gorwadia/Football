using System.ComponentModel.DataAnnotations;

namespace Football.Data.DTO
{
    public class TeamDto
    {        
        [Key]
        public int Id { get; set;}
        [MaxLength(70)]
        public string Name { get; set; }
        [MaxLength(2)]
        public int County_Id { get; set; }
    }
}
