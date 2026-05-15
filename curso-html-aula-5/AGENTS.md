```markdown
# AGENTS.md - Guidelines for AI Coding Agents

These guidelines outline the specific requirements and principles for development of AI coding agents within this repository.  Adherence to these standards is mandatory for all development activities.

**1. DRY (Don't Repeat Yourself)**

*   All code should be encapsulated within reusable components.
*   Avoid duplication of logic, data structures, and utility functions.
*   When necessary, leverage existing libraries and frameworks, ensuring modularity.
*   Prioritize creating generic components with configurable parameters.

**2. KISS (Keep It Simple, Stupid)**

*   Code should be concise and easily understandable.
*   Favor straightforward approaches over overly complex solutions.
*   Minimize unnecessary abstractions and layers of indirection.
*   Ensure maintainability by limiting the complexity of individual functions/classes.

**3. SOLID Principles**

*   **Single Responsibility Principle:** Each class/module should have a single, well-defined purpose.
*   **Open/Closed Principle:**  The system should be extensible without modifying the core code.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Each interface should define only the methods needed by interested parties.
*   **Dependency Inversion Principle:** High-level modules should not depend on low-level modules; they should depend on abstractions.

**4. YAGNI (You Aren't Gonna Need It)**

*   Only implement functionalities that are currently required for the current task or phase.
*   Avoid adding unnecessary features or complexity based on assumptions about future needs.
*   Refactor code to remove any potential future use cases, assuming no new requirements will emerge.

**5. Testing & Code Quality**

*   **Unit Tests:** All functions/classes should be thoroughly tested with comprehensive unit tests.
*   **Test Coverage:**  At least 80% of the code must be covered by tests.  Automated test suites are essential.
*   **Code Clarity:**  Use descriptive variable and function names.  Maintain clear code structure.
*   **Commenting:**  Provide clear and concise comments explaining complex logic, non-obvious decisions, and the purpose of specific sections.  Comment judiciously.
*   **Error Handling:**  Implement robust error handling, including informative error messages and appropriate exceptions.
*   **Avoid Side Effects:** Functions should primarily operate on input arguments and return results without modifying external state.
*   **Data Validation:** Implement data validation to ensure data integrity.

**6. File Structure & Code Size**

*   Each file should be no more than 180 lines of code.
*   File names should be descriptive and follow a consistent naming convention.
*   Code should be organized into logical sections/modules.
*   Use appropriate indentation and formatting for readability.

**7.  Specific Requirements**

*   **Agent Initialization:**  All agent initialization should be encapsulated within a dedicated class/module.
*   **Communication Protocols:** Define clear communication protocols between agents, utilizing defined data formats and messaging systems.
*   **State Management:** Implement a robust state management system.
*   **Data Access:**  Use appropriate data access layers and ensure data consistency.
*   **Logging:** Implement comprehensive logging for debugging and monitoring.

**8.  Deliverables**

*   All code must be submitted for review and validation.
*   Automated test suite must be validated.
*   Code must be documented with clear README files and API documentation.

**9.  Development Process**

*   Prioritize code reviews.
*   Utilize a version control system (e.g., Git).
*   Implement continuous integration/continuous deployment (CI/CD) pipeline.

**10.  Note:**  This document is a guideline and may be subject to change as the project evolves.  Updates will be communicated via [Communication Channel - Specify Here].
```