using Football.Data.SpecificaitonPattern;

namespace Football.Specification.County
{
    public class CountyById : Specification<Data.Entity.County>
    {
        public CountyById(short id)
        {
            expression = c => c.Id.Equals(id);
        }
    }
}
