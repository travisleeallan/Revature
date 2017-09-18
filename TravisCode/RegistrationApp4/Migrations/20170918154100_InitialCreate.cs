using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RegistrationApp4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nchar(100)", nullable: true),
                    CreditHours = table.Column<int>(type: "int", nullable: true),
                    DWstring = table.Column<string>(type: "nchar(5)", nullable: true),
                    EndTime = table.Column<string>(type: "nchar(7)", nullable: true),
                    InstructorID = table.Column<int>(type: "int", nullable: true),
                    SpotsAvail = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<string>(type: "nchar(7)", nullable: true),
                    SubjectCode = table.Column<string>(type: "nchar(8)", nullable: true),
                    TotalSpots = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Fname = table.Column<string>(type: "nchar(30)", nullable: true),
                    Lname = table.Column<string>(type: "nchar(30)", nullable: true),
                    NumClasses = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Classification = table.Column<string>(type: "nchar(10)", nullable: true),
                    Fname = table.Column<string>(type: "nchar(30)", nullable: true),
                    Lname = table.Column<string>(type: "nchar(30)", nullable: true),
                    Major = table.Column<string>(type: "nchar(100)", nullable: true),
                    NumClasses = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
