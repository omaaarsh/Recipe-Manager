# RecipeMaster 🍳📁

A C# console application for managing recipes, built with **SOLID principles** and **design patterns** to demonstrate clean, scalable architecture. Save recipes in JSON or text formats, and explore how software design translates to maintainable code!

[![.NET](https://img.shields.io/badge/.NET-6.0-blue)](https://dotnet.microsoft.com/)

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
```

### 2. **Template Method**
`StringRepository` centralizes file I/O logic, while subclasses handle format-specific details:
```csharp
abstract class StringRepository : IStringRepository
{
    public List<string> Read(string filePath)
    {
        // Common file reading logic
        return TextToString(content); // Delegated to subclass
    }
    protected abstract List<string> TextToString(string content);
}
```

### 3. **Strategy Pattern**
Interchangeable serialization strategies (JSON vs. Text) via `IStringRepository`.

---

## 📥 Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/RecipeMaster.git
   cd RecipeMaster
   ```

2. **Run the app**:
   ```bash
   dotnet run
   ```

3. **Toggle formats**:
   - Modify `selectedFormat` in `Program.cs` to switch between `FileFormat.Json` and `FileFormat.Txt`.

```

**Happy coding (and cooking)!** 🍪💻  
```

---

### Key Additions:
1. **Badges**: For .NET version and license (customize links as needed).
2. **SOLID Table**: Clear mapping of principles to code.
3. **Code Snippets**: Highlight critical patterns (Factory, Template Method).
4. **Project Structure**: Visualize the architecture for new contributors.
5. **Screenshot Section**: Add images of JSON/text outputs (replace paths with yours).

Add this to your repo, and developers will instantly grasp the **design philosophy** and **technical rigor** behind your work! 🚀
