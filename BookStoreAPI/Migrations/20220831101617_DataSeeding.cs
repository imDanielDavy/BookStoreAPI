using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreAPI.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Tolkien" },
                    { 2, "Marcus", "Aurelius" },
                    { 3, "Immanuel", "Kant" },
                    { 4, "Adam", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Paperback" },
                    { 2, "Audio" },
                    { 3, "Kindle" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adventure" },
                    { 2, "Philosophy" },
                    { 3, "Economics" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "GenreId", "ImgUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, "The Lord of the Rings is an epic high-fantasy novel by English author and scholar J. R. R. Tolkien.", 1, "https://s26162.pcdn.co/wp-content/uploads/2017/05/the-lord-of-the-rings-book-cover.jpg", "The Lord Of The Rings", 1949 },
                    { 2, 1, "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien.", 1, "https://images-na.ssl-images-amazon.com/images/I/71KqBbH93lL.jpg", "The Hobbit", 1937 },
                    { 3, 2, "Meditations is a series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.", 2, "https://images-na.ssl-images-amazon.com/images/I/7107Yk5DWtL.jpg", "Meditations", 180 },
                    { 4, 3, "The Critique of Pure Reason is a book by the German philosopher Immanuel Kant, in which the author seeks to determine the limits and scope of metaphysics.", 2, "https://www.gutenberg.org/files/4280/4280-h/images/cover.jpg", "Critique of Pure Reason", 1781 },
                    { 5, 4, "An Inquiry into the Nature and Causes of the Wealth of Nations is the magnum opus of the Scottish economist and moral philosopher Adam Smith.", 3, "https://images-na.ssl-images-amazon.com/images/I/71yqXZeTuxL.jpg", "The Wealth of Nations", 1781 }
                });

            migrationBuilder.InsertData(
                table: "BookVariants",
                columns: new[] { "BookId", "BookTypeId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 29.99m },
                    { 1, 3, 12.99m },
                    { 2, 1, 24.99m },
                    { 3, 1, 19.99m },
                    { 3, 2, 9.99m },
                    { 4, 1, 49.99m },
                    { 5, 1, 39.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookVariants",
                keyColumns: new[] { "BookId", "BookTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
