# 🎓 SmartSchoolMz - Sistema de Gestão Escolar

O **SmartSchoolMz** é um sistema de gestão escolar desenvolvido com .NET 9, seguindo os princípios da **Clean Architecture**. O sistema permite a gestão de alunos, turmas, matrículas, notas, frequência e pagamentos.

---

## 🛠️ Tecnologias Utilizadas

- **Backend:** ASP.NET Core Web API
- **Frontend:** ASP.NET Core Razor Pages
- **ORM:** Entity Framework Core
- **Base de Dados:** SQL Server
- **Autenticação:** ASP.NET Identity (JWT para API e Cookies para Web)

---

## 🏗️ Estrutura do Projecto

A solução está dividida em 4 camadas principais:

1.  **Domain:** Entidades, Enums e interfaces base.
2.  **Application:** Lógica de negócio, DTOs e interfaces de serviço.
3.  **Infrastructure:** Implementação de repositórios, contexto da base de dados (EF Core) e serviços de infraestrutura (Tokens JWT).
4.  **WebAPI / Web:** Camadas de apresentação (API e Frontend).

---

## 🚀 Como Configurar e Executar

### 1. Pré-requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express ou Developer)
- [Entity Framework Core Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) (`dotnet tool install --global dotnet-ef`)

### 2. Configurar a Base de Dados

A string de conexão deve ser configurada nos ficheiros `appsettings.json` dos projectos **WebAPI** e **Web**.

Exemplo de string de conexão:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQL2019;Database=SmartSchoolMzDb;User Id=sa;Password=SUA_SENHA;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

### 3. Executar Migrations

Abra o terminal na raiz do projecto e execute:

```bash
# Criar a base de dados e aplicar as tabelas
dotnet ef database update --project src/SmartSchoolMz.Infrastructure --startup-project src/SmartSchoolMz.Web
```

*Nota: O sistema possui um Seed automático que cria as Roles e um utilizador Admin no primeiro arranque.*

### 4. Executar o Projecto

Você pode executar o Frontend (Web) ou a API de forma independente:

**Para o Frontend (Razor Pages):**
```bash
dotnet run --project src/SmartSchoolMz.Web
```
Aceda a: `https://localhost:7001` (ou a porta indicada no terminal).

**Para a WebAPI (Swagger):**
```bash
dotnet run --project src/SmartSchoolMz.WebAPI
```
Aceda a: `https://localhost:5001/swagger` para documentação dos endpoints.

---

## 🔐 Credenciais de Acesso (Padrão)

Ao iniciar o projecto pela primeira vez, utilize estas credenciais:

- **Utilizador:** `admin@smartschool.mz`
- **Palavra-passe:** `Admin123!`

---

## 📂 Documentação Adicional

Detalhes sobre os requisitos e casos de uso podem ser encontrados na pasta:
- `docs/requirements.md`
- `docs/usecases.md`
- `docs/mvpspecs.md`

---

**Desenvolvido por:** Túlio Benedito Nhantumbo
