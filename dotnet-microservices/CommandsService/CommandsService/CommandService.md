### Command Service

>[1. Initial Commands](#initial-commands)
>
>[2. Packages, Build & Run](#packages-and-run)
>
>[3. Docker Commands](#docker-commands)
>
>[4. Kubernetes Commands](#kubernetes-commands)

---

### **Initial Commands**

> **Create new web api with name CommandsService:**
```
dotnet new webapi -n CommandsService --framework net6.0
```

> **Open in VS Code:**
```
code -r CommandsService
```

#### [🔼 Back to top](#command-service)

---

### Packages and Run

> **Microsoft.EntityFrameworkCore:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/
```
dotnet add package Microsoft.EntityFrameworkCore
```

> **Microsoft.EntityFrameworkCore.InMemory:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/
```
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

> **Microsoft.EntityFrameworkCore.Design:** https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

> **AutoMapper.Extensions.Microsoft.DependencyInjection:** https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/
```
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

> **RabbitMQ.Client:** https://www.nuget.org/packages/RabbitMQ.Client/
```
dotnet add package RabbitMQ.Client
```

> **Grpc.AspNetCore:** https://www.nuget.org/packages/Grpc.AspNetCore/
```
dotnet add package Grpc.AspNetCore
```

> **Google.Protobuf:** https://www.nuget.org/packages/Google.Protobuf/
```
dotnet add package Google.Protobuf
```

> **Grpc.Net.Client:** https://www.nuget.org/packages/Grpc.Net.Client/
```
dotnet add package Grpc.Net.Client
```

> **Grpc.Tools:** https://www.nuget.org/packages/Grpc.Tools/
```
dotnet add package Grpc.Tools
```

> **Check .NET version:**
```
dotnet --version
```

> **Build project:**
```
dotnet build
```

> **Run project:**
```
dotnet run
```

#### [🔼 Back to top](#command-service)

---

### **Docker Commands**

> **Check Docker version:**
```
docker --version
```

> **Build docker image:**
```
docker build -t vilislavkalenski/commandsservice .
```

> **Run docker image with current port (8081:80):**
```
docker run -p 8081:80 -d vilislavkalenski/commandsservice
```

> **Show docker containers:**
```
docker ps
```

> **Push docker image:**
```
docker push vilislavkalenski/commandsservice
```

> **Stop docker image:**
```
docker stop IdDocker
```

> **Start docker image:**
```
docker start IdDocker
```

#### [🔼 Back to top](#command-service)

---

### **Kubernetes Commands**

> *To deploy into DockerHub -> Kubernetes function is must be "**ON**" in Docker Desktop*

> **Check K8s version:**
```
kubectl version
```

> **Get all pods in current namespace (default):**
```
kubectl get pods
```

> **Apply current deployment file in K8s:**
```
kubectl apply -f commands-depl.yml
```

> **Get all deployments in current namespace (default):**
```
kubectl get deployments
```

> **Delete current deployment file in namespace (default):**
```
kubectl delete deployment commands-depl
```

> **Apply current service file in K8s:**
```
kubectl apply -f ingress-srv.yml
```

> **Get all services in current namespace (default):**
```
kubectl get services
```

#### [🔼 Back to top](#command-service)