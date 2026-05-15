```markdown
# AGENTS.md - AI Coding Agent Guidelines

These guidelines are designed to ensure the creation and maintenance of high-quality, efficient, and maintainable AI coding agents within this repository. Adherence to these principles is crucial for maximizing productivity and minimizing errors.

## 1. DRY (Don't Repeat Yourself)

*   **Single Responsibility Principle:** Each agent should have a clearly defined, focused responsibility. Avoid creating multiple agents with overlapping functionality.
*   **Component Reuse:** Design agents with reusable components where possible. Consider creating abstract interfaces for common functionalities.
*   **Abstraction:** Implement complex logic in abstract components, reducing duplication of code within agents.
*   **Code Patterns:** Utilize established code patterns to improve maintainability and readability.

## 2. KISS (Keep It Simple, Stupid)

*   **Minimalist Code:** Strive for the shortest possible code solution that achieves the desired result. Avoid unnecessary complexity.
*   **Readability:** Write code that is easy to understand and follow. Use descriptive variable and function names.
*   **Comments:**  Only comment where clarity is needed – don’t over-comment. Focus on explaining *why* not *what*.

## 3. SOLID Principles

*   **Single Responsibility:** Each class/agent should have one and only one reason to change.
*   **Open/Closed Principle:**  The system should be extensible without modifying its internals.  New functionality can be added via new agents.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Each interface should define only the methods that its implementing classes need.
*   **Dependency Inversion Principle:**  High-level modules (agents) should be replaced by low-level modules (concrete agents).

## 4. YAGNI (You Aren’t Gonna Need It)

*   **Avoid Future Assumptions:**  Do not implement features or logic that are not currently required by the agents.
*   **Focus on Current Tasks:** Each agent should be designed to perform its specific task efficiently.
*   **Resilience to Changes:**  Ensure the agent's design doesn't become overly reliant on specific future requirements.

## 5. Development Practices

*   **Unit Tests:** All code must be thoroughly tested with unit tests to ensure functionality.
*   **Test Coverage:**  Aim for at least 80% test coverage. Utilize a comprehensive test suite incorporating various scenarios.
*   **Integration Tests:**  Design and execute integration tests to validate agent interactions.
*   **Code Reviews:**  Submit all code for review by other team members to identify potential issues and ensure adherence to guidelines.
*   **Version Control:**  Use a version control system (e.g., Git) for all code changes.

## 6. Code Length Limits

*   **Maximum Code Length:**  Each file must not exceed 180 lines of code.  No exceptions to this limit.

## 7.  File Structure

*   **Clear Directory Structure:** Follow a well-defined directory structure for organizing code.
*   **Modular Design:** Each agent should ideally be encapsulated within a separate module or class.
*   **Naming Conventions:** Use consistent and descriptive naming conventions for files, classes, and functions.

## 8.  Documentation

*   **README:**  A comprehensive README file explaining the purpose of the repository, how to use the agents, and any relevant context.
*   **Docstrings:**  Use docstrings to explain the purpose, parameters, and return values of functions and classes.
*   **Comments:**  Provide clear and concise comments to explain complex logic and design decisions.

## 9.  Testing

*   **Test-Driven Development:**  Prioritize writing tests *before* implementing code.
*   **Test Case Design:**  Create test cases that cover a wide range of scenarios and edge cases.
*   **Automated Testing:**  Implement automated test suites to ensure code quality and prevent regressions.

## 10.  Commit Practices

*   **Commit Messages:**  Write clear and concise commit messages explaining the changes made.
*   **Small, Focused Commits:**  Break down large changes into smaller, manageable commits.
*   **Code Review Before Commit:**  Always review code before committing it to the repository.

## 11.  Collaboration

*   **Code Collaboration:**  Encourage collaboration and pair programming to improve code quality.
*   **Regular Synchronization:**  Establish a regular schedule for code synchronization and review.

These guidelines are a framework to guide the development of the AGENTS.md repository.  They are intended to promote collaboration, maintainability, and efficiency.  Any deviations from these guidelines must be carefully justified and documented.
```