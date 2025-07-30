# Name & Address Console Application

A refactored console-based address book application built with C# and .NET 9.0. This application demonstrates clean code practices and modern C# features while allowing users to manage contact information.

## 🎯 Project Overview

This C# console application showcases programming concepts with a focus on clean architecture and separation of concerns:

- **Object-Oriented Programming (OOP)**: Clear separation between data models and business logic
- **Service-Oriented Design**: Dedicated input service for handling user interactions
- **Input Validation**: Robust validation for numeric inputs with user-friendly error messages
- **Collections Management**: Efficient use of `List<T>` for storing multiple contacts
- **Static Methods**: Appropriate use of static methods for stateless operations
- **Clean Code Principles**: Readable, maintainable, and well-organized code structure

## 📋 Features

- **Multi-Contact Support**: Add unlimited contacts in a single session
- **Comprehensive Address Data**: Capture complete address information including:
  - House number with integer validation
  - Street name
  - City
  - State
  - ZIP code with integer validation
- **User-Friendly Interface**: Clear prompts and error messages
- **Graceful Exit**: Type "exit" at any time to finish and view all contacts
- **Data Display**: Clean, formatted output of all entered contacts

## 🏗️ Project Structure

```
nameAddress/
├── Models/
│   ├── PersonModel.cs       # Person entity with name properties
│   └── AddressModel.cs      # Address entity with location properties
├── Services/
│   └── InputService.cs      # Handles all user input and validation
├── Processors/
│   └── ProcessPerson.cs     # Formats and displays person details
├── Program.cs               # Application entry point and main loop
├── nameAddress.csproj       # .NET 9.0 project configuration
└── nameAddress.sln          # Visual Studio solution file
```

## 🚀 Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- A code editor (Visual Studio 2022, VS Code, or Rider recommended)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/djneill/AddressBook-Console-Csharp.git
cd AddressBook-Console-Csharp
```

2. Build the project:

```bash
dotnet build
```

3. Run the application:

```bash
dotnet run
```

## 💻 Usage

1. When the application starts, you'll be prompted to enter a first name
2. Enter the person's first and last name
3. Enter their complete address information:
   - House number (must be a valid integer)
   - Street name
   - City
   - State
   - Zip code (must be a valid integer)
4. Continue adding more contacts or type "exit" when prompted for a first name
5. The application will display all entered contacts before closing

### Example Session

```
What is your first name or type (exit) to stop: John
what is your last name: Doe
Enter your house number: 123
Enter your street name: Main Street
Enter your city: Springfield
Enter your state: IL
Enter your zip: 62701

What is your first name or type (exit) to stop: exit

John Doe
123 Main Street
Springfield IL 62701
```

## 🔧 Refactoring Highlights

This project has been refactored to demonstrate clean code principles:

### Architecture Improvements

- **Separation of Concerns**: Code is now organized into logical folders:
  - `Models/` - Data structures with single responsibility
  - `Services/` - Business logic and user interaction handling
  - `Processors/` - Data formatting and presentation
- **Single Responsibility Principle**: Each class has one clear purpose
- **Dependency Management**: Clear relationships between components
- **Improved Readability**: Consistent naming conventions and code organization

### Technical Updates

- **Upgraded to .NET 9.0**: Leveraging the latest framework features
- **Enhanced Input Validation**: Robust error handling with user-friendly messages
- **Streamlined Main Program**: Cleaner application flow in `Program.cs`

## 📚 Learning Notes

This project helped me learn:

- **C# Syntax**: Coming from JavaScript/TypeScript, adapting to C#'s strongly-typed nature
- **Namespaces**: Understanding how C# organizes code and prevents naming conflicts
- **Properties**: Using auto-implemented properties with getters and setters
- **Static Methods**: When and why to use static methods for stateless operations
- **Input Validation**: Implementing TryParse for safe type conversion
- **Code Organization**: Structuring projects with proper folder hierarchy
- **Clean Code Principles**: Writing maintainable and scalable applications

## 🔄 Future Enhancements

### Data Features

- [ ] Add data persistence (JSON, SQLite, or SQL Server)
- [ ] Implement email and phone number fields
- [ ] Add data validation for email and phone formats
- [ ] Implement data export/import (CSV, JSON, XML)

### Application Features

- [ ] Add search functionality (by name, address, city, etc.)
- [ ] Implement CRUD operations (Create, Read, Update, Delete)
- [ ] Add sorting options (alphabetical, by city, by state)
- [ ] Implement duplicate detection

### Technical Improvements

- [ ] Add comprehensive unit tests
- [ ] Implement dependency injection
- [ ] Add logging functionality
- [ ] Create configuration file support
- [ ] Add async/await patterns where appropriate

### UI Enhancements

- [ ] Create a GUI version using WPF or WinForms
- [ ] Add a web interface using ASP.NET Core
- [ ] Implement a REST API for the address book

## 🤝 Contributing

As this is a learning project, I welcome suggestions and feedback! Feel free to:

- Open issues for bugs or suggestions
- Submit pull requests with improvements

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## ✍️ Author

**DJ Neill**

- Learning Journey: Developing in JavaScript/TypeScript, learning C# / .NET
