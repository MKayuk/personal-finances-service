using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalFinancesService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckingAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinancialInstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckingAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckingAccounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Investment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeInterestRate = table.Column<double>(type: "float", nullable: false),
                    CheckingAccountId = table.Column<int>(type: "int", nullable: true),
                    GoalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Investment_CheckingAccounts_CheckingAccountId",
                        column: x => x.CheckingAccountId,
                        principalTable: "CheckingAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Investment_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Establishment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckingAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFixed = table.Column<bool>(type: "bit", nullable: false),
                    FixedUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstallmentNumber = table.Column<int>(type: "int", nullable: false),
                    TotalInstallments = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    GoalId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckingAccountId = table.Column<int>(type: "int", nullable: true),
                    InvestmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entries_CheckingAccounts_CheckingAccountId",
                        column: x => x.CheckingAccountId,
                        principalTable: "CheckingAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entries_Investment_InvestmentId",
                        column: x => x.InvestmentId,
                        principalTable: "Investment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckingAccounts_UserId",
                table: "CheckingAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_CheckingAccountId",
                table: "Entries",
                column: "CheckingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_InvestmentId",
                table: "Entries",
                column: "InvestmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Investment_CheckingAccountId",
                table: "Investment",
                column: "CheckingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Investment_GoalId",
                table: "Investment",
                column: "GoalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Investment");

            migrationBuilder.DropTable(
                name: "CheckingAccounts");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
