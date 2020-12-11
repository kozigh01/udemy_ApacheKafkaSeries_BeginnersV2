FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /source

COPY *.csproj .
RUN dotnet restore

COPY . .

ENTRYPOINT ["tail", "-f", "/dev/null"]