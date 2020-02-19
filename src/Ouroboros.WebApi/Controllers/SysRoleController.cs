using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ouroboros.Models.Core;
using Ouroboros.Models.ViewModel;
using Ouroboros.Services;

namespace Ouroboros.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysRoleController : ControllerBase
    {
        private readonly ISysRoleService _sysRoleService;

        public SysRoleController(ISysRoleService roleService)
        {
            _sysRoleService = roleService;
        }

        [HttpPost]
        public async Task<ExecuteResult> Post(SysRoleViewModel viewModel)
        {
            return await _sysRoleService.Create(viewModel);
        }

        [HttpPut]
        public async Task<ExecuteResult> Put(SysRoleViewModel viewModel)
        {
            return await _sysRoleService.Update(viewModel);
        }

        [HttpDelete]
        public async Task<ExecuteResult> Delete(long id)
        {
            return await _sysRoleService.Delete(new SysRoleViewModel { Id = id });
        }

    }
}