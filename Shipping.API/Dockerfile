#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
ENV ShippingDb="Server=tcp:eshop-danna.database.windows.net,1433;Initial Catalog=shipping;Persist Security Info=False;User ID=danna;Password=Qazwsxedc@135;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Shipping.API/Shipping.API.csproj", "Shipping.API/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["ApplicationCore/ApplicationCore.csproj", "ApplicationCore/"]
RUN dotnet restore "./Shipping.API/Shipping.API.csproj"
COPY . .
WORKDIR "/src/Shipping.API"
RUN dotnet build "./Shipping.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Shipping.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shipping.API.dll"]