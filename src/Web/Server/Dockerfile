# Build Web Client
FROM node:16-alpine as web-build
WORKDIR /webbuild/src

COPY Web/Server/Client/package.json .
COPY Web/Server/Client/yarn.lock .

# RUN npm install -g yarn@1.22
RUN yarn install

COPY Web/Server/Client .
RUN npm run build
# End

# Init Dotnet server
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS=http://*:5002
ENV ASPNETCORE_ENVIRONMENT=Production

# Publish project
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS publish
WORKDIR /src

COPY Web/Server/WebSPA.csproj .
COPY Web/Server/NuGet.config .
COPY Web/Server/global.json .

COPY Web/Server .
COPY --from=web-build /webbuild/wwwroot /src/wwwroot
RUN dotnet publish WebSPA.csproj -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebSPA.dll"]

# End publish project
