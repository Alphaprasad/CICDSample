# Use the Windows Server Core-based image for .NET 5.0
FROM mcr.microsoft.com/dotnet/aspnet:5.0-nanoserver-19045 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-nanoserver-19045 AS build
WORKDIR /src
COPY ["CICDDemo/CICDDemo.csproj", "CICDDemo/"]
RUN dotnet restore "CICDDemo/CICDDemo.csproj"
COPY . . 
WORKDIR "/src/CICDDemo"
RUN dotnet build "CICDDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CICDDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish . 
ENTRYPOINT ["dotnet", "CICDDemo.dll"]
