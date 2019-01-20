using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Football.Data.Entity
{
    public class TeamForm
    {        
        [Key]
        public int Id { get; set; }
        public int Team_Id { get; set; }
        public IEnumerable<MatchResult> MatchResults { get; set; }
        public StringBuilder AggregateHomeScore { get; set; }
        public StringBuilder AggregateAwayScore { get; set; }
    }
}
