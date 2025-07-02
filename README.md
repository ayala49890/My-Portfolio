# My-Portfolio
This is the backend API for my personal portfolio site, built with ASP.NET Core 8 and connected to a React frontend.  
The project demonstrates a clean architecture, RESTful controllers, and service-based logic separation.
in progress.

## Technologies Used

- ASP.NET Core 8 (Web API)
- C#
- React 18 (Frontend, in separate repo or folder)
- Entity Framework Core / In-Memory Mock Data
- Dependency Injection
- AutoMapper
- RESTful API Design
- Swagger / OpenAPI

## Project Structure

- `Core` – DTOs, interfaces, and domain models
- `Services` – Business logic and service implementations
- `Data` – Data access (mock or real DB)
- `API` – Controllers and API configuration

## Getting Started

To run the API locally:

1. Clone the repository  
   `git clone https://github.com/your-username/your-repo-name.git`

2. Navigate to the API folder  
   `cd YourProject.API`

3. Run the project  
   `dotnet run`

4. Open Swagger for testing  
   `https://localhost:5001/swagger`

> Note: The React frontend is located in a separate folder/repository.
## Unit Testing

This project includes a dedicated Unit Tests project covering core business logic and services.  
Unit tests help ensure code stability, facilitate maintenance, and demonstrate professional development practices.

### Running Tests

To run the tests, navigate to the test project folder and execute:

```bash
dotnet test

