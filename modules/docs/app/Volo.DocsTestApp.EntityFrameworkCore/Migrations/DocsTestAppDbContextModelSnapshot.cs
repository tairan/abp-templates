﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.DocsTestApp.EntityFrameworkCore;

namespace Volo.DocsTestApp.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(DocsTestAppDbContext))]
    partial class DocsTestAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Volo.Docs.Projects.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("DefaultDocumentName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("DocumentStoreType");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Format");

                    b.Property<string>("LatestVersionBranchName")
                        .HasMaxLength(128);

                    b.Property<string>("MainWebsiteUrl");

                    b.Property<string>("MinimumVersion");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("NavigationDocumentName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("DocsProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
