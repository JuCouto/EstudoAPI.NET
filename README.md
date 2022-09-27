# EstudoAPI.NET
Estudo APi com Entity Framework Core DIO

**instalar a ferramenta do Entity Framework na máquina
dotnet tool install --global dotnet-ef    

**instalar pacote sqlite:
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

**instalar pacote design
dotnet add package Microsoft.EntityFrameworkCore.Design

Nesse projeto a conexão com o Banco de Dados foi criada no json

E adicionei essa configuração no Program.cs
// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConexaoPadrao")));

**Criar Migrations (Mapea o entity para criar as tabelas no Banco de Dados)
dotnet-ef migrations add CriacaoTabelaContato      
//o nome deve ser sugestivo sobre qual tabela está sendo criada e tem q ser sem espaço

aplicar a migration:
dotnet-ef database update
//nesse ponto a tabela será criada no Banco de Dados


*******para acessar no dbeaver é necessário fazer nova conexão e procurar o banco de dados na pasta no projeto

# Links Importantes

//pacotes de banco de dados
https://docs.microsoft.com/pt-br/ef/core/providers/?tabs=dotnet-core-cli

//exemplo de conexão de bancos de dados
https://khalidabuhakmeh.com/entity-framework-core-connectionstrings-for-dotnet-apps
