using System;
using Football.Data.SpecificaitonPattern;

namespace Football.Specification.Team
{
    public class TeamByName : Specification<Data.Entity.Team>
    {
        public TeamByName(string description)
        {
            expression = t => t.Name.Equals(description, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
