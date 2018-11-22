﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181122122116_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp1.EditorOptionsBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EditorType");

                    b.Property<bool>("ReadOnly");

                    b.HasKey("Id");

                    b.ToTable("EditorOptionsBase");

                    b.HasDiscriminator<int>("EditorType");
                });

            modelBuilder.Entity("ConsoleApp1.EditorOptionsCalendar", b =>
                {
                    b.HasBaseType("ConsoleApp1.EditorOptionsBase");


                    b.ToTable("EditorOptionsCalendar");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("ConsoleApp1.EditorOptionsNumberBox", b =>
                {
                    b.HasBaseType("ConsoleApp1.EditorOptionsBase");

                    b.Property<string>("Format");

                    b.Property<string>("Mask");

                    b.ToTable("EditorOptionsNumberBox");

                    b.HasDiscriminator().HasValue(7);
                });

            modelBuilder.Entity("ConsoleApp1.EditorOptionsTextArea", b =>
                {
                    b.HasBaseType("ConsoleApp1.EditorOptionsBase");

                    b.Property<string>("Mask")
                        .HasColumnName("EditorOptionsTextArea_Mask");

                    b.Property<int?>("MaxLength");

                    b.ToTable("EditorOptionsTextArea");

                    b.HasDiscriminator().HasValue(14);
                });

            modelBuilder.Entity("ConsoleApp1.EditorOptionsTextBox", b =>
                {
                    b.HasBaseType("ConsoleApp1.EditorOptionsBase");

                    b.Property<string>("Mask")
                        .HasColumnName("EditorOptionsTextBox_Mask");

                    b.ToTable("EditorOptionsTextBox");

                    b.HasDiscriminator().HasValue(15);
                });
#pragma warning restore 612, 618
        }
    }
}