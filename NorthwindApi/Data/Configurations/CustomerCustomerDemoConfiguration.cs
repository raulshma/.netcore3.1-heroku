// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthwindApi.Data;
using NorthwindApi.Models;
using System;


namespace NorthwindApi.Data.Configurations
{
    public partial class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> entity)
        {
            entity.HasKey(e => new { e.CustomerId, e.CustomerTypeId })
                .HasName("customer_customer_demo_pkey");

            entity.ToTable("customer_customer_demo");

            entity.Property(e => e.CustomerId)
                .HasColumnName("customer_id")
                .HasColumnType("char");

            entity.Property(e => e.CustomerTypeId)
                .HasColumnName("customer_type_id")
                .HasColumnType("char");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CustomerCustomerDemo> entity);
    }
}
