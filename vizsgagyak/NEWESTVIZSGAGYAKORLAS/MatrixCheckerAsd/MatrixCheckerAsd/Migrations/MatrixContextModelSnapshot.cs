﻿// <auto-generated />
using MatrixCheckerAsd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MatrixCheckerAsd.Migrations
{
    [DbContext(typeof(MatrixContext))]
    partial class MatrixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MatrixCheckerAsd.Models.Matrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsIncreasing");

                    b.Property<bool>("IsSquare");

                    b.Property<string>("MatrixAsString");

                    b.Property<string>("ResultMessage");

                    b.HasKey("Id");

                    b.ToTable("Matrices");
                });
#pragma warning restore 612, 618
        }
    }
}
