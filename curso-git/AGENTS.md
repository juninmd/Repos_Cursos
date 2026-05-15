# AGENTS.md Guidelines

These guidelines are designed to ensure the consistent, maintainable, and productive development of the AGENTS repository. Adherence to these principles is mandatory.

## 1. DRY (Don't Repeat Yourself)

*   All code within a file should have a single, well-defined purpose.
*   Avoid duplicate code blocks.
*   When implementing a solution, consider if it can be abstracted into a reusable component.
*   Refactor existing code to eliminate redundancies.

## 2. KISS (Keep It Simple, Stupid)

*   Strive for the simplest possible solution that meets the requirements.
*   Avoid over-engineering.
*   Prioritize readability and maintainability.
*   Favor straightforward logic over complex algorithms.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module/function should have one, and only one, reason to change.
*   **Open/Closed Principle:** The system should be extensible through mechanisms like interfaces and abstract classes.  New functionality should be added without modifying existing code.
*   **Liskov Substitution Principle:**  Subclasses must be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:**  Clients should not be forced to depend on methods they do not use.
*   **Dependency Inversion Principle:**  High-level modules should not depend on low-level modules. Interfaces define dependencies.

## 4. YAGNI (You Aren't Gonna Need It)

*   Implement only the functionality explicitly required.
*   Avoid adding features or code that is not currently necessary.
*   Focus on delivering working solutions first.
*   Refactor as needed, but only when the existing functionality proves to be a significant bottleneck or is no longer suitable.

## 5. Code Style & Conventions

*   **Naming Conventions:** Use snake_case for variables, functions, and classes.  Lowercase for constants.  Prefix functions with 'get_'.
*   **Indentation:** Use 2 spaces for indentation.
*   **Line Length:**  Keep lines under 120 characters.
*   **Commenting:**  Provide concise and relevant comments.  Use JSDoc-style comments for functions, classes, and modules.
*   **Error Handling:**  Use `try...catch` blocks for error handling where appropriate.
*   **Documentation:** Provide clear documentation for all functions and classes.
*   **Code Formatting:** Ensure consistent code formatting throughout the repository.

## 6. Development Process & Testing

*   **Version Control:** Use Git for version control. Commit frequently with descriptive messages.
*   **Code Reviews:** Conduct regular code reviews to ensure quality and adherence to standards.
*   **Unit Tests:**  Write comprehensive unit tests to verify the correctness of individual functions and components.  Aim for 80% code coverage.
*   **Integration Tests:**  Write integration tests to verify the interaction between different components.
*   **Test Driven Development:** Follow a test-driven development approach, where tests are written before code.
*   **Dependency Injection:** Utilize dependency injection to improve testability and modularity.
*   **Static Analysis:**  Employ static analysis tools (e.g., ESLint, SonarQube) to identify potential issues and enforce coding standards.

## 7. File Limits

*   Each file must not exceed 180 lines of code.

## 8. Specific File Structure Guidelines (Example - Adapt as needed)

*   **`src/` directory:** Contains source code.  Follow a consistent directory structure.
*   **`tests/` directory:** Contains test files.
*   **`docs/` directory:** Contains documentation.
*   **`README.md`:** Provides overview of the project, setup instructions, and usage examples.
*   **`LICENSE`:** Specifies the license under which the project is released.

## 9.  Additional Considerations:

*   **Documentation Standards:**  Follow established documentation standards for clarity and consistency.
*   **API Design:**  Consider API design principles when creating new components or functions.
*   **Security:**  Address security vulnerabilities proactively.

These guidelines are essential for maintaining a high-quality, stable, and understandable AGENTS repository.  Their consistent application will contribute significantly to the overall success of the project.