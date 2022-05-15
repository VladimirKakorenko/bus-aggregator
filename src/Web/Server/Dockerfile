FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS=http://*:5002
ENV ASPNETCORE_ENVIRONMENT=Production

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Web/Server/WebSPA.csproj ServerApp/
RUN dotnet restore ServerApp/WebSPA.csproj
COPY Web/Server .
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish WebSPA.csproj -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebSPA.dll"]

