﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Data.Migrations
{
    public partial class df : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    PostCategory = table.Column<string>(nullable: false),
                    PostTitle = table.Column<string>(nullable: false),
                    PostDescription = table.Column<string>(nullable: false),
                    PostImageUrl = table.Column<string>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorPosts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPosts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPosts_AuthorId",
                table: "AuthorPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPosts_CategoryId",
                table: "AuthorPosts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPosts");
        }
    }
}
