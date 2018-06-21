FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY AccuCoreAPI.csproj .
RUN ls
RUN dotnet restore AccuCoreAPI.csproj
COPY . .
RUN ls
WORKDIR /src
RUN ls
RUN dotnet build AccuCoreAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AccuCoreAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AccuCoreAPI.dll"]

