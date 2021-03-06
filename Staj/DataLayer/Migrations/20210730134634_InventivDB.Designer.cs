// <auto-generated />
using InventivCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventivCore.Migrations
{
    [DbContext(typeof(InventivContext))]
    [Migration("20210730134634_InventivDB")]
    partial class InventivDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventivCore.Models.DTOOdemePlani", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DTOOdemePlanis");
                });
#pragma warning restore 612, 618
        }
    }
}
