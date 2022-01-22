# Rest-Api

## Database

### How to start a database locally

```sh
docker compose up -d db
```

### How to setting allow connect in mysql

```mysql
CREATE USER 'User Account'@'Docker Database Ip' IDENTIFIED BY 'Password';
GRANT ALL PRIVILEGES ON *.* TO 'User Account'@'Docker Database Ip' WITH GRANT OPTION;
Flush Privileges;
```

### Database connection strings

Modify the `ConnectionStrings` in `DefaultConnection` at the following file

> src/RestApi/appsettings.json

### Add Migration

```sh
#switch to src/Repositories
dotnet ef migrations add InitialCreate --context DbContextEntity --startup-project ../RestApi
```

### Update Database

```sh
#switch to src/Repositories
dotnet ef database update --context DbContextEntity --startup-project ../RestApi
```

## Redis

```shell
#install redis image
docker build -f Dockerfile ..
```

```sh
#run redis
docker run -d --name redisDev -p 6379:6379 redis
```

### Use Package

```sh
dotnet add package ServiceStack.Redis
```

## Use Visual Studio

> Choice open `RestApi.sln` in root

## Project

### How run the project

```sh
#switch to src/RestApi
#use swagger api test
dotnet run
```

### Swagger api setting env

> launchSettings.json

### How build project

```sh
#switch to root
dotnet build
```

### How clean build outputs

```sh
#switch to root
dotnet clean
```

### How restore dependencies specified

```sh
#switch to root
dotnet restore
```

###

## Test

### How reload test

```sh
#switch to the tests project
dotnet watch test
```

### Run test

[Example Url](https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest)

```sh
#run all tests
dotnet test
```

### How to test project

```sh
#run project
dotnet test Directory/Test.csproj
```

```sh
#filter the test method name
dotnet test Directory/Test.csproj --filter MethodName
```

## Api example

### This is the route table for Api Example:

| VERB   | URL                                | DESCRIPTION                   |
| ------ | ---------------------------------- | ----------------------------- |
| GET    | api/ControllerRoute/MethodRoute    | Retrieves stock items         |
| GET    | api/ControllerRoute/MethodRoute/Id | Retrieves a stock item by id  |
| POST   | api/ControllerRoute/MethodRoute    | Create a new stock item       |
| PUT    | api/ControllerRoute/MethodRoute    | Update an existing stock item |
| DELETE | api/ControllerRoute/MethodRoute/Id | Delete an existing stock item |
