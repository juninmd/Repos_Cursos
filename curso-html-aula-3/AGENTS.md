```markdown
# AGENTS.md - Coding Agent Guidelines

These guidelines are designed to ensure efficient, maintainable, and high-quality code development for the AGENTS repository. Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

*   All functions, classes, and modules should have single, well-defined responsibilities.
*   Avoid duplicating logic and data structures across multiple files.
*   Leverage composition over inheritance to reduce code complexity.
*   Implement generic solutions where appropriate to minimize code repetition.

## 2. KISS (Keep It Simple, Stupid)

*   Strive for the simplest solution that meets the requirements.
*   Avoid unnecessary complexity.
*   Prioritize readability and clarity.
*   Document assumptions and constraints clearly.
*   Refactor code to improve its overall maintainability.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class or module should have only one reason to change.
*   **Open/Closed Principle:** The system should be extensible without modifying the existing code.  Implement by adding new classes without modifying existing ones.
*   **Liskov Substitution Principle:**  Subclasses must be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Client code should not be forced to depend on methods it does not use.
*   **Dependency Inversion Principle:** High-level modules should not depend on low-level modules.  Instead, they should depend on abstractions.

## 4. YAGNI (You Aren't Gonna Need It)

*   Avoid adding functionality that is not currently required.
*   Focus on implementing essential features for the immediate task.
*   Refactor code to remove unnecessary complexity or functionality.

## 5. Code Quality & Structure

*   **File Size:** Each file should ideally contain no more than 180 lines of code.  Adjust as needed.
*   **Naming Conventions:** Consistent and descriptive naming conventions are mandatory. See [AGENTS_Naming_Guidelines](link to file).
*   **Comments:**  Provide clear and concise comments where necessary to explain complex logic or assumptions.  Keep comments focused on *why* not *what*.
*   **Error Handling:** Implement robust error handling and logging to facilitate debugging and maintainability.  Avoid exposing sensitive information.
*   **Testing:** All development must be productive. Do not use mocks or fake implementations. Use mocks ONLY for tests.  Write unit tests for all functions and classes.
*   **Data Structures:** Utilize appropriate data structures for optimal performance. Consider alternatives where they improve readability.
*   **Code Formatting:**  Use a code formatter (e.g., Black) to maintain consistent code style.

## 6. Testing & Coverage

*   **Unit Tests:**  Aim for 80% test coverage.  Tests should cover all critical functionalities.
*   **Test Design:**  Each test should have a clear purpose and verify a specific aspect of the code.
*   **Test Framework:** Utilize a standardized testing framework (e.g., pytest, unittest).
*   **Test Case Structure:**  Follow a consistent test case structure for maintainability.

## 7. Project Specifics

*   **Message Broker:** Utilize a robust message broker (e.g., RabbitMQ) for asynchronous communication.
*   **Database:** Employ a relational database (e.g., PostgreSQL) for data persistence.
*   **Resource Management:** Implement proper resource management to prevent resource leaks.
*   **Logging:** Implement comprehensive logging to aid in debugging and monitoring.

## 8.  General Principles

*   **Readability:** Prioritize clear and readable code.
*   **Maintainability:** Design code that is easy to understand and modify.
*   **Collaboration:**  Code should be designed for collaboration and reusability.
*   **Documentation:**  Include clear documentation to explain code functionality.


These guidelines are subject to change as the AGENTS repository evolves. Updates will be communicated to the team.
```