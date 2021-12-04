#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["mmpos/mmpos.csproj", "mmpos/"]
RUN dotnet restore "mmpos/mmpos.csproj"
COPY . .
WORKDIR "/src/mmpos"
RUN dotnet build "mmpos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "mmpos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mmpos.dll"]