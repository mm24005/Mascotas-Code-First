﻿// <auto-generated />
using CFMASCOTASNDMM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CFMascotasNDMM.Migrations
{
    [DbContext(typeof(MascotasContext))]
    partial class MascotasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CFMASCOTASNDMM.Models.Mascotas", b =>
                {
                    b.Property<int>("Idmascotas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idmascotas"));

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Propietario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idmascotas");

                    b.ToTable("mascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
