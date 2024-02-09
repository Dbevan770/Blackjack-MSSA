FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set the working directory
WORKDIR /app

COPY ./* /app/

CMD ["dotnet", "run"]