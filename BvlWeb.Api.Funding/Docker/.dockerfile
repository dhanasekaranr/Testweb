# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BvlWeb.Api.Funding/BvlWeb.Api.Funding.csproj", "BvlWeb.Api.Funding/"]
RUN dotnet restore "BvlWeb.Api.Funding/BvlWeb.Api.Funding.csproj"
COPY . .
WORKDIR "/src/BvlWeb.Api.Funding"
RUN dotnet publish "BvlWeb.Api.Funding.csproj" -c Release -o /app/publish

# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BvlWeb.Api.Funding.dll"]
