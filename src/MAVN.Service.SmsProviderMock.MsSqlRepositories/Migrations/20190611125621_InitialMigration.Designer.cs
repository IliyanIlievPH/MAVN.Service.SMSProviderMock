// <auto-generated />
using System;
using Lykke.Service.SmsProviderMock.MsSqlRepositories;
using MAVN.Service.SmsProviderMock.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.SmsProviderMock.MsSqlRepositories.Migrations
{
    [DbContext(typeof(SmsContext))]
    [Migration("20190611125621_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sms")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.SmsProviderMock.MsSqlRepositories.Entities.SmsEntity", b =>
                {
                    b.Property<Guid>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("message_id");

                    b.Property<string>("Message")
                        .HasColumnName("message")
                        .HasMaxLength(10000);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("MessageId");

                    b.HasIndex("MessageId")
                        .IsUnique();

                    b.HasIndex("PhoneNumber");

                    b.ToTable("sms");
                });
#pragma warning restore 612, 618
        }
    }
}
