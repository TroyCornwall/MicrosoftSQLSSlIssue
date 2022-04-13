FROM mcr.microsoft.com/dotnet/sdk:6.0-focal

WORKDIR /app
COPY . /app
RUN dotnet build

ENTRYPOINT [ "dotnet", "run" ]