using Football.Data.SpecificaitonPattern;
namespace Football.Specification.Team
{
    public class TeamById : Specification<Data.Entity.Team>
    {
        public TeamById(int id)
        {
            expression = t => t.Id.Equals(id);
        }
    }
}
