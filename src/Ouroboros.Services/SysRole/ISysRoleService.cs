using Ouroboros.Models.Core;
using Ouroboros.Models.ViewModel;
using Ouroboros.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ouroboros.Services
{
    public interface ISysRoleService : IBaseService
    {
        Task<ExecuteResult<SysRole>> Create(SysRoleViewModel viewModel);
        Task<ExecuteResult> Update(SysRoleViewModel viewModel);
        Task<ExecuteResult> Delete(SysRoleViewModel viewModel);
    }

}
