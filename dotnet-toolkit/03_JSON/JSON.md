# **JSON**

>[1. Ingredients](#ingredients)
>
>[2. Create Serialization App](#create-serialization-app)
>
>[3. Create Deserialization App](#create-deserialization-app)
>
>[4. Create API](#create-api)

---

### **Ingredients**

1. .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. VS Code (free): https://code.visualstudio.com/download

#### [🔼 Back to top](#json)

---

### **Create Serialization App**

> **Create folder SerializationApp:**
```
mkdir SerializationApp
```

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new console project with name Serializer:**
```
dotnet new console -n Serializer --framework net6.0
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

> **Create folders and files:**
```
New-Item person.json
```

> > Create folder "Models":
    ```mkdir Models```

> > > Address.cs:
    ```New-Item Address.cs```

> > > Person.cs:
    ```New-Item Person.cs```

> > > Phone.cs:
    ```New-Item Phone.cs```

> > Create folder "Helpers":
    ```mkdir Helpers```

> > > LowerCaseNamingPolicy.cs:
    ```New-Item LowerCaseNamingPolicy.cs```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```

#### [🔼 Back to top](#json)

---

### **Create Deserialization App**

> **Create folder DeserializationApp:**
```
mkdir DeserializationApp
```

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new console project with name Deserializer:**
```
dotnet new console -n Deserializer --framework net6.0
```

> **Open in VS Code:**
```
code -r Deserializer
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

> **Create folders and files:**
```
New-Item person.json
```

> > Create folder "Models":
    ```mkdir Models```

> > > Address.cs:
    ```New-Item Address.cs```

> > > Person.cs:
    ```New-Item Person.cs```

> > > Phone.cs:
    ```New-Item Phone.cs```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```

#### [🔼 Back to top](#json)

---

### **Create API**

> **Create folder DeserializationApp:**
```
mkdir API
```

> **Check the version of .NET:**
```
dotnet --version
```

> **Check of .NET info:**
```
dotnet --info
```

> **Create new console project with name WeatherAPI:**
```
dotnet new console -n WeatherAPI --framework net6.0
```

> **Open in VS Code:**
```
code -r WeatherAPI
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

> **Create folders and files:**
```
New-Item person.json
```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```

#### [🔼 Back to top](#json)