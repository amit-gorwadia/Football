using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Football.Data.Entity
{
    public class MatchResult
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Team_A { get; set; }
        [Required]
        public int Team_B { get; set; }
        [Required]
        public short Team_A_Score { get; set; }
        [Required]
        public short Team_B_Score { get; set; }
        public Score HomeScore { get; set; }
        public Score AwayScore { get; set; }
    }
}
