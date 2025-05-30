# **.NET Microservices**

>[1. Microservices](#microservices)
>
>[2. Benefits of Microservices](#benefits-of-microservices)
>
>[3. Synchronous Messaging](#synchronous-messaging)
>
>[4. Asynchronous Messaging](#asynchronous-messaging)
>
>[5. RabbitMQ](#rabbitmq)
>
>[6. gRPC](#grpc)
>
>[7. Ingredients](#ingredients)
>
>[8. Some Commands](#some-commands)

---

### **Microservices**

- Small (2 pizza team, 2 weeks to build);
- Responsible for doing one thing well;
- Organisationally aligned;
- Form part of the (distributed) whole;
- Self-contained / Autonomous.

#### [🔼 Back to top](#.net-microservices)

---

### **Benefits of Microservices**

- Easier to change & deploy (small and decoupled);
- Can be build using different technologies;
- Increased organisational ownership & alignment;
- Resilient: 1 service can break the, others will continue to run;
- Scalable: ,you can scale out only the services you need to;
- Build to be highly replaceable / swappable.

#### [🔼 Back to top](#.net-microservices)

---

### **Synchronous Messaging**

- Request / Response Cycle;
- Requester will "wait" response;
- Eternally facing services usually synchronous (e.g. http requests);
- Services usually need to "know" about each other;
- We are using two forms:
    - Http;
    - gRPC.

#### [🔼 Back to top](#.net-microservices)

---

### **Asynchronous Messaging**

- No Request / Response Cycle;
- Requester does not wait;
- Event model, e.g. publish - subscribe;
- Typically used between services;
- Event bus is often used (we will be using RabbitMQ);
- Services don't need to know about each other, just the bus;
- Introduces ots own range of complexitites - not a magic bullet.

#### [🔼 Back to top](#.net-microservices)

---

### **RabbitMQ**

- A Message Broker - it accepts and forwards messages;
- Messages are sent by Producers (or Publishers);
- Messages are received by Consumers (or Subscribers);
- Messages are stored on Queues (essentially a message buffer);
- Exchanges can be used to add "routing" functionality;
- Uses Advanced Message Queuing Protocol (AMQP) & others.

#### [🔼 Back to top](#.net-microservices)

---

### **gRPC**

- "Google" Remote Procedure Call;
- Uses HTTP/2 protocol to transport binary messages (inc. TLS);
- Focused on high performance;
- Relies on "Protocol Buffers" (aka Protobuf) to defined the contract between end points;
- Multi-language support (C# client can call a Ruby service);
- Frequently used as a method of service to service communication.

#### [🔼 Back to top](#.net-microservices)

---

### **Ingredients**

1. .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. VS Code (free): https://code.visualstudio.com/download
3. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
4. GitHub Desktop (free): https://desktop.github.com/

#### [🔼 Back to top](#.net-microservices)

---

### **Some commands**

> **Create Command Service folder:**
```
mkdir CommandsService
```

> **Create Platform Service folder:**
```
mkdir PlatformService
```

#### [🔼 Back to top](#.net-microservices)