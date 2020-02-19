using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouroboros.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.DbContexts.Mappings
{
    /// <summary>
    /// 密码实体映射配置
    /// </summary>
    public class SysUserLoginMap : IEntityTypeConfiguration<SysUserLogin>
    {
        public void Configure(EntityTypeBuilder<SysUserLogin> builder)
        {
            builder.ToTable("sys_user_login");
            builder.HasKey(c => c.Account);
            //builder.Property(c => c.UserId).ValueGeneratedNever();
            builder.Property(c => c.Account).IsRequired().HasMaxLength(20);
            builder.Property(c => c.HashedPassword).IsRequired().HasMaxLength(256);
            builder.Property(c => c.LastLoginTime);
            builder.Property(c => c.AccessFailedCount).IsRequired().HasDefaultValue(0);
            builder.Property(c => c.IsLocked).IsRequired();
            builder.Property(c => c.LockedTime);
            builder.HasOne(c => c.SysUser);
        }

    }
}
