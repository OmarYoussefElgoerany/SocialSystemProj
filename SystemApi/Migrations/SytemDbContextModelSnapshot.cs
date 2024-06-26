﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemApi.SystemDAL.Context;

#nullable disable

namespace SystemApi.Migrations
{
    [DbContext(typeof(SytemDbContext))]
    partial class SytemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "post6",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "post7",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "post8",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "post9",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Good post",
                            PostId = 1,
                            Rate = 4
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Excellent post",
                            PostId = 2,
                            Rate = 5
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Average post",
                            PostId = 3,
                            Rate = 3
                        });
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Name = "story6",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "story7",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "story8",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "story9",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "story10",
                            UserId = 2
                        },
                        new
                        {
                            Id = 11,
                            Name = "story11",
                            UserId = 2
                        },
                        new
                        {
                            Id = 12,
                            Name = "story12",
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            Name = "story13",
                            UserId = 2
                        },
                        new
                        {
                            Id = 14,
                            Name = "story14",
                            UserId = 2
                        },
                        new
                        {
                            Id = 15,
                            Name = "story15",
                            UserId = 3
                        },
                        new
                        {
                            Id = 1,
                            Name = "story1",
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "story2",
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "story3",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "story4",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "story5",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Omar"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Ahmed"
                        },
                        new
                        {
                            Id = 3,
                            UserName = "Karim"
                        });
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Post", b =>
                {
                    b.HasOne("SystemApi.SystemDAL.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Review", b =>
                {
                    b.HasOne("SystemApi.SystemDAL.Models.Post", "Post")
                        .WithMany("Reviews")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Story", b =>
                {
                    b.HasOne("SystemApi.SystemDAL.Models.User", "User")
                        .WithMany("Stories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.Post", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SystemApi.SystemDAL.Models.User", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("Stories");
                });
#pragma warning restore 612, 618
        }
    }
}
