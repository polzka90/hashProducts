FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app
# Build da aplicacao
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build da imagem
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS="http://*:80"
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "HashProducts.Api.dll"]