using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouroboros.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.DbContexts.Mappings
{
    /// <summary>
    /// 日志实体映射配置
    /// </summary>
    public class SysLogrecordMap: IEntityTypeConfiguration<SysLogrecord>
    {
        public void Configure(EntityTypeBuilder<SysLogrecord> builder)
        {
            builder.ToTable("sys_logrecord");
            builder.HasKey(c => c.Id);//自增主键
            builder.Property(c => c.LogDate).IsRequired();
            builder.Property(u => u.LogLevel).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Logger).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Message);
            builder.Property(u => u.Exception);
            builder.Property(u => u.MachineName).HasMaxLength(50);
            builder.Property(u => u.MachineIp).HasMaxLength(50);
            builder.Property(u => u.NetRequestMethod).HasMaxLength(10);
            builder.Property(u => u.NetRequestUrl).HasMaxLength(500);
            builder.Property(u => u.NetUserIsauthenticated).HasMaxLength(10);
            builder.Property(u => u.NetUserAuthtype).HasMaxLength(50);
            builder.Property(u => u.NetUserIdentity).HasMaxLength(50);
        }

    }
}
