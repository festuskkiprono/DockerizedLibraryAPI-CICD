# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY LibraryManagement.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime with EF Tools
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS runtime
WORKDIR /app

# Copy published app
COPY --from=build /app/publish .

# Copy source files for migrations (in a separate directory)
WORKDIR /src
COPY --from=build /src .
RUN dotnet restore

# Install EF Core tools
RUN dotnet tool install --global dotnet-ef --version 10.0.2
ENV PATH="${PATH}:/root/.dotnet/tools"

# Set working directory back to app
WORKDIR /app

ENTRYPOINT ["dotnet", "LibraryManagement.dll"]