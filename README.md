# IRMEPL - Clean Architecture .NET MVC Project

This project follows a clean architecture pattern with clear separation of concerns across multiple layers.

## Project Structure

```
IRMEPL.sln
│
├── Core
│   ├── Entities            # Pure POCOs (BaseEntity, User, Transaction, Menu)
│   └── Interfaces          # Core interfaces (ITransaction, IGeneralHelper)
│
├── Application
│   ├── Services            # Business logic services (MenuService, LockMasterService)
│   ├── DTOs                # Data Transfer Objects (UserDto, TransactionDto, MenuDto)
│   └── Interfaces          # Application interfaces (IMenuService, ILockMasterService, IUserService)
│
├── Infrastructure
│   ├── Data
│   │    ├── Repositories   # Data access layer (TransactionRepository)
│   │    └── DbManager.cs   # Database connection and transaction management
│   └── Helpers              # Utility classes (ClsGeneral, ClsTransaction, CollectionHelper)
│
├── WebApp (MVC)
│   ├── Controllers          # MVC Controllers (HomeController, UserController, TransactionController)
│   ├── Views
│   │    ├── Shared          # Layout.cshtml, _ViewImports.cshtml, _ViewStart.cshtml
│   │    └── Home            # Home views (Index, Privacy, Error)
│   ├── ViewModels           # ViewModels for MVC (UserViewModel, TransactionViewModel)
│   └── wwwroot              # Static files (CSS, JS, images)
│
├── appsettings.json         # Configuration settings
└── Program.cs               # Application startup and DI configuration
```

## Key Features

### Core Layer
- **Entities**: Pure POCOs with no dependencies
  - `BaseEntity`: Common properties for all entities
  - `User`: User management entity
  - `Transaction`: Financial transaction entity
  - `Menu`: Navigation menu entity

- **Interfaces**: Core business interfaces
  - `ITransaction`: Transaction operations
  - `IGeneralHelper`: Utility operations

### Application Layer
- **Services**: Business logic implementation
  - `MenuService`: Menu management with logging
  - `LockMasterService`: Resource locking mechanism
  - `UserService`: User management (interface defined)

- **DTOs**: Data transfer objects for API/View communication
- **Interfaces**: Application service contracts

### Infrastructure Layer
- **Data Access**:
  - `DbManager`: SQL Server connection and transaction management
  - `TransactionRepository`: Transaction data operations
  - `ClsGeneral`: Utility functions (hashing, validation, formatting)
  - `ClsTransaction`: Transaction management helper
  - `CollectionHelper`: Safe collection operations

### WebApp Layer
- **MVC Controllers**: Web interface controllers
- **Views**: Razor views with Bootstrap styling
- **ViewModels**: Strongly-typed view models with validation
- **Static Files**: CSS, JavaScript, and other assets

## Setup Instructions

### Prerequisites
- .NET 8.0 SDK
- SQL Server (LocalDB or full instance)
- Visual Studio 2022 or VS Code

### Installation Steps

1. **Clone/Download the project**
   ```bash
   # If using git
   git clone <repository-url>
   cd IRMEPL
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update connection string**
   - Edit `WebApp/appsettings.json`
   - Update the `DefaultConnection` string to point to your SQL Server instance

4. **Create database tables**
   ```sql
   -- Create Users table
   CREATE TABLE Users (
       Id int IDENTITY(1,1) PRIMARY KEY,
       Username nvarchar(50) NOT NULL UNIQUE,
       Email nvarchar(100) NOT NULL UNIQUE,
       FirstName nvarchar(50) NOT NULL,
       LastName nvarchar(50) NOT NULL,
       PasswordHash nvarchar(255) NOT NULL,
       PhoneNumber nvarchar(20),
       LastLoginDate datetime2,
       IsEmailVerified bit NOT NULL DEFAULT 0,
       CreatedDate datetime2 NOT NULL DEFAULT GETUTCDATE(),
       ModifiedDate datetime2,
       IsActive bit NOT NULL DEFAULT 1
   );

   -- Create Transactions table
   CREATE TABLE Transactions (
       Id int IDENTITY(1,1) PRIMARY KEY,
       TransactionNumber nvarchar(50) NOT NULL UNIQUE,
       Amount decimal(18,2) NOT NULL,
       Description nvarchar(500) NOT NULL,
       TransactionType nvarchar(20) NOT NULL,
       Status nvarchar(20) NOT NULL,
       UserId int NOT NULL,
       TransactionDate datetime2 NOT NULL DEFAULT GETUTCDATE(),
       ReferenceNumber nvarchar(100),
       CreatedDate datetime2 NOT NULL DEFAULT GETUTCDATE(),
       ModifiedDate datetime2,
       IsActive bit NOT NULL DEFAULT 1,
       FOREIGN KEY (UserId) REFERENCES Users(Id)
   );

   -- Create Menus table
   CREATE TABLE Menus (
       Id int IDENTITY(1,1) PRIMARY KEY,
       Name nvarchar(100) NOT NULL,
       Description nvarchar(500),
       Url nvarchar(255) NOT NULL,
       Icon nvarchar(100),
       ParentId int,
       SortOrder int NOT NULL DEFAULT 0,
       IsVisible bit NOT NULL DEFAULT 1,
       Permission nvarchar(100),
       CreatedDate datetime2 NOT NULL DEFAULT GETUTCDATE(),
       ModifiedDate datetime2,
       IsActive bit NOT NULL DEFAULT 1,
       FOREIGN KEY (ParentId) REFERENCES Menus(Id)
   );
   ```

5. **Run the application**
   ```bash
   dotnet run --project WebApp
   ```

6. **Access the application**
   - Open browser to `https://localhost:5001` or `http://localhost:5000`

## Architecture Benefits

### Clean Architecture Principles
- **Dependency Inversion**: Core layer has no dependencies on other layers
- **Separation of Concerns**: Each layer has a specific responsibility
- **Testability**: Easy to unit test with dependency injection
- **Maintainability**: Clear structure makes code easy to understand and modify

### Dependency Flow
```
WebApp → Application → Core
   ↓         ↓
Infrastructure → Core
```

### Key Design Patterns
- **Repository Pattern**: Data access abstraction
- **Dependency Injection**: Loose coupling between components
- **DTO Pattern**: Clean data transfer between layers
- **Service Layer**: Business logic encapsulation

## Configuration

### Connection Strings
Update `appsettings.json` with your database connection:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=true;"
  }
}
```

### Application Settings
Customize application behavior in `appsettings.json`:
- Page sizes for pagination
- Lock durations for resource management
- Security settings for authentication
- Email configuration for notifications

## Development Notes

### Adding New Features
1. **Entities**: Add to Core/Entities
2. **Interfaces**: Define in Core/Interfaces
3. **Services**: Implement in Application/Services
4. **Repositories**: Add to Infrastructure/Data/Repositories
5. **Controllers**: Create in WebApp/Controllers
6. **Views**: Add to WebApp/Views

### Logging
The application uses structured logging throughout:
- Request/response logging
- Error handling and logging
- Business operation logging
- Performance monitoring

### Error Handling
- Global exception handling in Program.cs
- Controller-level error handling
- User-friendly error pages
- Detailed logging for debugging

## Next Steps

1. **Authentication**: Add user authentication and authorization
2. **API Layer**: Create Web API controllers for mobile/external access
3. **Caching**: Implement caching for better performance
4. **Background Services**: Add background job processing
5. **Testing**: Add unit and integration tests
6. **Documentation**: Add API documentation with Swagger

## Contributing

1. Follow the clean architecture principles
2. Add appropriate logging to new features
3. Include error handling
4. Update documentation as needed
5. Test thoroughly before submitting changes
