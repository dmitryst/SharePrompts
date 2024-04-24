using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SharePrompts.Infrastructure.Cap.Migrations;

  /// <inheritdoc />
  public partial class InitialMigration : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "Contributors",
              columns: table => new
              {
                  Id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                  Status = table.Column<int>(type: "integer", nullable: false),
                  PhoneNumber_CountryCode = table.Column<string>(type: "text", nullable: true),
                  PhoneNumber_Number = table.Column<string>(type: "text", nullable: true),
                  PhoneNumber_Extension = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Contributors", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "Posts",
              columns: table => new
              {
                  Id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                  Text = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                  Tag = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                  UserId = table.Column<Guid>(type: "uuid", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Posts", x => x.Id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "Contributors");

          migrationBuilder.DropTable(
              name: "Posts");
      }
  }
