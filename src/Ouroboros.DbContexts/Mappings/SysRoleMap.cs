﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouroboros.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.DbContexts.Mappings
{
    /// <summary>
    /// 角色实体映射配置
    /// </summary>
    public class SysRoleMap : IEntityTypeConfiguration<SysRole>
    {
        public void Configure(EntityTypeBuilder<SysRole> builder)
        {
            builder.ToTable("sys_role");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.HasIndex(c => c.Name).IsUnique();//指定索引，不能重复
            builder.Property(c => c.Name).IsRequired().HasMaxLength(16);
            builder.Property(c => c.DisplayName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Remark).HasMaxLength(4000);
            builder.Property(c => c.Creator).IsRequired();
            builder.Property(c => c.CreateTime).IsRequired();
            builder.Property(c => c.Modifier);
            builder.Property(c => c.ModifyTime);
            //builder.HasQueryFilter(b => b.StatusCode != StatusCode.Deleted);//默认不查询软删除数据
        }

    }
}
