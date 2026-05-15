```markdown
# AGENTS.md File Guidelines

These guidelines are designed to ensure a consistent, maintainable, and high-quality codebase for the AGENTS repository. Adherence to these principles will significantly improve the overall productivity and reliability of our AI coding agents.

## 1. DRY (Don't Repeat Yourself)

*   All functions, classes, and modules should have single, well-defined responsibilities.
*   Avoid duplicating code. Refactor existing duplicated code whenever possible.
*   Use consistent naming conventions throughout the project.

## 2. KISS (Keep It Simple, Stupid)

*   Strive for the simplest solution that meets the requirements.
*   Avoid unnecessary complexity.
*   Prioritize readability and understandability.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module should have one, and only one, reason to change.
*   **Open/Closed Principle:**  The system should be extensible through public interfaces, without modifying the internal code.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Each interface should define only the methods that its clients actually use.
*   **Dependency Inversion Principle:** Interfaces should be replaced by implementations.

## 4. YAGNI (You Aren't Gonna Need It)

*   Avoid implementing features that are not currently needed.  Delay implementation until required.
*   Only implement functionality that is explicitly specified.

## 5. Code Structure & Formatting

*   **File Structure:**  Organize code into logical modules and packages.
    *   `modules/`:  Contains reusable components.
    *   `services/`:  Handles core logic.
    *   `data/`: Stores data (e.g., configuration, database connections).
    *   `models/`: Represents data structures.
    *   `utils/`:  Helper functions.
*   **Code Style:**  Use a consistent code style (e.g., PEP 8 for Python) and linting.  Automated formatters are highly encouraged.
*   **Comments:**  Write clear and concise comments explaining the *why* behind the code, not just the *what*.
*   **Naming Conventions:**
    *   Classes: PascalCase
    *   Methods: CamelCase
    *   Variables: Snake_case
    *   Functions:  camelCase
    *   Constants: Lowercase
*   **Line Length:** Max. 180 lines per file (excluding comments).
*   **Blank Lines:**  Use blank lines to separate logical blocks of code.

## 6. Test Coverage (Minimum 80%)

*   All code must be thoroughly tested with unit tests.
*   Unit tests should cover all critical functionality.
*   Test each function/class with a variety of inputs and edge cases.
*   Focus on integration tests to verify interactions between components.
*   Negative tests should include anticipated failures and boundary conditions.  Mocking will be used extensively for testing.

## 7.  Specific Rules & Considerations

*   **Data Structures:** Use appropriate data structures for efficiency and clarity. Consider using appropriate data types.
*   **Error Handling:** Implement robust error handling, logging, and potentially retry mechanisms.
*   **Asynchronous Operations:**  If applicable, use asynchronous programming to improve performance and responsiveness.
*   **Security:**  Consider security implications when designing systems.
*   **Documentation:** Provide clear and concise documentation for all classes, functions, and modules.
*   **Configuration:** Use configuration files to manage settings and dependencies.

## 8.  Existing Code Guidelines (Conceptual - Will be further defined):

*   [Placeholder for example code organization]
*   [Placeholder for example unit tests]
*   [Placeholder for example data structure definitions]

## 9.  Tools & Technologies

*   [List of supported languages/frameworks]
*   [IDE/Editor recommendations]
*   [Dependency management system (e.g., pip, npm, etc.)]

These guidelines are intended to serve as a reference for maintaining a robust and maintainable AGENTS.md file.  Regular review and updates will be conducted to ensure continued adherence to these principles.
```