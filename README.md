# Setup
        vs code
        f5
        vstudio
        ubuntu
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
        dotnet user-secrets set ConnectionStrings:MySql "Server=hcwilli.at;User ID=d03f0bf2;Password=CHGXdHiYiofWFQZE4rqF;Database=d03f0bf2"
        Program.cs: builder.Services.AddDbContext<D03f0bf2Context>();
        dotnet ef dbcontext scaffold "Server=hcwilli.at;User ID=d03f0bf2;Password=CHGXdHiYiofWFQZE4rqF;Database=d03f0bf2" MySql.EntityFrameworkCore -f
        dotnet-aspnet-codegenerator  controller  -m Email -dc D03f0bf2Context  --referenceScriptLibraries --useDefaultLayout --controllerName EmailController --relativeFolderPath Controllers -f
        Templates\ViewGenerator\Create.cshtml: phpinfo
        bash
        ssh-keygen
        cd /home/hcwilli/.ssh/
        cat id_rsa.pub
        ssh ssh-w011d2f0@hcwilli.at
        exit
        bash
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/Views/Email/Create.cshtml ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/index.php




 


 
 