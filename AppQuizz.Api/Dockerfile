#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AppQuizz.Api/AppQuizz.Api.csproj", "AppQuizz.Api/"]
RUN dotnet restore "AppQuizz.Api/AppQuizz.Api.csproj"
COPY . .
WORKDIR "/src/AppQuizz.Api"
RUN dotnet build "AppQuizz.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppQuizz.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppQuizz.Api.dll"]