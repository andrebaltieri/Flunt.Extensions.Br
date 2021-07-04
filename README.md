# Flunt.Extensions.Br
Extensões do Flunt para validações BR

| Package |  Version | Downloads |
| ------- | ----- | ----- |
| `Flunt.Extensions.Br` | [![NuGet](https://img.shields.io/nuget/v/Flunt.Extensions.Br.svg)](https://nuget.org/packages/Flunt.Extensions.Br) | [![Nuget](https://img.shields.io/nuget/dt/Flunt.Extensions.Br.svg)](https://nuget.org/packages/Flunt.Extensions.Br) |


### Dependencies
.NET Standard 2.0

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

### Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/Flunt.Extensions.Br


**Nuget**
```
Install-Package Flunt.Extensions.Br
```

**.NET CLI**
```
dotnet add package Flunt.Extensions.Br
```

## How to use
```csharp
public class Customer : Notifiable<Notification>
{
  public string Document { get; set; }
  
  public void Validate() 
  {
     AddNotifications(new Contract<Notification>()
      .IsCpf(Document, "CPF", "CPF inválido"));
  }
}
```
