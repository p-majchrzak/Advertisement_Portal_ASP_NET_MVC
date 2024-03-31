using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Advertisement_Portal_ASP_NET_MVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLogginData_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLogginData_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Alert_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alert_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FirmLogginData_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmLogginData_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Message_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skills_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subcategory_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategory_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserLogginData_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogginData_Table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FirmData_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIP = table.Column<int>(type: "int", nullable: false),
                    REGON = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNubmer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmData_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FirmData_Table_FirmLogginData_Table_FirmID",
                        column: x => x.FirmID,
                        principalTable: "FirmLogginData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserData_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripotion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserData_Table_UserLogginData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserLogginData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Announcement_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position_Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Working_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operating_Mode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Work_Hours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remuneration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Announcement_Table_FirmData_Table_FirmID",
                        column: x => x.FirmID,
                        principalTable: "FirmData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Educations_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Educations_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Experience_Table_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Work_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience_Table_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Experience_Table_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Interests_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Interests_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Languages_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Languages_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReportedAccounts_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedAccounts_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReportedAccounts_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementSkills_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillID = table.Column<int>(type: "int", nullable: false),
                    AnnouncementID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementSkills_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnnouncementSkills_Table_Announcement_Table_AnnouncementID",
                        column: x => x.AnnouncementID,
                        principalTable: "Announcement_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AnnouncementSkills_Table_Skills_Table_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Applications_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AnnouncementID = table.Column<int>(type: "int", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Applications_Table_Announcement_Table_AnnouncementID",
                        column: x => x.AnnouncementID,
                        principalTable: "Announcement_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Applications_Table_FirmData_Table_FirmID",
                        column: x => x.FirmID,
                        principalTable: "FirmData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Applications_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationsHistory_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AnnouncementID = table.Column<int>(type: "int", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationsHistory_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ApplicationsHistory_Table_Announcement_Table_AnnouncementID",
                        column: x => x.AnnouncementID,
                        principalTable: "Announcement_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ApplicationsHistory_Table_FirmData_Table_FirmID",
                        column: x => x.FirmID,
                        principalTable: "FirmData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ApplicationsHistory_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReportedAd_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedAd_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReportedAd_Table_Announcement_Table_AdID",
                        column: x => x.AdID,
                        principalTable: "Announcement_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SavedAnnouncements_Table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AnnouncementID = table.Column<int>(type: "int", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedAnnouncements_Table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SavedAnnouncements_Table_Announcement_Table_AnnouncementID",
                        column: x => x.AnnouncementID,
                        principalTable: "Announcement_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SavedAnnouncements_Table_FirmData_Table_FirmID",
                        column: x => x.FirmID,
                        principalTable: "FirmData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SavedAnnouncements_Table_UserData_Table_UserID",
                        column: x => x.UserID,
                        principalTable: "UserData_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_Table_FirmID",
                table: "Announcement_Table",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementSkills_Table_AnnouncementID",
                table: "AnnouncementSkills_Table",
                column: "AnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementSkills_Table_SkillID",
                table: "AnnouncementSkills_Table",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Table_AnnouncementID",
                table: "Applications_Table",
                column: "AnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Table_FirmID",
                table: "Applications_Table",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Table_UserID",
                table: "Applications_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsHistory_Table_AnnouncementID",
                table: "ApplicationsHistory_Table",
                column: "AnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsHistory_Table_FirmID",
                table: "ApplicationsHistory_Table",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsHistory_Table_UserID",
                table: "ApplicationsHistory_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_Table_UserID",
                table: "Educations_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_Table_Table_UserID",
                table: "Experience_Table_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FirmData_Table_FirmID",
                table: "FirmData_Table",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_Table_UserID",
                table: "Interests_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Table_UserID",
                table: "Languages_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedAccounts_Table_UserID",
                table: "ReportedAccounts_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedAd_Table_AdID",
                table: "ReportedAd_Table",
                column: "AdID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAnnouncements_Table_AnnouncementID",
                table: "SavedAnnouncements_Table",
                column: "AnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAnnouncements_Table_FirmID",
                table: "SavedAnnouncements_Table",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAnnouncements_Table_UserID",
                table: "SavedAnnouncements_Table",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_Table_UserID",
                table: "UserData_Table",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLogginData_Table");

            migrationBuilder.DropTable(
                name: "Alert_Table");

            migrationBuilder.DropTable(
                name: "AnnouncementSkills_Table");

            migrationBuilder.DropTable(
                name: "Applications_Table");

            migrationBuilder.DropTable(
                name: "ApplicationsHistory_Table");

            migrationBuilder.DropTable(
                name: "Categories_Table");

            migrationBuilder.DropTable(
                name: "Educations_Table");

            migrationBuilder.DropTable(
                name: "Experience_Table_Table");

            migrationBuilder.DropTable(
                name: "Interests_Table");

            migrationBuilder.DropTable(
                name: "Languages_Table");

            migrationBuilder.DropTable(
                name: "Message_Table");

            migrationBuilder.DropTable(
                name: "ReportedAccounts_Table");

            migrationBuilder.DropTable(
                name: "ReportedAd_Table");

            migrationBuilder.DropTable(
                name: "SavedAnnouncements_Table");

            migrationBuilder.DropTable(
                name: "Subcategory_Table");

            migrationBuilder.DropTable(
                name: "Skills_Table");

            migrationBuilder.DropTable(
                name: "Announcement_Table");

            migrationBuilder.DropTable(
                name: "UserData_Table");

            migrationBuilder.DropTable(
                name: "FirmData_Table");

            migrationBuilder.DropTable(
                name: "UserLogginData_Table");

            migrationBuilder.DropTable(
                name: "FirmLogginData_Table");
        }
    }
}
