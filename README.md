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

## Technical Questions and My Answer
1. Azure Integration: API Gateway & Authentication
To securely connect multiple identity data sources to a central API:

Use Azure API Management (APIM)
Acts as a secure gateway that manages, secures, and monitors API traffic.

Authentication
Use Azure Active Directory (AAD) with OAuth2/JWT.
The Angular app can request tokens with MSAL, and send them in API calls.
The .NET API validates the token using JWT middleware.

2. SQL Optimization for Large Identity Data
When handling large identity data in SQL Server:

Add Indexes on fields like Email, UserId, or LastUpdated.

Use pagination in queries and APIs to limit data.


3. Secure Handling of PII (Angular & .NET)
Data in Transit:
Use HTTPS and JWT tokens for all API requests.

In Angular:
Don’t store tokens or sensitive data in localStorage.
Use route guards and only show necessary PII.

In .NET Core:
Encrypt sensitive fields using .NET Data Protection or SQL encryption.
Control access with role-based authorization.
Log who accesses PII using Application Insights or logging tools.

