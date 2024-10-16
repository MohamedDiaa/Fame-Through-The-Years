Running project
install dotnet 8.0 or later 

cd CelebrityAging

dotnet ef migrations add init --project ../Persistance            

dotnet ef database update --project ../Persistance

dotnet clean

dotnet build

dotnet run

check the url on the browser
http://localhost:5298
or
https://localhost:7076

[![.NET](https://github.com/MohamedDiaa/Fame-Through-The-Years/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MohamedDiaa/Fame-Through-The-Years/actions/workflows/dotnet.yml)
