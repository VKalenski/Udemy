# **How to use this Web Api**

Steps for execution:
Use project dotnet-rpg-7
Run ```dotnet build``` to test the api is working
Run dotnet run to start the application

---

### **Use Database:**

The folder "Migrations" by default is empty

- If you want to use MSSQL for database use the current rows in this files:

**In Program.cs:**
```builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));```

**In appsettings.json:**
```"ConnectionStrings": { "DefaultConnection": "Server=.\\SqlExpress; Database=dotnet-rpg-8; Trusted_Connection=true; TrustServerCertificate=true;" }```

**After change the rows run the below commands:**
```dotnet-ef migrations add 'Initial-create-mssql'```
```dotnet-ef database update```


- If you want to use PostgreSQL for database use the current rows in this files:
```builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));```

**In appsettings.json:**
**In Program.cs:**
```builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));```

**In appsettings.json:**
```"ConnectionStrings": { "DefaultConnection": "Server=.\\SqlExpress; Database=dotnet-rpg-8; Trusted_Connection=true; TrustServerCertificate=true;" }```

**After change the rows run the below commands:**
```dotnet-ef migrations add 'Initial-create-postgres'```
```dotnet-ef database update```

---

Use Postman to run the script ```DotNet-RPG.postman_collection.json```
Use the data in folder TestData