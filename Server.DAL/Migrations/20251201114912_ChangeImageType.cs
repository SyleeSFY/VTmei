using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.DLL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImageType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                -- Временно снимаем NOT NULL
                ALTER TABLE ""EducatorAdditionalInfos"" 
                ALTER COLUMN ""Image"" DROP NOT NULL;
                
                UPDATE ""EducatorAdditionalInfos"" 
                SET ""Image"" = NULL;
                
                ALTER TABLE ""EducatorAdditionalInfos"" 
                ALTER COLUMN ""Image"" TYPE bytea 
                USING NULL;
                
                -- ALTER TABLE ""EducatorAdditionalInfos"" 
                -- ALTER COLUMN ""Image"" SET NOT NULL;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                -- Для отката
                ALTER TABLE ""EducatorAdditionalInfos"" 
                ALTER COLUMN ""Image"" DROP NOT NULL;
                
                UPDATE ""EducatorAdditionalInfos"" 
                SET ""Image"" = NULL;
                
                ALTER TABLE ""EducatorAdditionalInfos"" 
                ALTER COLUMN ""Image"" TYPE text 
                USING NULL;
                
                -- ALTER TABLE ""EducatorAdditionalInfos"" 
                -- ALTER COLUMN ""Image"" SET NOT NULL;
            ");
        }
    }
}