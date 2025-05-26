# User Identity API

A simple ASP.NET Core Web API to display and update digital user identity profiles using an in-memory database.

---

## Features

- Retrieve user identity by ID (`GET`)
- Update user identity fields (`PATCH`)
- In-memory database with Entity Framework Core
- Automatically updates `LastUpdated` timestamp
- CORS-enabled for frontend use (e.g., Angular)

---

## Quick Start

### 1. Clone or Download : https://github.com/JaysonCustodio/BE-UserIdentity.git
### 2. dotnet run (should have dotnet sdk installed)

```bash
git clone https://github.com/JaysonCustodio/BE-UserIdentity.git
cd BE-UserIdentity

Project Structure

BE=UserIdentity/
├── Controllers/
│   └── IdentitiesController.cs
├── Data/
│   ├── AppDbContext.cs
│   └── DbInitializer.cs (optional)
├── Models/
│   └── UserIdentity.cs
├── Program.cs
├── UserIdentityApi.csproj
└── README.md
