FROM mcr.microsoft.com/dotnet/sdk:7.0.305 AS build-env
WORKDIR /App

COPY . ./
WORKDIR /App/src/HelloService
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/src/HelloService/out .
ENTRYPOINT ["dotnet", "HelloService.dll"]
