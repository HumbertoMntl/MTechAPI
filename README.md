# MTech Employee API

This project is an API for managing employees, developed as a technical challenge for MTech.  
It allows you to store employees in a SQL Server database, validate RFC uniqueness and format, and query employees sorted by date of birth and optionally filtered by name.

## Features

- Store employees in SQL Server LocalDB
- Validate RFC (Mexican Tax ID) uniqueness and format
- Retrieve employees sorted by birth date, optional filter by name
- Automatic documentation with Swagger/OpenAPI
- Clean, commented, and extendable code

## Technologies

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server LocalDB
- Swagger / OpenAPI

## How to run the project

1. **Clone or download the repository**
2. **Restore NuGet packages** in Visual Studio
3. **Run the project**
    - Press F5 or click "Start Debugging"
    - Open `https://localhost:{port}/swagger` in your browser

> **Note:** The database is automatically created using SQL Server LocalDB when the project is first run.
## Sample POST request to /api/employees

```json
{
  "name": "Humberto",
  "lastName": "Montiel",
  "rfc": "MONT800101ABC",
  "bornDate": "1980-01-01T00:00:00",
  "status": 1
}
```
## 📸 Screenshots

### Swagger UI  
Browse and test all endpoints directly from your browser.

![Swagger](images/Swagger.png)

---

### Creating an Employee (POST)  
Example of sending data to add a new employee:

![POST Request](images/Post.png)

**Success Response:**

![POST Response](images/Post-Res.png)

---

### Retrieving Employees (GET)  
Filtering by name and general results:

**GET by name**
![GET-Res](images/Get-Res.png)

**GET all employees**
![GET-Res2](images/Get-Res2.png)
