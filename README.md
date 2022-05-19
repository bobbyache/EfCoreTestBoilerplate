# Topic

Note that a lot of the material you need to get this going can be found [here](https://github.com/rstropek/htl-leo-csharp-4) and here is the Entity Framework Cheat Sheet.
However, the cheatsheet has been provided here in the documentation folder. Go to the other one if you think you need updates.

### Prerequisites

To see if `sqllocaldb` is installed on your machine just type `sqllocaldb`.
`sqllocaldb i` or `sqllocaldb info` should tell you what instances you have on your machine. You'll see that you will have at least one instance listed, perhaps something like `MSSQLLocalDB`.

If you have linux or a mac, you can run via [Docker](https://youtu.be/7jcLliJvMcY?t=566).


### Create the basic application boilerplate structure


```
dotnet new sln -n EfCoreTestSolution
dotnet new console -o TestConsole --dry-run
dotnet new console -o TestConsole

dotnet sln add TestConsole/TestConsole.csproj

cd TestConsole/

dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Logging.Console

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

```

### Database Migrations

This will create a new migrations folder with your initial database stuff.
```
dotnet ef migrations add Initial
```

This will create and update the database.
```
dotnet ef database update
```

* Add Migration: `dotnet ef migrations add <MigrationName>`
* Update target database: `dotnet ef database update`
* Remove last Migration: `dotnet ef migrations remove`
* Generate SQL script from Migrations: `dotnet ef migrations 
