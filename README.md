# automapper-example

Projeto para prática de uso do framework [AutoMapper](https://automapper.org/).

## Instalação do pacote AutoMapper

```bash
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
```

## Injeção de dependência

Na inicialização, faça a chamada a um *Extension Method* do AutoMapper para realizar o mapeamento de todos os Profiles (que herdam de AutoMapper.Profile) existentes em seu Projeto:

```dotnet
//services is type of Microsoft.Extensions.DependencyInjection.IServiceCollection 
services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
```

## Utilização em IQueryable

Existe um *Extension Method (ProjectTo<T>)* para utilização do AutoMapper em consultas com IQueryable:

```dotnet
//Adicione a dependência de um *AutoMapper.IConfigurationProvider* na classe
public NomeDaClasse(IConfigurationProvider configurationProvider) { ... }

//Na query, faça chamada ao Extension Method ProjectTo de AutoMapper.QueryableExtensions, passando o ConfigurationProvider com o parâmetro
query.ProjectTo<NomeDaClasseAlvo>(configurationProvider);
```