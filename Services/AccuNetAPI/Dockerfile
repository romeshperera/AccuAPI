FROM microsoft/aspnet:4.7.1-windowsservercore-ltsc2016as AS build-env
ARG source
WORKDIR /inetpub/wwwroot
COPY --from=build-env obj/Docker/publish .
