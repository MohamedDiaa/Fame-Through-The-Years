Running project
install dotnet 8.0 or later 

cd CelebrityAging

dotnet ef migrations add init --project ../Persistance            

dotnet ef database update --project ../Persistance

dotnet clean

dotnet build

dotnet run
