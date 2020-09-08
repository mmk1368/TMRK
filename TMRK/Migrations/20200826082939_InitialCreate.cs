using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMRK.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceID = table.Column<int>(nullable: false),
                    ServiceMethodID = table.Column<int>(nullable: false),
                    MethodInput = table.Column<string>(unicode: false, nullable: true),
                    CallTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    SummeryData = table.Column<string>(unicode: false, nullable: true),
                    MethodOrginalName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PointerID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceID = table.Column<int>(nullable: false),
                    ServiceMethodID = table.Column<int>(nullable: false),
                    MethodOutput = table.Column<string>(unicode: false, nullable: true),
                    Exception = table.Column<string>(unicode: false, nullable: true),
                    ErrorCode = table.Column<int>(nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PointerID = table.Column<long>(nullable: true),
                    SummeryData = table.Column<string>(unicode: false, nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    RequestID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseID);
                    table.ForeignKey(
                        name: "FK_Response_Request",
                        column: x => x.RequestID,
                        principalTable: "Request",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_RequestID",
                table: "Response",
                column: "RequestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Request");
        }
    }
}
