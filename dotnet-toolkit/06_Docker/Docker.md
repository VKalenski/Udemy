# **Docker**

>[1. Ingredients](#ingredients)
>
>[2. Docker intro](#docker-intro)
>
>[3. Images vs Containers](#images-vs-containers)
>
>[4. Why use it](#why-use-it)
>
>[5. Benefits of Docker Compose](#benefits-of-docker-compose)
>
>[6. Create ToDoAPI](#create-todoapi)
>
>[7. Packages and files](#packages-and-files)
>
>[8. Docker create](#docker-create)
>
>[9. Docker Compose](#docker-compose)
>
>[10. Secrets](#secrets)
>
>[11. Certificates](#certificates)
>
>[12. Create Migrations](#create-migrations)

---

### **Ingredients**

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/
4. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
5. Azure DevOps account (free): https://azure.microsoft.com/en-us/products/devops
6. SQL Server Management Studio (free):
    - https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
    
    *(or DBeaver for Linux or Mac users)*

#### [🔼 Back to top](#docker)

---

### **Docker intro**

Docker is containerization platform, meaning that it enables you to package, (build), your applications into images and run them as "containers" on any platform that can run Docker.

#### [🔼 Back to top](#docker)

---

### **Images vs Containers**

1. Image: pre-build application, ready to run on Docker
    - You can get 1000's of pre-build images from Docker Hub
    - We will use a SQL Server Image
    - We will create an app and build our own Image
2. Container: a running image


#### [🔼 Back to top](#docker)

---

### **Why use it**

- Easy of Deployment (avoids "it works on my machine" argument)
- Assist Development: you can spin up containers without painful set up and config
- The can be "orchestrated"
    - They underpin most microservices architectures


#### [🔼 Back to top](#docker)

---

### **Benefits of Docker Compose**

- Reduces reliance on, and simplifies use of, Docker CLI
- Allows you to start multiple containers quickly
- Provides networking between containers

#### [🔼 Back to top](#docker)

---

### **Create ToDoAPI**

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new minimal webapi project with name ToDoAPI:**
```
dotnet new webapi -minimal -n ToDoAPI --framework net6.0
```

> **Open in VS Code:**
```
code -r Serializer
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

#### [🔼 Back to top](#docker)

---

### **Packages and files**

> **Microsoft.EntityFrameworkCore:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/
```
dotnet add package Microsoft.EntityFrameworkCore
```

> **Microsoft.EntityFrameworkCore.InMemory:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/
```
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

> **Microsoft.EntityFrameworkCore.SqlServer:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

> **Microsoft.EntityFrameworkCore.Design:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

> **Create folders and files:**

> > Create folder "Data":
    ```mkdir Data```

> > > AppDbContext.cs:
    ```New-Item AppDbContext.cs```

> > Create folder "Models":
    ```mkdir Models```

> > > ToDo.cs:
    ```New-Item ToDo.cs```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```

#### [🔼 Back to top](#docker)

---

### **Docker create**

> **Check all installed Linux distributions:**
```
wsl -l -v
```

> **Create Dockerfile:**
```
New-Item Dockerfile
```

> **Create .dockerignore file:**
```
New-Item .dockerignore
```

> **Check docker version**
```
docker --version
```

> **Docker login:**
```
docker login
```

> **List all containers:**
```
docker ps --all
```

> **Pull mysql:**
```
docker pull mysql
```

> **Pull mysql:latest:**
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
```

> **Pull rabbitmq:**
```
docker pull rabbitmq
```

> **Pull redis:**
```
docker pull redis
```

> **Run mssql with password, name and port:**
```
docker run -e 'ACCEPT=Y' -e 'SA_PASSWORD=Pa$$w0rd!' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

*Output on the console: *ba1d1db7ba0dcab11a9088e02bf2cc23e912e71904034b3e571a565140c20e27**

> **Stop the container:**
```
docker stop ba1d1db7ba0dcab11a9088e02bf2cc23e912e71904034b3e571a565140c20e27
```

> **Delete container:**
```
docker rm ba1d1db7ba0dcab11a9088e02bf2cc23e912e71904034b3e571a565140c20e27
```

> **Build docker image:**
```
docker build -t vilislavkalenski/todoapi .
```

> **Build docker image with latest version:**
```
docker build -t vilislavkalenski/todoapi:latest .
```

> **Scan docker image**
```
docker scout quickview
```

> **Cves about docker image:**
```
docker scout cves vilislavkalenski/todoapi
```

> **Recommendations about docker image:**
```
docker scout recommendations vilislavkalenski/todoapi
```

> **Run docker image:**
```
docker run vilislavkalenski/todoapi
```

> **Run docker image with current port:**
```
docker run -p 8080:80 vilislavkalenski/todoapi
```

> **Push docker image in personal DockerHub:**
```
docker push vilislavkalenski/todoapi
```

#### [🔼 Back to top](#docker)

---

### **Docker Compose**

> **Create docker-compose.yaml:**
```
New-Item docker-compose.yaml
```

> **Up docker image:**
```
docker compose up -d
```

> **Down docker image:**
```
docker compose down
```

#### [🔼 Back to top](#docker)

---

### **Secrets**

> **Initial user secret:**
```
dotnet user-secrets init
```

> **Set secret:**
```
dotnet user-secrets set "Kestrel:Certificates:Development:Password" "pa55w0rd!"
```

#### [🔼 Back to top](#docker)

---

### **Certificates:**

> **Trust certificate:**
```
dotnet dev-cert https --trust
```

#### [🔼 Back to top](#docker)

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

#### [🔼 Back to top](#docker)
