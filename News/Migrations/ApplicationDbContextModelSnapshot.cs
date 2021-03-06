// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "70ec2fe3-a512-4a51-8d6f-b29ffbcdefa5",
                            RoleId = "630ad094-1cc5-4792-b683-dc08bac9dafe"
                        },
                        new
                        {
                            UserId = "b0422f26-07b3-40c0-a401-a27118f70dea",
                            RoleId = "b9d2af61-31c9-4145-a879-ebb1350a3d14"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("News.Entities.AcademicYear", b =>
                {
                    b.Property<string>("academicYear_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("academicYear_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("academicYear_DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("academicYear_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("academicYear_StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("academicYear_Id");

                    b.ToTable("AcademicYear");

                    b.HasData(
                        new
                        {
                            academicYear_Id = "8b6ef4fb-7c42-4069-adfb-35d610de445b",
                            academicYear_Description = "AcademicYear1",
                            academicYear_DueTime = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            academicYear_Name = "AcademicYear1",
                            academicYear_StartTime = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            category_Id = "fde8ef51-93cc-4fe7-934f-0f4f1e981ee5",
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "5eceb807-8522-4fe9-85ea-27b98b115b21",
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "0faedb9f-db15-4ec0-b407-b0366b8c7177",
                            category_Description = "Des 3",
                            category_Name = "Category3"
                        });
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            department_Id = "b68cdc3d-ace1-463c-bca3-d3fa290ce01b",
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "e7cafb2e-7af5-47a4-a57d-1e9f09bd6df0",
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "75f6a633-bf18-4fb4-afff-a3ad8246ab87",
                            department_Description = "Department 3",
                            department_Name = "Department 3"
                        });
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_AcademicYearId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_AcademicYearId");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea");

                    b.HasData(
                        new
                        {
                            idea_Id = "ddc75646-bf72-43b9-af77-337924883f04",
                            idea_AcademicYearId = "8b6ef4fb-7c42-4069-adfb-35d610de445b",
                            idea_CategoryId = "fde8ef51-93cc-4fe7-934f-0f4f1e981ee5",
                            idea_Description = "Description1",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "70ec2fe3-a512-4a51-8d6f-b29ffbcdefa5"
                        },
                        new
                        {
                            idea_Id = "acb6a6d3-73ee-41cc-b276-aa0cbd61fde6",
                            idea_AcademicYearId = "8b6ef4fb-7c42-4069-adfb-35d610de445b",
                            idea_CategoryId = "5eceb807-8522-4fe9-85ea-27b98b115b21",
                            idea_Description = "Description2",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "70ec2fe3-a512-4a51-8d6f-b29ffbcdefa5"
                        },
                        new
                        {
                            idea_Id = "9694f352-1e45-4e01-8502-65c1992e59a9",
                            idea_AcademicYearId = "8b6ef4fb-7c42-4069-adfb-35d610de445b",
                            idea_CategoryId = "5eceb807-8522-4fe9-85ea-27b98b115b21",
                            idea_Description = "Description3",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "b0422f26-07b3-40c0-a401-a27118f70dea"
                        });
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.Property<string>("uid_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uid_DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uid_UserId", "uid_DepartmentId");

                    b.HasIndex("uid_DepartmentId");

                    b.ToTable("UserInDepartment");

                    b.HasData(
                        new
                        {
                            uid_UserId = "b0422f26-07b3-40c0-a401-a27118f70dea",
                            uid_DepartmentId = "b68cdc3d-ace1-463c-bca3-d3fa290ce01b"
                        },
                        new
                        {
                            uid_UserId = "70ec2fe3-a512-4a51-8d6f-b29ffbcdefa5",
                            uid_DepartmentId = "e7cafb2e-7af5-47a4-a57d-1e9f09bd6df0"
                        });
                });

            modelBuilder.Entity("News.Entities.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppRole");

                    b.HasData(
                        new
                        {
                            Id = "630ad094-1cc5-4792-b683-dc08bac9dafe",
                            ConcurrencyStamp = "969d69c5-5436-41c8-a8ed-145d766692bf",
                            Name = "staff",
                            Description = "Staff"
                        },
                        new
                        {
                            Id = "b9d2af61-31c9-4145-a879-ebb1350a3d14",
                            ConcurrencyStamp = "9c773e69-3586-477a-9f96-194ecc6e1327",
                            Name = "admin",
                            Description = "Admin"
                        });
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "b0422f26-07b3-40c0-a401-a27118f70dea",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e7b7826-de0f-42da-ab79-44bb4a918993",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKf6zOYIk5dDwcl3Z1gSFSl5NPIqmoAPfZEIB9iaAOvT9MmnDnuXvtGCfHW6zqAZYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2accd58f-79cb-477b-a0fe-55ad18e5c513",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "70ec2fe3-a512-4a51-8d6f-b29ffbcdefa5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "53a72144-ef23-4670-b302-ac83d1e43861",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENJzCi6y+YHM28xc/iCAGXZdWKnPmF4Y1XV+oZs/Ah7ZdVAK0HukQsVB/u6+UVm0jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ced37b8e-5b6f-435f-9baf-4e9e76c4da8c",
                            TwoFactorEnabled = false,
                            UserName = "Staff",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Staff"
                        },
                        new
                        {
                            Id = "dfb98151-47c6-43e2-8341-434a3d241312",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e7337004-4da0-496b-8f3e-58f076cad199",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECVTIF5ZkxuzSvmMmDehJvnAfA3GpKHuXp9kYjpLdHaqQAzsWfmnStjasTQLYhKhZQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "587a0b00-e378-47a5-ab4e-27f9a0b58554",
                            TwoFactorEnabled = false,
                            UserName = "Staff2",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Staff2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.HasOne("News.Entities.AcademicYear", "AcademicYearFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_AcademicYearId");

                    b.HasOne("News.Entities.Categories", "categoriesFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_CategoryId");

                    b.HasOne("News.Entities.AppUser", "appUserFK")
                        .WithMany("ideasList")
                        .HasForeignKey("idea_UserId");

                    b.Navigation("AcademicYearFK");

                    b.Navigation("appUserFK");

                    b.Navigation("categoriesFK");
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.HasOne("News.Entities.Department", "DepartmentFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entities.AppUser", "AppUserFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserFK");

                    b.Navigation("DepartmentFK");
                });

            modelBuilder.Entity("News.Entities.AcademicYear", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Navigation("userInDepartmentsList");
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.Navigation("ideasList");

                    b.Navigation("userInDepartmentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
