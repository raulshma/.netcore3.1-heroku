﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthwindApi.Data;
using NorthwindApi.Models;
using System;


namespace NorthwindApi.Data.Configurations
{
    public partial class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> entity)
        {
            entity.ToTable("suppliers");

            entity.Property(e => e.SupplierId)
                .HasColumnName("supplier_id")
                .ValueGeneratedNever();

            entity.Property(e => e.Address)
                .HasColumnName("address")
                .HasMaxLength(60);

            entity.Property(e => e.City)
                .HasColumnName("city")
                .HasMaxLength(15);

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasColumnName("company_name")
                .HasMaxLength(40);

            entity.Property(e => e.ContactName)
                .HasColumnName("contact_name")
                .HasMaxLength(30);

            entity.Property(e => e.ContactTitle)
                .HasColumnName("contact_title")
                .HasMaxLength(30);

            entity.Property(e => e.Country)
                .HasColumnName("country")
                .HasMaxLength(15);

            entity.Property(e => e.Fax)
                .HasColumnName("fax")
                .HasMaxLength(24);

            entity.Property(e => e.Homepage).HasColumnName("homepage");

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(24);

            entity.Property(e => e.PostalCode)
                .HasColumnName("postal_code")
                .HasMaxLength(10);

            entity.Property(e => e.Region)
                .HasColumnName("region")
                .HasMaxLength(15);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Supplier> entity);
    }
}