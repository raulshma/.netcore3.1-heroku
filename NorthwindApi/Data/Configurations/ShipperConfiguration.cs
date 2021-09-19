﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthwindApi.Data;
using NorthwindApi.Models;
using System;


namespace NorthwindApi.Data.Configurations
{
    public partial class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> entity)
        {
            entity.ToTable("shippers");

            entity.Property(e => e.ShipperId)
                .HasColumnName("shipper_id")
                .ValueGeneratedNever();

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasColumnName("company_name")
                .HasMaxLength(40);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(24);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Shipper> entity);
    }
}