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
        mysql -u d03f0bf2 -pCHGXdHiYiofWFQZE4rqF d03f0bf2
        cd appportal.at
        mkdir -p ./lib/bootstrap/dist/css
        mkdir -p ./lib/bootstrap/dist/js
        mkdir -p ./lib/jquery/dist/
        mkdir -p ./css
        mkdir -p ./js
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/lib/bootstrap/dist/css/bootstrap.min.css
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/lib/jquery/dist/jquery.min.js ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/lib/jquery/dist/jquery.min.js
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/css/site.css ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/css/site.css
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/lib/bootstrap/dist/js/bootstrap.bundle.min.js
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/js/site.js ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/js/site.js
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/css/appportal.styles.css ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/css/appportal.styles.css
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/wwwroot/favicon.ico ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/favicon.ico
 
        scp /mnt/c/Users/hcwil/OneDrive/Dokumente/appportal/Views/Email/Details.cshtml ssh-w011d2f0@hcwilli.at:/www/htdocs/w011d2f0/appportal.at/index.php

  
 
 
 


         
        exit
        bash


 


 


 
 