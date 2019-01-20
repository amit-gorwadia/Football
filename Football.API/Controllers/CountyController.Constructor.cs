using Football.API.Context;
using Football.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.API.Controllers
{
    [Route("api/County")]
    public partial class CountyController : Controller
    {
        TeamForm teamForm;
        public CountyController()
        {
            teamForm = new TeamForm(new TeamFormContext());
        }
    }
}
