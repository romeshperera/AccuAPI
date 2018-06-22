FROM microsoft/aspnetcore AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build AS build
WORKDIR /Core
COPY Core .
WORKDIR /src
COPY Services/AccuCoreAPI/AccuCoreAPI.csproj .
#RUN ls
RUN dotnet restore AccuCoreAPI.csproj
COPY Services/AccuCoreAPI .
WORKDIR /src
RUN dotnet build AccuCoreAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AccuCoreAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AccuCoreAPI.dll"]

