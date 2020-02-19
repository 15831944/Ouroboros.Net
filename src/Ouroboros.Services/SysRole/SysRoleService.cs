using AutoMapper;
using Ouroboros.Common.IDCode.Snowflake;
using Ouroboros.DbContexts;
using Ouroboros.Entities;
using Ouroboros.Models.Core;
using Ouroboros.Models.ViewModel;
using Ouroboros.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ouroboros.Services
{
    public class SysRoleService : BaseService, ISysRoleService
    {
        public SysRoleService(IUnitOfWork<MSDbContext> unitOfWork, IMapper mapper, IdWorker idWorker) : base(unitOfWork, mapper, idWorker)
        {
        }

        public async Task<ExecuteResult<SysRole>> Create(SysRoleViewModel viewModel)
        {
            ExecuteResult<SysRole> result = new ExecuteResult<SysRole>();
            //检查字段
            if (viewModel.CheckField(ExecuteType.Create, _unitOfWork) is ExecuteResult checkResult && !checkResult.IsSucceed)
            {
                return result.SetFailMessage(checkResult.Message);
            }
            using (var tran = _unitOfWork.BeginTransaction())//开启一个事务
            {
                SysRole newRow = _mapper.Map<SysRole>(viewModel);
                newRow.Id = _idWorker.NextId();//获取一个雪花Id
                newRow.Creator = 1219490056771866624;//由于暂时还没有做登录，所以拿不到登录者信息，先随便写一个后面再完善
                newRow.CreateTime = DateTime.Now;
                _unitOfWork.GetRepository<SysRole>().Insert(newRow);
                await _unitOfWork.SaveChangesAsync();
                await tran.CommitAsync();//提交事务

                result.SetData(newRow);//添加成功，把新的实体返回回去
            }
            return result;
        }

        public Task<ExecuteResult> Delete(SysRoleViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ExecuteResult> Update(SysRoleViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
