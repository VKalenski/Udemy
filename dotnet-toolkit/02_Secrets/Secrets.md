# **Secrets**

>[1. Ingredients](#ingredients)
>
>[2. Terminal Commands](#terminal-commands)
>
>[3. Command Config](#command-config)

---

### **Ingredients**

1. .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. VS Code (free): https://code.visualstudio.com/download

#### [🔼 Back to top](#secrets)

---

### **Terminal Commands**

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new minimal API project with name UserAPI:**
```
dotnet new webapi -minimal -n UserAPI --framework net6.0
```

> **Open in VS Code:**
```
code -r UserAPI
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

> **Initial create secret:**
```
dotnet user-secrets init
```

> **Set secret password:**
```
dotnet user-secrets set "Password" "password"
```

#### [🔼 Back to top](#secrets)

---

### **Command Config**

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new console project with name CommandConfig:**
```
dotnet new console -n CommandConfig --framework net6.0
```

> **Open project in VS Code:**
```
code -r CommandConfig
```

```
dotnet add package Microsoft.Extensions.Hosting
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

> **Initial create secret:**
```
dotnet user-secrets init
```

> **Set secret password:**
```
dotnet user-secrets set "Password" "user secrets password"
```

> **Additional command:**
```
dotnet dev-certs https --trust
```

#### [🔼 Back to top](#secrets)