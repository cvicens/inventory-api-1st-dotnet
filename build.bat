:: Generated by: https://openapi-generator.tech
::

@echo off

dotnet restore src\Coolstore.Inventory
dotnet build src\Coolstore.Inventory
echo Now, run the following to start the project: dotnet run -p src\Coolstore.Inventory\Coolstore.Inventory.csproj --launch-profile web.
echo.
