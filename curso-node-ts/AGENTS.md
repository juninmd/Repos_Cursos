```markdown
# AGENTS.md - AI Coding Agent Guidelines

These guidelines are designed to ensure the consistent, efficient, and robust development of AI coding agents within this repository. Adherence to these principles is crucial for maintaining code quality and reducing maintenance overhead.

## 1. DRY (Don't Repeat Yourself)

*   All logic, data structures, and utility functions must be defined and reused across multiple components.
*   Avoid duplicating code; identify opportunities for abstraction and polymorphism.
*   When necessary, use functions or classes to encapsulate reusable logic.

## 2. KISS (Keep It Simple, Stupid)

*   Prioritize clarity and readability over complex solutions.
*   Strive for concise and understandable code.
*   Minimize unnecessary complexity.
*   Design for maintainability – make it easy to understand and modify.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/component should have one, and only one, reason to change.
*   **Open/Closed Principle:** The system should be extensible without modifying existing code.  New functionality should be added via new classes/components.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the system.
*   **Interface Segregation Principle:**  Clients should not be forced to implement interfaces they don’t need.
*   **Dependency Inversion Principle:**  High-level modules (classes) should be dependent on low-level modules (interfaces) and not each other.

## 4. YAGNI (You Aren't Gonna Need It)

*   Only implement functionality that is currently required.
*   Avoid adding features or code that isn’t directly relevant to the current task.
*   Refactor to remove unnecessary code; only implement what is needed now.

## 5. Code Style & Formatting

*   Follow a consistent code style (e.g., PEP 8 for Python).
*   Use consistent indentation and spacing.
*   Employ clear and descriptive variable and function names.
*   Include comments where necessary to explain complex logic or assumptions.

## 6. File Size Limit: 180 Lines

*   Each file must be limited to 180 lines of code.
*   Code should be logically organized and avoid excessive blank lines.

## 7. Test Coverage Requirements: 80%

*   All development must be evaluated based on a minimum test coverage of 80%.
*   Automated tests should be implemented to verify functionality.
*   Test cases should be designed to cover critical code paths and edge cases.

## 8.  Development Process

*   Each change should be accompanied by a clear, concise description in the commit message.
*   Code should be reviewed by another developer before merging.
*   Issues must be addressed and tracked appropriately.

## 9.  Data Handling

*   Data representations are to be minimal and focused on the task at hand.
*   Avoid storing unnecessary data.
*   Data validation is to be implemented where applicable.

## 10. Dependencies & External Libraries

*   Only use well-established and vetted libraries.
*   Clear documentation of dependencies is required for each package.
*   Dependencies are to be version-controlled.

## 11.  Unit Testing Framework

*   Utilize a dedicated unit testing framework (e.g., pytest, unittest).
*   Tests should be designed to cover all core functionality.
*   Provide clear assertion messages.

## 12.  Error Handling & Logging

*   Use meaningful error messages to aid debugging.
*   Implement robust logging to track program activity.
*   Log relevant details, not just errors.

## 13.  Version Control

*   Use a version control system (e.g., Git).
*   Commit code frequently with meaningful commit messages.
*   Branching strategy should be clearly defined.

## 14.  Documentation

*   Provide clear and concise documentation for all functions, classes, and modules.
*   Document data structures and algorithms.
*   Document API usage.

## 15.  Maintainability and Reusability

*   Design code to be easily modified and extended in the future.
*   Implement functions or classes that can be reused in different contexts.
*   Code should be modular and loosely coupled.

## 16.  Specific Considerations for AI Agents

*   Code must represent the agent’s core logic – prioritization, state, and actions.
*   Data structures and algorithms for representation should be considered; efficiency is a primary goal.
*   Algorithm design emphasizes robustness and adaptability to changing environments.

## 17.  Code Review Process

*   All code must be reviewed by another AI agent before deployment.
*   Review should include: functionality, efficiency, and adherence to SOLID principles.
*   Review feedback should be addressed promptly.

These guidelines are intended as a starting point and may be adapted as the project evolves. Regular review and refinement are necessary to maintain the quality and consistency of the AGENTS.md file.
```