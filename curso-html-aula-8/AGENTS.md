```markdown
# AGENTS.md File Guidelines

These guidelines are designed to ensure the development of AI coding agents within this repository are robust, maintainable, and efficient. Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

- Every function, class, and module should have a single, clearly defined purpose.
- Avoid duplicating code across different files.
- When necessary, refactor code to minimize redundancy.

## 2. KISS (Keep It Simple, Stupid)

- Code should be concise and easy to understand.
- Avoid overly complex logic or convoluted structures.
- Prioritize readability and maintainability over unnecessary features.

## 3. SOLID Principles

- **Single Responsibility Principle:** Each class/module should have a single, well-defined responsibility.
- **Open/Closed Principle:**  The system should be extensible without modifying its core implementation.
- **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
- **Interface Segregation Principle:** Clients should not be forced to depend on methods they do not use.
- **Dependency Inversion Principle:** High-level modules should not depend on low-level modules; they should depend on abstractions.

## 4. YAGNI (You Aren't Gonna Need It)

-  Avoid adding features or code that is not currently required for the core functionality.
-  Focus on delivering the necessary functionality for the immediate task.

## 5. Code Structure & Formatting

- **File Size Limit:** Each file must not exceed 180 lines of code.
- **Naming Conventions:** Use descriptive and consistent naming conventions (e.g., camelCase for functions and classes, snake_case for variables).
- **Comments:**  Write clear and concise comments explaining the *why* behind the code, not just the *what*.  Focus on the reasoning and context.
- **Code Organization:** Group related code into logical blocks/sections within each file.
- **Consistent Formatting:**  Maintain consistent indentation and spacing throughout the codebase.  Use a code formatter (e.g., Black for Python) if possible.

## 6. Testing & Verification

- **Unit Tests Only:**  All development must be driven by unit tests.  No reliance on mocks or fake implementations.
- **Test Coverage:** Aim for at least 80% test coverage.  Use a test framework (e.g., pytest, unittest) appropriately.
- **Test Design:**  Tests should be focused on verifying specific, isolated scenarios and edge cases.
- **Test Data Management:**  Ensure test data is well-defined and consistent.

## 7. Development Process

- **Small, Incremental Changes:**  Break down development into small, manageable tasks.
- **Code Reviews:**  Mandatory code reviews for all changes.
- **Version Control:** Use Git and a proper branching strategy (e.g., Gitflow).
- **Documentation:**  Maintain clear and concise documentation for all code, including API definitions and design decisions.

## 8.  Specific Considerations (Specific to the AGENTS.md project - modify as needed)

-  Ensure all data structures and algorithms are efficient.
-  Prioritize modular design for maintainability.
-  Implement clear error handling and logging.
-  Consider logging key information/state changes at intervals.


## 9.  Deliverables

-  All files must be committed to the repository with appropriate commit messages.
-  Regularly test the codebase to ensure functionality and identify bugs.
-  Maintain and update documentation as needed.
-  Continuously improve the codebase based on feedback and testing results.

```