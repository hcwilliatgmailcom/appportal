# Setup
        dotnet new mvc
        dotnet add package MySql.EntityFrameworkCore --version 6.3.6
        dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.14
        dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.11
        dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.14
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.14
        dotnet tool install -g dotnet-aspnet-codegenerator --version 7.0.11
        dotnet tool update -g dotnet-aspnet-codegenerator --version 7.0.11
        dotnet tool install -g dotnet-ef --version 7.0.14
        dotnet tool update -g dotnet-ef --version 7.0.14
        dotnet user-secrets init
        dotnet user-secrets set ConnectionStrings:MySql "Server=hcwilli.at;User ID=d03f0bf2;Password=*******************;Database=d03f0bf2"
        Program.cs: builder.Services.AddDbContext<D03f0bf2Context>();
        dotnet ef dbcontext scaffold "Name=MySql" MySql.EntityFrameworkCore -f
        dotnet-aspnet-codegenerator  controller  -m Email -dc D03f0bf2Context  --referenceScriptLibraries --useDefaultLayout --controllerName EmailController --relativeFolderPath Controllers -f
 


 
 