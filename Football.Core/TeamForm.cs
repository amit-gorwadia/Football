using System;
using System.Collections.Generic;
using System.Linq;
using Football.Data.Entity;
using Football.Data.RepositoryPattern;
using Football.Data.RepositoryPattern.Interface;
using Microsoft.EntityFrameworkCore;
using Football.Specification.County;
using System.Threading.Tasks;

namespace Football.Core
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class TeamForm
    {
        private IRepository<County> CountyReposiotry;
        private IRepository<Team> TeamRepository;
        private IRepository<MatchResult> MatchResultRepository;
        private IRepository<TeamForm> TeamFormRepository;      

        public TeamForm(DbContext context)
        {            
            CountyReposiotry = new Repository<County>(context);
            TeamRepository = new Repository<Team>(context);
            MatchResultRepository = new Repository<MatchResult>(context);
        }        

        public async Task<IEnumerable<County>> GetAllCounties()
        {
            var result = await CountyReposiotry.GetAllAsync();
            return result.Any() ? result : null;
        }

        public async Task<County> GetCountyById(short id)
        {
            return await CountyReposiotry.GetSingleOrDefaultAsync(new CountyById(id));
        }
    }
}
