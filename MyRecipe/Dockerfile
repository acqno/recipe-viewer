FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["MyRecipe/MyRecipe.csproj", "MyRecipe/"]
RUN dotnet restore "MyRecipe/MyRecipe.csproj"
COPY . .
WORKDIR "/src/MyRecipe"
RUN dotnet build "MyRecipe.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyRecipe.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyRecipe.dll"]