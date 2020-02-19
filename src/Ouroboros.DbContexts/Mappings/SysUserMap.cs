using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouroboros.Entities;
using Ouroboros.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.DbContexts.Mappings
{
    /// <summary>
    /// 用户实体映射配置
    /// </summary>
    public class SysUserMap : IEntityTypeConfiguration<SysUser>
    {
        public void Configure(EntityTypeBuilder<SysUser> builder)
        {
            builder.ToTable("sys_user");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.HasIndex(c => c.Account).IsUnique();//指定索引
            builder.Property(c => c.Account).IsRequired().HasMaxLength(16);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Phone).HasMaxLength(25);
            builder.Property(c => c.RoleId).IsRequired();
            builder.Property(c => c.StatusCode).IsRequired().HasDefaultValue(StatusCode.Enable);
            builder.Property(c => c.Creator).IsRequired();
            builder.Property(c => c.CreateTime).IsRequired();
            builder.Property(c => c.Modifier);
            builder.Property(c => c.ModifyTime);

            builder.HasOne(c => c.SysRole);
            //builder.HasQueryFilter(b => b.StatusCode != StatusCode.Deleted);//默认不查询软删除数据
        }
    }
}
