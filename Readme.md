## Docker file
<code>FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env  WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

ENV ASPNETCORE_URLS http://*:$PORT
ENTRYPOINT [ "dotnet", "NorthwindApi.dll" ]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet NorthwindApi.dll</code>


## Program.cs
<code>using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace NorthwindApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var port = Environment.GetEnvironmentVariable("PORT");

                    webBuilder.UseStartup<Startup>()
                    .UseUrls("http://*:" + port);
                });
    }
}</code>

## Build
<code>docker build -t northwindapi .</code>

## Heroku Login
<code>heroku login</code>
<code>heroku container:login</code>

## Publish
<code>heroku container:push -a northwindapi web</code>

## Release
<code>heroku container:release -a northwindapi web</code>
