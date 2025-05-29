# **Data Transfer Objects**

>[1. Data Transfer Objects](#data-transfer-objects)
>
>[2. Object Mapping](#object-mapping)
>
>[3. AutoMapper](#automapper)
>
>[4. Ingredients](#ingredients)
>
>[5. Create PersonApi](#create-personapi)
>
>[6. Packages, Folders & Files](#packages-and-files)
>
>[7. Docker](#docker)
>
>[8. Create Migrations](#create-migrations)

---

### **Data Transfer Objects**

- DTOs allow you to decouple internal models from external facing consumers
- DTOs are external facing, used in the "transport of data", both:
    - Outbound (e.g. Read operations);
    - Inbound (Create and Update operations).
- DTOs makes code more maintainable:
    - Your internal data representations are not bound to (external) consumer contracts.
- You have more control over what external clients see, e.g.:
    - Security sensitive properties in your internal models don`t need to be exposed via DTOs.

#### [🔼 Back to top](#data-transfer-objects)

---

### **Object Mapping**

- The ability to trace or "map" properties between objects
    - Map from a Source object properties to a Destination object properties
- Can be done manually
    - Laborious and prone to error
- Alternatively use of a mapping framework
    - E.g. AutoMapper

#### [🔼 Back to top](#data-transfer-objects)

---

### **AutoMapper**

- Popular mapping framework in .NET
- Mapping are set up using Profiles (automatic mappings established)
- Mapping can have rules and vary depending on the direction of data
    - Mapping Read vs Create and Update operations;
    - Mapping using profiles (property names are different)
    - Changing the type of data
    - Null substitution
    - Custom Resolvers (calculate stuff when mapping)
- Used anywhere that you need to map objects (not just DTO / API use-case)

#### [🔼 Back to top](#data-transfer-objects)

---

### **Ingredients**

1. .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. VS Code (free): https://code.visualstudio.com/download
3. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/
4. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download

#### [🔼 Back to top](#data-transfer-objects)

---

### **Create PersonApi**

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new minimal API project with name PersonalAPI:**
```
dotnet new webapi -minimal -n PersonalAPI --framework net6.0
```

> **Open in VS Code:**
```
code -r PersonalAPI
```

> **Create gitignore file:**
```
dotnet new gitignore
```

> **Restore project:**
```
dotnet restore
```

> **Build project:**
```
dotnet build
```

> **Run project:**
```
dotnet run
```

#### [🔼 Back to top](#data-transfer-objects)

---

### **Packages and files**

> **Microsoft.EntityFrameworkCore:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/
```
dotnet add package Microsoft.EntityFrameworkCore
```

> **Microsoft.EntityFrameworkCore.SqlServer:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

> **Microsoft.EntityFrameworkCore.Design:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

> **AutoMapper.Extensions.Microsoft.DependencyInjection:** https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/
```
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

> **Create folders and files:**

> > docker-compose.yaml:
    ```New-Item docker-compose.yaml```

> > Create folder "Data":
    ```mkdir Data```

> > > AppDbContext.cs:
    ```New-Item AppDbContext.cs```

> > Create folder "Dtos":
    ```mkdir Dtos```

> > > PersonBaseDto.cs:
    ```New-Item PersonBaseDto.cs```

> > > PersonCreateDto.cs:
    ```New-Item PersonCreateDto.cs```

> > > PersonReadDto.cs:
    ```New-Item PersonReadDto.cs```

> > > PersonUpdateDto.cs:
    ```New-Item PersonUpdateDto.cs```

> > Create folder "Models":
    ```mkdir Models```

> > > Person.cs:
    ```New-Item Person.cs```

> > Create folder "Profiles":
    ```mkdir Profiles```

> > > AgeResolver.cs:
    ```New-Item AgeResolver.cs```

> > > FullNameResolver.cs:
    ```New-Item FullNameResolver.cs```

> > > IntTypeConverter.cs:
    ```New-Item IntTypeConverter.cs```

> > > PeopleProfile.cs:
    ```New-Item PeopleProfile.cs```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```

#### [🔼 Back to top](#data-transfer-objects)

---

### **Docker**

> **Check Docker installation:**
```
docker
```

> **Check Docker version:**
```
docker --version
```

> **Docker up:**
```
docker compose up -d
```

> **Docker check containers:**
```
docker ps
```

> **Docker stop:**
```
docker compose stop
```

#### [🔼 Back to top](#data-transfer-objects)

---

### **Create Migrations**

> **Check .NET Entity Framework:**
```
dotnet-ef
```

> **Update dotnet-ef tool to last version:**
```
dotnet tool update --global dotnet-ef
```

> **Create first migration:**
```
dotnet-ef migrations add 'InitialCreate'
```

> **Update database:**
```
dotnet-ef database update
```

#### [🔼 Back to top](#data-transfer-objects)