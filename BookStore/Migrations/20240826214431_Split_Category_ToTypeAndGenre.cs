using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Split_Category_ToTypeAndGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModelCategoryModel",
                schema: "production");

            migrationBuilder.DropTable(
                name: "tblCategories",
                schema: "production");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                schema: "production",
                table: "tblBooks");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                schema: "production",
                table: "tblBooks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                schema: "production",
                table: "tblBooks",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "tblGenres",
                schema: "production",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGenres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "BookModelGenreModel",
                schema: "production",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    GenresGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModelGenreModel", x => new { x.BooksBookId, x.GenresGenreId });
                    table.ForeignKey(
                        name: "FK_BookModelGenreModel_tblBooks_BooksBookId",
                        column: x => x.BooksBookId,
                        principalSchema: "production",
                        principalTable: "tblBooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookModelGenreModel_tblGenres_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalSchema: "production",
                        principalTable: "tblGenres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModelGenreModel_GenresGenreId",
                schema: "production",
                table: "BookModelGenreModel",
                column: "GenresGenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModelGenreModel",
                schema: "production");

            migrationBuilder.DropTable(
                name: "tblGenres",
                schema: "production");

            migrationBuilder.DropColumn(
                name: "PhotoName",
                schema: "production",
                table: "tblBooks");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "production",
                table: "tblBooks");

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                schema: "production",
                table: "tblBooks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "tblCategories",
                schema: "production",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BookModelCategoryModel",
                schema: "production",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModelCategoryModel", x => new { x.BooksBookId, x.CategoriesCategoryId });
                    table.ForeignKey(
                        name: "FK_BookModelCategoryModel_tblBooks_BooksBookId",
                        column: x => x.BooksBookId,
                        principalSchema: "production",
                        principalTable: "tblBooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookModelCategoryModel_tblCategories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalSchema: "production",
                        principalTable: "tblCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModelCategoryModel_CategoriesCategoryId",
                schema: "production",
                table: "BookModelCategoryModel",
                column: "CategoriesCategoryId");
        }
    }
}
