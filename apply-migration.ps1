$name= Read-Host -Prompt "Enter the name of the Migration in TitleCase"

dotnet ef migrations add $name --startup-project .\src\AnyTongue.Web\ --project .\src\AnyTongue.Persistence\ --context AppDbContext --output-dir Migrations