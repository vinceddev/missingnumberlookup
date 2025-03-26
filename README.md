# Missing Number Finder (C# Console App)

## Description
This C# console application finds the missing number from an array containing distinct numbers taken from the range `0` to `n`. The solution is implemented following the **SOLID principles** to ensure maintainability, scalability, and testability.

## Problem Statement
Given an array containing numbers taken from the range `0` to `n`, find the missing number.

### Input:
An array of integers `nums`, where `nums` contains `n` distinct numbers from the range `0` to `n`.

### Output:
Return the missing number from the array.

### Examples:
```csharp
Input: [3, 0, 1]
Output: 2

Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8
```

## Implementation Details
- **Single Responsibility Principle (SRP):** Each class has a single well-defined responsibility.
- **Open/Closed Principle (OCP):** The implementation is open for extension but closed for modification.
- **Liskov Substitution Principle (LSP):** Interfaces and base classes are designed to allow derived classes to substitute without breaking functionality.
- **Interface Segregation Principle (ISP):** Small, specific interfaces are used instead of large general-purpose ones.
- **Dependency Inversion Principle (DIP):** High-level modules do not depend on low-level modules; instead, both depend on abstractions.

## Installation and Usage
### Prerequisites:
- .NET SDK (6.0 or later)

### Steps to Run:
1. Build the application:
   ```sh
   dotnet build
   ```
2. Run the application:
   ```sh
   dotnet run
   ```

## Testing
To run unit tests, use the following command:
```sh
dotnet test
