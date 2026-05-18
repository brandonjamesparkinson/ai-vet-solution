# VetClinicApp 🐾

A full-stack, CRUD-based Veterinary Management Application designed to mimic a dense, information-rich desktop experience directly in the browser. 

This project provides the foundation for managing veterinary clinic operations, including tracking clients, registering patients (pets), and recording medical history & invoicing.

## 🚀 Features

- **Interactive UI**: A cohesive 3-pane master-detail layout built natively with Blazor and Bootstrap.
  - **Top Section**: Manage Client Details and contact information.
  - **Middle Section**: Select and manage Patients linked to a specific client.
  - **Bottom Section**: Review a comprehensive chronological Medical History & Invoicing data grid.
- **AI Patient Summary**: Generates a quick AI-powered summary of the selected patient's status, highlighting chronic conditions, allergies, and overdue vaccinations.
- **Robust Backend**: ASP.NET Core Blazor App (Interactive Server mode) acting as both the frontend UI and the backend service layer.
- **Relational Data**: Fully configured Entity Framework Core implementation using a Code-First approach.

## 🛠️ Tech Stack

- **Framework:** .NET 9
- **Frontend:** Blazor Web App (Interactive Server Mode)
- **Styling:** Bootstrap 5 & Bootstrap Icons
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework Core (EF Core 9)
- **Architecture:** Monolithic, N-Tier (UI Components -> Services -> EF Context)

## 📋 Prerequisites

Before running this application, ensure you have the following installed:
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Developer/Express edition) or LocalDB.
- An IDE such as [Visual Studio 2022](https://visualstudio.microsoft.com/), [JetBrains Rider](https://www.jetbrains.com/rider/), or [VS Code](https://code.visualstudio.com/).
- EF Core CLI Tools (Install via: `dotnet tool install --global dotnet-ef`)

## 💻 Getting Started

### 1. Database Configuration
By default, the application is configured to connect to a local SQL Server instance (`BRANDON-LAPTOP`). If you are running this on a different machine, you will need to update the `DefaultConnection` string.

Open `src/VetClinicApp/appsettings.json` and adjust the connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=VetClinicDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True;"
}
```

### 2. Apply Migrations (Database Setup)
Navigate to the project directory and apply the Entity Framework Core migrations to construct your database schema.

```bash
cd src/VetClinicApp
dotnet ef database update
```

### 3. Run the Application
Start the Blazor web server:

```bash
dotnet run
```
Once the application starts, open your web browser and navigate to the localhost URL provided in the console output (typically `https://localhost:5001` or `http://localhost:5000`). Click on the **Dashboard** link in the sidebar to view the main application interface.

## 📁 Project Structure

```text
ai-vet-solution/
└── src/
    └── VetClinicApp/
        ├── Components/           # Blazor UI Components and Pages
        │   ├── Layout/           # MainLayout, NavMenu
        │   └── Pages/            # VetDashboard.razor (Main UI)
        ├── Data/                 # ApplicationDbContext (EF Core)
        ├── Models/               # C# Entity Models (Client, Patient, MedicalRecord)
        ├── Services/             # Business logic and database operations (IVetService, VetService, AssistantService)
        ├── wwwroot/              # Static assets (CSS, images)
        ├── appsettings.json      # Application configuration and Connection Strings
        └── Program.cs            # App entry point & Dependency Injection
```

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! 
If you want to add new features or improve the existing codebase:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/amazing-feature`).
3. Commit your changes (`git commit -m 'Add some amazing feature'`).
4. Push to the branch (`git push origin feature/amazing-feature`).
5. Open a Pull Request.

## 📝 License

This project is open-source and available under the [MIT License](LICENSE).
