## Technical Questions and My Answer

1. Azure Integration:
Q: What Azure services would you recommend for a secure API gateway that connects multiple identity data sources to a centralized API? How would you handle authentication?

A: I recommend using Azure API Management (APIM) as a secure gateway for all API traffic. It allows central control of routing, rate limiting, and security. For authentication, I would use Azure Active Directory (AAD) with OAuth 2.0 and JWT tokens. The Angular frontend can use MSAL to get a token and send it with each request. The .NET API validates the token using JWT middleware.

2. Data Access:
Q: How would you optimize SQL queries when dealing with large volumes of identity data in SQL Server? Provide a specific example of a technique you've used.
A: To optimize performance, I use indexes on frequently queried fields like Email, UserId, or LastUpdated. I also apply pagination in queries and APIs.


3. Security:
Q: How would you implement secure handling of personally identifiable information (PII) in an Angular and .NET Core application, both for data in transit and at rest?
A: 
-In transit: Use HTTPS and JWT-based authentication. Angular sends the token in requests; the API validates it.
-At rest: Encrypt sensitive fields in the database (e.g., using .NET Data Protection or SQL field-level encryption).
-In Angular, avoid storing PII or tokens in localStorage. Use route guards and only display necessary PII.
-In .NET, restrict access using role-based authorization and log access to PII for audit purposes.

4. DevOps:
Q: Briefly describe how you would set up CI/CD for this application stack (Angular, .NET Core) in an Azure environment.

A:
-I would use Azure DevOps Pipelines or GitHub Actions for CI/CD. The pipeline would:
-Build Angular and .NET Core apps
-Run tests (unit/integration)
-Publish artifacts (Angular to a storage account or Azure Static Web Apps, .NET API to Azure App Service)
-Deploy to Azure using ARM templates or Bicep for infrastructure-as-code
-Use staging slots for safe deployment and approval gates for production rollout

This ensures automated, repeatable, and secure delivery from code to cloud.

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
