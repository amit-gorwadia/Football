using Football.Data.SpecificaitonPattern;

namespace Football.Specification.MatchResult
{
    public class MatchResultByTeam : Specification<Data.Entity.MatchResult>
    {
        public MatchResultByTeam(int id)
        {
            expression = m => m.Team_A.Equals(id) || m.Team_B.Equals(id);
        }
    }
}
