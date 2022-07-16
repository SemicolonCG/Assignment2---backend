using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Notes_NoteId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Replies_ReplyId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Replies_ReplyId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_ReplyId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Notes_NoteId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ReplyId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "Notes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "Replies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_ReplyId",
                table: "Replies",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_NoteId",
                table: "Notes",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ReplyId",
                table: "Notes",
                column: "ReplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Notes_NoteId",
                table: "Notes",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Replies_ReplyId",
                table: "Notes",
                column: "ReplyId",
                principalTable: "Replies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Replies_ReplyId",
                table: "Replies",
                column: "ReplyId",
                principalTable: "Replies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
