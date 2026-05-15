```markdown
# AGENTS.md File Guidelines

These guidelines are designed to ensure the stability, maintainability, and quality of the AGENTS.md repository. Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

*   All code snippets, functions, and components must be reusable and avoid duplication.
*   Identify and extract common patterns into reusable components.
*   Implement common logic into separate modules.
*   Use design patterns where appropriate to reduce code repetition.

## 2. KISS (Keep It Simple, Stupid)

*   Code should be easy to understand and follow.
*   Avoid unnecessary complexity.
*   Prioritize clarity over cleverness.
*   Strive for straightforward implementation.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class or module should have one, and only one, reason to change.
*   **Open/Closed Principle:**  The system should be extensible without modifying the existing code.
*   **Liskov Substitution Principle:**  Subclasses must be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Each interface should have only the methods that are used by its clients.
*   **Dependency Inversion Principle:**  High-level modules should be dependent on low-level modules, not vice-versa.

## 4. YAGNI (You Aren't Gonna Need It)

*   Implement only the required functionality.
*   Don't add features or code that isn't explicitly required for the current task.
*   Refactor code before adding new functionality to prevent unnecessary complexity.

## 5. Code Structure & File Organization

*   **File Size Limit:** Each file must be no more than 180 lines of code.
*   **Categorization:** Files should be organized by functionality or component.
*   **Naming Conventions:** Use consistent naming conventions.  See [Naming Conventions Document](link to naming conventions document) for specifics.
*   **Comments:**  Provide clear, concise comments explaining complex logic or design decisions.  Comments should enhance understanding, not merely restate code.
*   **Modular Design:** Break down large modules into smaller, manageable units.

## 6. Testing & Verification

*   **All Tests Must Be Functional.** Tests must directly verify the behavior of the code.
*   **Unit Tests:**  Each function and class should have at least one unit test.
*   **Contract Tests:** Implement tests based on contract (defined in [Contract Test Documentation](link to contract test documentation)).
*   **Test Coverage:** Target 80% coverage with automated tests.
*   **Test Driven Development:**  Prioritize writing tests before implementation.

## 7. Code Quality & Style

*   **Code Formatting:** Adhere to a consistent code style (e.g., using [Style Guide](link to style guide)).
*   **Readability:**  Write code that is easy to read and understand.
*   **Error Handling:** Implement basic error handling to prevent unexpected crashes.
*   **Security:** Be mindful of security considerations (e.g., input validation).

## 8.  Reporting & Review

*   **Commit Messages:**  Use informative and concise commit messages.
*   **Code Reviews:**  Subject all changes to review before merging.
*   **Documentation:** Document significant changes and design decisions.

## 9.  Specific Considerations

*   **Data Structures:** Specify data structures clearly and concisely.
*   **Algorithms:** Use appropriate algorithms for each task.
*   **Error Handling:** Implement a robust error handling strategy.


This document represents the fundamental principles and guidelines for the AGENTS.md project.  Regular review and updates are encouraged.
```