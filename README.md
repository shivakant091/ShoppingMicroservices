# ShoppingMicroservices
Develope Shopping  Microservices on .Net Core which used Asp.Net Web API, Docker, RabbitMQ, Ocelot API Gateway, MongoDB,Redis,SqlServer.

## <b>Whats Including In This Repository</b>
We have implemented below **features over the run-aspnetcore-microservices repository**.

#### Catalog microservice which includes; 
* ASP.NET Core Web API application 
* REST API principles, CRUD operations
* **MongoDB database** connection and containerization
* Repository Pattern Implementation
* Swagger Open API implementation
## Run The Project
You will need the following tools:

* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
* [.Net8 or later](https://dotnet.microsoft.com/download/dotnet-core/5)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)
1. Clone the repository
2. Once Docker for Windows is installed, go to the **Settings > Advanced option**, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:
* **Memory: 4 GB**
* CPU: 2
3. At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```
3. Wait for docker compose all microservices. That’s it! (some microservices need extra time to work so please wait if not worked in first shut)

4. You can **launch microservices** as below urls:

* **Catalog API -> http://host.docker.internal:9001/swagger/index.html**
