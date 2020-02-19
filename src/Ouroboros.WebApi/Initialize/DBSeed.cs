using Ouroboros.Common.Security;
using Ouroboros.DbContexts;
using Ouroboros.Entities;
using Ouroboros.Entities.Core;
using Ouroboros.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ouroboros.WebApi
{
    public static class DBSeed
    {
        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <returns>返回是否创建了数据库（非迁移）</returns>
        public static bool Initialize(IUnitOfWork<MSDbContext> unitOfWork)
        {
            bool isCreateDb = false;
            //直接自动执行迁移,如果它创建了数据库，则返回true
            if (unitOfWork.DbContext.Database.EnsureCreated())
            {
                isCreateDb = true;
                //打印log-创建数据库及初始化期初数据

                long rootUserId = 1219490056771866624;

                #region 角色、用户、登录
                SysRole rootRole = new SysRole
                {
                    Id = 1219490056771866625,
                    Name = "SuperAdmin",
                    DisplayName = "超级管理员",
                    Remark = "系统内置超级管理员",
                    Creator = rootUserId,
                    CreateTime = DateTime.Now
                };
                SysUser rootUser = new SysUser
                {
                    Id = rootUserId,
                    Account = "admin",
                    Name = "admin",
                    RoleId = rootRole.Id,
                    StatusCode = StatusCode.Enable,
                    Creator = rootUserId,
                    CreateTime = DateTime.Now,
                };

                unitOfWork.GetRepository<SysRole>().Insert(rootRole);
                unitOfWork.GetRepository<SysUser>().Insert(rootUser);
                unitOfWork.GetRepository<SysUserLogin>().Insert(new SysUserLogin
                {
                    UserId = rootUserId,
                    Account = rootUser.Account,
                    HashedPassword = CryptoHelper.HashPassword(rootUser.Account),//默认密码同账号名
                    IsLocked = false
                });
                unitOfWork.SaveChanges();

                #endregion
            }

            return isCreateDb;
        }

    }
}
