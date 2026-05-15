```markdown
# AGENTS.md - Guidelines for AI Coding Agents

These guidelines are designed to ensure high-quality, maintainable, and reliable AI coding agents.  Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

*   **Single Responsibility Principle:** Each agent should have a single, well-defined purpose. Avoid creating overly complex agents with multiple responsibilities.
*   **Modular Design:** Break down complex agents into smaller, reusable modules. Each module should have a clearly defined scope and interface.
*   **Abstraction:**  Provide abstract interfaces for agents that encapsulate implementation details.  This allows for easy replacement or modification of implementations without affecting other agents.
*   **Code Reuse:** Encourage code reuse across agents where appropriate.  Leverage existing libraries and patterns.

## 2. KISS (Keep It Simple, Stupid)

*   **Minimal Code:**  Strive for the shortest possible code that achieves the desired functionality.  Avoid unnecessary complexity.
*   **Readability:** Prioritize clear and understandable code. Use meaningful variable and function names.
*   **Comments:** Provide concise and helpful comments where necessary, but avoid over-commenting.
*   **Error Handling:**  Handle potential errors gracefully and provide informative error messages.  Don't mask errors with silent failures.

## 3. SOLID Principles

*   **Single Inheritance:**  Agents should primarily inherit from single, well-defined abstract classes or interfaces, not from multiple base classes. This enhances maintainability and reduces coupling.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:**  Clients should not be forced to depend on methods they don't use.
*   **Dependency Inversion Principle:**  Interfaces should be replaced by implementations. Dependencies should be hidden through abstraction.
*   **Open/Closed Principle:**  The agent's core logic should be open for extension but closed for modification.  New features should be added through interfaces.

## 4. YAGNI (You Aren't Gonna Need It)

*   **Avoid Over-Implementation:** Do not implement functionality that is not currently required or is likely to be needed in the future.
*   **Focus on Requirements:** Prioritize the implementation of functions and methods based on the specific requirements and use cases.
*   **Resist Feature Creep:**  Don't introduce new functionality unless it's absolutely essential.

## 5. Development Workflow & Testing

*   **Unit Testing:** All agent code must be thoroughly unit tested with appropriate test cases for all functions and methods.
*   **Test Coverage:** Aim for at least 80% test coverage.  Automated testing will be implemented.
*   **Version Control:** All code changes must be committed to a version control system (e.g., Git) with clear commit messages.
*   **Code Review:**  All code must be reviewed by at least one other developer.
*   **Integration Testing:**  Ensure that individual agent components integrate correctly.
*   **Regression Testing:** After any change, run regression tests to confirm that no new functionality has broken existing functionality.

## 6.  Maximum Code Length: 180 Lines

*   All code must be within the specified line limit.

## 7.  Production-Ready Code

*   Code must be well-formatted and follow established coding standards.
*   Code should be easily understandable and maintainable.
*   Error handling should be robust and predictable.
*   Documentation should be clear and concise.

## 8.  Documentation

*   Each agent should have a README.md file explaining its purpose, dependencies, and usage.
*   Code should be well-documented with comments.

## 9.  Error Handling & Logging

*   All agents should log errors effectively.
*   Exceptions should be handled gracefully and reported appropriately.
*   Error messages should be informative and helpful for debugging.

## 10.  Specific Considerations (Placeholder -  Future Expansion)

*   Consider the scalability of the agent design.
*   Plan for potential future expansions and modifications.
*   Utilize a modular design language for future enhancements (e.g., Protocol Buffers).

This document is intended as a guide and may be updated as the project evolves. Regular review and adherence to these principles are expected.
```