# CI/CD

>[1. Ingredients](#ingredients)
>
>[2. CI/CD intro](#ci/cd-intro)
>
>[3. Azure DevOps](#azure-devops)
>
>[4. Unit Testing](#unit-testing)
>
>[5. Arrange Act Assert](#arrange-act-assert)
>
>[6. Extensions in VS Code](#extensions-in-vs-code)
>
>[7. Flow for connection between GitHub and Azure Pipelines](#Flow-for-connection-between-github-and-azure-pipelines)
>
>[8. Create ToDoAPI](#create-todoapi)
>
>[9. Endpoints Insomnia](#endpoints-insomnia)

---

### **Ingredients**

1. .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. VS Code (free): https://code.visualstudio.com/download
3. Git (free)
4. GitHub Account (free)
    - GitHub Desktop (free): https://desktop.github.com/
5. Azure DevOps account (free): https://azure.microsoft.com/en-us/products/devops
6. Azure account (free sign up / but potential on-going costs): https://azure.microsoft.com/en-us/get-started/azure-portal

#### [🔼 Back to top](#ci/cd)

---

### **CI/CD intro**

- Continuous Integration / Continuous Delivery
*or*
- Continuous Integration / Continuous Deployment
- Foundational concept in Agile Software Development (DevOps)

#### [🔼 Back to top](#ci/cd)

---

#### **Continuous Integration**

- Taking code from one or more developers and building and testing that code to ensure those changes do not break the build
- Usually triggered when developers "check-in" code changes to a code repository (e.g. GitHub)
- Allows multiple changes to be Continuous Integrated

#### [🔼 Back to top](#ci/cd)

---

#### **Continuous Delivery / Deployment**

1. Continuous Delivery
    - Extension of CI, concerned with automating the Release process
    - Ensures that you can deploy changes frequently at press of a button (manual)
    - Stops short of automating the changes in to Production

2. Continuous Deployment
    - Goes further than Continuous Delivery
    - Code changes will make their way into Production without manual intervention assuming there are not failures
    - Requires a high level or organizational maturity

#### [🔼 Back to top](#ci/cd)

---

### **Azure DevOps**

- Cloud-based collection of tools that allow development teams to build and release software, includes features like:
    - Planning Boards
    - Code Repository
    - CI/CD Pipelines
    - Test Plans

- Alternatives:
    - GitHub (also Microsoft)
    - Buildkite
    - Circle CI
    - Jenkins
    - Werker

#### [🔼 Back to top](#ci/cd)

---

### **Unit Testing**

- Abundant: there should be more of them than any other test type
- Small: They should test one thing (a unit)
- Cheap: They are written and executed first. The catch error early which are easier to fix
- Quick: Both to write and execute

#### [🔼 Back to top](#ci/cd)

---

### **Arrange Act Assert**

Irrespective of the unit testing framework (we are using xUnit), unit tests tend to follow the following pattern:
- Arrange: The set up of the test, e.g. configuring entry data
- Act: Where you execute the test to generate a result
- Assert: Check the actual result against the expected result

#### [🔼 Back to top](#ci/cd)

---

### **Extensions in VS Code**

Azure Pipelines

It is necessary to create one project in GitHub with current solution file and then do next steps!
Open: azpipelines-parallelism-request and send

#### [🔼 Back to top](#ci/cd)

---

### **Flow for connection between GitHub and Azure Pipelines**
1. Settings
2. Applications
    - Installed GitHub Apps: Azure Pipelines
        Go to Configure:
        - Repository Access: Only Selected repositories: nameRepo
        - Save
        - Login in Azure DevOps
3. Create Pipeline
    - Azure Pipeline
        - Azure Repos Git
        - nameRepo
        - ASP.NET

#### [🔼 Back to top](#ci/cd)

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

> **Create folder src:**
```
mkdir src
```

> **Create new minimal API project with name ToDoAPI in src folder:**
```
dotnet new webapi -minimal -n ToDoAPI --framework net6.0
```

> **Create gitignore file:**
```
dotnet new gitignore
```

> **Create folder test:**
```
mkdir test
```

> **Create new xunit project with name ToDoAPI.Tests in test folder:**
```
dotnet new xunit -n ToDoAPI.Tests --framework net6.0
```

> **Create gitignore file:**
```
dotnet new gitignore
```

> **Create solution with name ToDoAPISolution:**
```
dotnet new sln --name ToDoAPISolution
```

> **Add in solution ToDoAPISolution src/ToDoAPI/ToDoAPI.csproj and test/ToDoAPI.Tests/ToDoAPI.Tests.csproj:**
```
dotnet sln ToDoAPISolution.sln add src/ToDoAPI/ToDoAPI.csproj test/ToDoAPI.Tests/ToDoAPI.Tests.csproj
```

> **Add referneces:**
```
dotnet add test/ToDoAPI.Tests/ToDoAPI.Tests.csproj reference src/ToDoAPI/ToDoAPI.csproj
```

> **Check Git version:**
```
git --version
```

> **Check GitHub version:**
```
gh --version
```

> **Git config information:**
```
git config --list
```

> **Git status:**
```
git status
```

> **Git add all files:"**
```
git add .
```

> **Git commit:**
```
git commit -m "Initial Create"
```

> **Rename base branch:**
```
git branch -M main
```

> **Push into main branch:**
```
git push -u origin main
```

> **Git logs:**
```
git logs
```

#### [🔼 Back to top](#ci/cd)

---

### **Endpoints Insomnia**

Run src/ToDoAPI
```
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7047
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5280
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
```

---

POST

Name: POST ToDoAPI

https://localhost:7047/api/todo

Body:
{
	"name": "commit code to git"
}

---

GET

Name: GET ToDoAPI
https://localhost:7047/api/todo

Body:
-


---

#### [🔼 Back to top](#ci/cd)