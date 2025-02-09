# RecipeMaster 🍳📁

A C# console application for managing recipes, built with **SOLID principles** and **design patterns** to demonstrate clean, scalable architecture. Save recipes in JSON or text formats, and explore how software design translates to maintainable code!

[![.NET](https://img.shields.io/badge/.NET-6.0-blue)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

---

## 🚀 Features

- **Create Recipes**: Select ingredients from a predefined list (e.g., flour, sugar, cocoa).
- **Save/Load Recipes**: Persist recipes in **JSON** (structured) or **Text** (readable) formats.
- **Scalable Architecture**: Easily extend with new file formats or ingredients.

---

## 🛠️ Technical Stack

- **C# & .NET 6**: Core framework for backend logic.
- **File I/O**: Read/write recipes to files dynamically.
- **Design Patterns**: Factory, Template Method, Strategy.
- **SOLID Principles**: Full adherence for clean, testable code.

---

## 🔍 SOLID Principles in Action

| Principle              | Implementation Example                                                                 |
|------------------------|---------------------------------------------------------------------------------------|
| **Single Responsibility** | `RecipesConsoleUserInteraction` handles **only UI logic**, `RecipesRepository` manages storage. |
| **Open/Closed**            | Add new file formats (e.g., XML) by extending `StringRepository`, no code changes needed. |
| **Liskov Substitution**    | Subclasses like `StringJsonRepository` replace `StringRepository` without breaking logic. |
| **Interface Segregation**  | `IStringRepository` focuses solely on serialization.                                  |
| **Dependency Inversion**   | `CookbookApp` depends on `IRecipesRepository` (abstraction), not concrete classes.    |

---

## 🎨 Design Patterns Used

### 1. **Factory Pattern**
Dynamically instantiate repositories based on user-selected formats:
```csharp
// In Program.cs
IStringRepository repo = selectedFormat == FileFormat.Json 
    ? new StringJsonRepository() 
    : new StringTextualRepository();
