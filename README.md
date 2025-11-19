# aspnet-core
Building some Projects with ASP.NET Core

# Install SDK

Download from: https://dotnet.microsoft.com/download
dotnet --version
dotnet tool install --global dotnet-ef

# Create a project

dotnet new webapi -n ApiProject

dotnet new mvc -n MvcProject

dotnet new web -n MinimalApi

# Install EF Core SQLite Provider

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

# Create a Migration & Update Database

dotnet ef migrations add InitialCreate
dotnet ef database update

# Create fake dada

dotnet add package Bogus