using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ouroboros.Models.Core;
using Ouroboros.Models.ViewModel;

namespace Ouroboros.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysRoleController : ControllerBase
    {
        [HttpPost]
        public async Task<ExecuteResult> Post(SysRoleViewModel viewModel)
        {
            return new ExecuteResult();
        }
    }
}