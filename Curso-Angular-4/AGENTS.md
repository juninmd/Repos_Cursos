```markdown
# AGENTS.md - AI Coding Agent Guidelines

These guidelines are designed to ensure consistent, maintainable, and high-quality code for our AI coding agents. Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

*   All logic, data structures, and API definitions should be encapsulated within reusable components and functions.
*   Avoid duplicating code across multiple files.
*   Favor creating single-purpose modules with clearly defined responsibilities.
*   When a component needs to perform multiple functions, create a dedicated module.

## 2. KISS (Keep It Simple, Stupid)

*   Code should be easy to understand and maintain.
*   Minimize complexity within each module and function.
*   Favor straightforward solutions over overly clever ones.
*   Break down complex tasks into smaller, manageable sub-tasks.
*   Use clear and concise naming conventions.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class or module should have one, and only one, reason to change.
*   **Open/Closed Principle:**  The system should be extensible without modifying the core logic.  New functionality should be added as separate modules.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:**  Clients should not be forced to depend on methods they do not use.
*   **Dependency Inversion Principle:** High-level modules should be based on low-level modules, which in turn should be based on interfaces.

## 4. YAGNI (You Aren't Gonna Need It)

*   Avoid implementing features or functionalities that are not currently required.
*   Focus solely on providing the functionality required at the current time.
*   Refactor and update code incrementally, minimizing unnecessary additions.
*   Prioritize clarity and correctness over premature optimization.

## 5. Code Structure & File Limits

*   Each file must be no more than 180 lines of code.
*   File names must be descriptive and follow a consistent naming convention (e.g., `module.py`, `component.js`).
*   Comments should explain the *why* behind the code, not just the *what*.  Focus on reasoning.
*   Use docstrings to explain the purpose, inputs, and outputs of functions and classes.

## 6. Test Coverage Requirements

*   **Minimum:** 80% of code must be covered by unit tests.
*   Tests must be designed to cover critical logic and edge cases.
*   Tests should clearly define expected outcomes and states.
*   Focus on testing the *behavior* of the code, not just the implementation details.
*   Use a testing framework of your choice (e.g., `pytest`, `unittest`).

## 7. Development Practices

*   Follow established coding style guides (e.g., PEP 8 for Python).
*   Write clean and readable code.
*   Use meaningful variable and function names.
*   Implement proper error handling and logging.
*   Continuously refactor code to improve its quality.

## 8. Mocking Strategy

*   All external dependencies (APIs, databases, etc.) *must* be mocked. No actual implementations are to be used.
*   Mocking should be automated and consistent across all testing.
*   Mock data should be stable and predictable.
*   Mocking should focus on testing interaction with external services, not on complex business logic.

## 9.  Documentation & README

*   Each file should include a clear README with a description of its purpose.
*   Code should be well-documented, following a consistent style.
*   Include usage examples within the documentation.

## 10.  Code Review Process

*   All code changes should be reviewed by at least one other developer before merging.
*   Review should focus on correctness, adherence to principles, and maintainability.
*   Address all feedback thoroughly and promptly.

These guidelines are a living document and will be reviewed and updated periodically.
```