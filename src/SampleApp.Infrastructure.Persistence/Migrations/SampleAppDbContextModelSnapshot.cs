﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleApp.Infrastructure.Persistence;

#nullable disable

namespace SampleApp.Infrastructure.Persistence.Migrations;

[DbContext(typeof(SampleAppDbContext))]
partial class SampleAppDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

        modelBuilder.Entity("SampleApp.Infrastructure.Persistence.Models.User", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("TEXT");

            b.Property<string>("FirstName")
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("TEXT");

            b.Property<string>("LastName")
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("TEXT");

            b.Property<ushort>("YearOfBirth")
                .HasColumnType("INTEGER");

            b.HasKey("Id");

            b.ToTable("Users");
        });
#pragma warning restore 612, 618
    }
}