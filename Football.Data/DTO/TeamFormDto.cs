using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Football.Data.DTO
{
    public class TeamFormDto
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public IEnumerable<MatchResultDto> MatchResults { get; set; }
        public StringBuilder AggregateHomeScore { get; set; }
        public StringBuilder AggregateAwayScore { get; set; }
    }
}
