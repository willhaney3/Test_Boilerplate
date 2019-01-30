﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Boilerplate.EntityFrameworkCore;

namespace Test_Boilerplate.Migrations
{
    [DbContext(typeof(Test_BoilerplateDbContext))]
    [Migration("20190102225352_Items")]
    partial class Items
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_Boilerplate.Model.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ItemId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("PersonId");

                    b.Property<string>("ItemName");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Test_Boilerplate.Model.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Test_Boilerplate.Model.Item", b =>
                {
                    b.HasOne("Test_Boilerplate.Model.Person", "Person")
                        .WithMany("Items")
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
