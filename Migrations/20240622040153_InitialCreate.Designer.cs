﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using learning_management_system.Data;

#nullable disable

namespace learning_management_system.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240622040153_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("learning_management_system.Models.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompletionTime")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DisplayImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfRatings")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("learning_management_system.Models.SubsectionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Subsections");
                });

            modelBuilder.Entity("learning_management_system.Models.UserCourse", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("UserCourse");
                });

            modelBuilder.Entity("learning_management_system.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("learning_management_system.Models.VideoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("SubsectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SubsectionId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("learning_management_system.Models.SubsectionModel", b =>
                {
                    b.HasOne("learning_management_system.Models.CourseModel", "Course")
                        .WithMany("Subsections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("learning_management_system.Models.UserCourse", b =>
                {
                    b.HasOne("learning_management_system.Models.CourseModel", "Course")
                        .WithMany("UserCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("learning_management_system.Models.UserModel", "User")
                        .WithMany("UserCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("learning_management_system.Models.VideoModel", b =>
                {
                    b.HasOne("learning_management_system.Models.SubsectionModel", "Subsection")
                        .WithMany("Videos")
                        .HasForeignKey("SubsectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subsection");
                });

            modelBuilder.Entity("learning_management_system.Models.CourseModel", b =>
                {
                    b.Navigation("Subsections");

                    b.Navigation("UserCourses");
                });

            modelBuilder.Entity("learning_management_system.Models.SubsectionModel", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("learning_management_system.Models.UserModel", b =>
                {
                    b.Navigation("UserCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
