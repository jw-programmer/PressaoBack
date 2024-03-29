﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Src.Context;

#nullable disable

namespace Pressao.Migrations
{
    [DbContext(typeof(PressaoContext))]
    partial class PressaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Src.Domain.PressaoArterial", b =>
                {
                    b.Property<long?>("PressaoArterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassificaoMedida")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataMedicao")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PressaoArterialDiastalica")
                        .HasColumnType("decimal(3,2)");

                    b.Property<decimal>("PressaoArterialSistolica")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("PressaoArterialId");

                    b.ToTable("PressoesArteriais");
                });
#pragma warning restore 612, 618
        }
    }
}
