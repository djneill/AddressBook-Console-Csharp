# AddressBook.Console

A console-based address book application built with C# as a learning project. This application allows users to input and store contact information including names and addresses.

## 🎯 Project Overview

This is a beginner-friendly C# console application that demonstrates fundamental programming concepts including:

- Object-oriented programming (OOP)
- Data models and relationships
- User input validation
- Collections (List<T>)
- Static methods
- Console I/O operations

## 📋 Features

- **Add Multiple Contacts**: Input multiple people's information in a single session
- **Address Management**: Store complete address details for each contact
- **Input Validation**: Validates numeric inputs for house numbers and zip codes
- **Simple Display**: Displays all entered contacts at the end of the session
- **Exit Option**: Type "exit" when prompted for first name to stop adding contacts

## 🏗️ Project Structure

```
nameAddress/
├── Program.cs           # Main entry point of the application
├── PersonModel.cs       # Person data model
├── AddressModel.cs      # Address data model
├── InputService.cs      # Handles user input and validation
├── ProcessPerson.cs     # Processes and displays person details
├── nameAddress.csproj   # Project configuration file
└── nameAddress.sln      # Solution file
```

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- A code editor (Visual Studio, VS Code, or any text editor)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/djneill/AddressBook.Console.git
cd AddressBook.Console
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

Hello John Doe
123 Main Street
Springfield IL 62701
```

## 📚 Learning Notes

This project helped me learn:

- **C# Syntax**: Coming from JavaScript/TypeScript, adapting to C#'s strongly-typed nature
- **Namespaces**: Understanding how C# organizes code
- **Properties**: Using auto-implemented properties with getters and setters
- **Static Methods**: When and why to use static methods
- **Input Validation**: Implementing TryParse for safe type conversion

## 🔄 Future Enhancements

- [ ] Add data persistence (save to file or database)
- [ ] Implement email address field (currently commented out)
- [ ] Add search functionality
- [ ] Create update and delete operations
- [ ] Add phone number support
- [ ] Implement data export (CSV, JSON)
- [ ] Add unit tests
- [ ] Create a GUI version using WPF or WinForms

## 🤝 Contributing

As this is a learning project, I welcome suggestions and feedback! Feel free to:

- Open issues for bugs or suggestions
- Submit pull requests with improvements

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 🙋‍♂️ Author

**DJ Neill**

- Learning Journey: Developing in JavaScript/TypeScript, learning C# / .NET
