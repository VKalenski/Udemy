# **API Client**





---

Microservices
*Insomnia or Postman*
    PlatformService
        GET:    Get All Platforms
        GET:    Get a Individual Platform
        POST:   Create Platform
    CommandsService
        GET:    Get Command For Platform
        GET:    Get All Commands For Platform
        GET:    Get All Platforms
        POST:   Create Command For Platform
        POST:   Test Inbound Connection
    Docker Env
        GET:    Get All Platforms
    K8s
        Platform Service (Nginx)
            Get All Platforms
        Platform Service (NodePort)
            Get All Platforms
            Create Platform


>**Generates a temporary authentication token.*

### PlatformService

1. **Get All Platforms**

> **Endpoint:** http://localhost:5000/api/platforms
> **Method:** GET
> **Headers:** Content-Type: "application/json"
> **Body:** JSON
```
-
```

> **Response:**
```

```










- ##### METHOD:

    ```POST```

- ##### ENDPOINT:

    ```https://sandbox.euroins.bg/iam/login/device```

- ##### HEADERS:

    ```Content-Type: "application/json"```

- ##### BODY:

    ```
    {
        "TFAcode": null,
        "userName": "eLando",
        "password": "Elando!pass",
        "deviceId": null
    }
    ```

- ##### RESPONSE:

    ```
    {
        "result": {
            "token": "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2Njc1NTY4OTksImlzcyI6I",
            "email": null,
            "name": "elando",
            "phoneNumber": null,
            "isTFARequired": false,
            "isPasswordExpired": false,
            "tfaChannel": null
        },
        "error": null,
        "meta": {
            "requestId": "23ee70ea-2eb4-d550-0d56-67e9037808de",
            "executionTimeMs": 314,
            "executionFinishedUTC": "2022-11-04T09:44:59.7044198Z",
            "httpMethod": "POST",
            "path": "/login/device",
            "version": "1.0",A
            "instanceId": 1,
            "healthEndpoint": "/health"
        }
    }
    ```