```markdown
# AGENTS.md Guidelines

These guidelines are designed to ensure the creation and maintenance of high-quality, robust, and maintainable AGENTS.md files within this repository. Adherence to these principles is mandatory for all development activities.

**1. DRY (Don't Repeat Yourself)**

*   All code should be encapsulated within reusable components or functions.
*   Avoid duplication of logic and data structures.
*   Leverage existing libraries and modules whenever feasible.
*   Document all reusable components clearly.

**2. KISS (Keep It Simple, Stupid)**

*   Prioritize readability and clarity.
*   Minimize complexity within each module and function.
*   Avoid overly clever or obscure code.
*   Focus on the essential requirements.

**3. SOLID Principles**

*   **Single Responsibility Principle:** Each class/module should have a single, well-defined purpose.
*   **Open/Closed Principle:**  The system should be designed in a way that allows extensions without modifying the core logic.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without affecting the correctness of the program.
*   **Interface Segregation Principle:**  Clients should not be forced to depend on methods they do not use.
*   **Dependency Inversion Principle:**  High-level modules should be dependent on low-level modules, and low-level modules should be dependent on abstractions.

**4. YAGNI (You Aren't Gonna Need It)**

*   Do not implement functionality that is not currently required.
*   Refactor code only when it becomes evident a missing requirement exists.
*   Defer implementation details until they are explicitly needed.
*   Prioritize clarity and maintainability over premature optimization.

**5. Code Formatting & Style**

*   **Indentation:** Use 2 spaces for indentation.
*   **Line Length:** Keep lines under 120 characters.
*   **Naming Conventions:** Follow the established naming conventions (e.g., camelCase for functions/variables).
*   **Comments:** Provide concise, relevant comments. Avoid unnecessary comments.
*   **Whitespace:**  Use whitespace strategically to improve readability.

**6. File Size Limits**

*   Each file must be no more than 180 lines of code.

**7. Test Coverage Requirements**

*   **Minimum:** 80% of the code should be covered by unit tests.
*   **Focus:** Unit tests should cover critical logic and error handling.
*   **Approach:** Employ a robust testing strategy, including boundary value testing, edge case testing, and integration testing.
*   **Mocking:**  Mocks should ONLY be used for unit tests.  Do not use mocks to simulate real dependencies or external services.

**8. Development Workflow**

*   **Code Reviews:** All code must be reviewed by at least one other developer before merging.
*   **Pull Requests:**  All changes must be submitted via a pull request.
*   **Testing:**  Automated tests should be run after any significant code change.
*   **Version Control:** Use Git for version control.
*   **Documentation:**  Maintain clear documentation for each module and function, outlining its purpose and inputs/outputs.

**9. Specific File Format Requirements**

*   **`src/index.md`:**  Overview of the project, dependencies, and key modules.
*   **`src/moduleA.md`:**  Detailed implementation of module A.
*   **`src/moduleB.md`:** Detailed implementation of module B.
*   **`src/utils/common.md`:**  Reusable utility functions and classes.
*   **`src/tests/test_moduleA.md`:** Unit tests for module A.
*   **`src/tests/test_moduleB.md`:** Unit tests for module B.
*   **`src/docs/index.md`:** Documentation for the project.

**10.  Agencies.md Structure (Example)**

```
# AGENTS.md
+-----------------------------------------------------------------+
|  Project Overview, Dependencies, Core Modules,  Test Coverage      |
+-----------------------------------------------------------------+
|  moduleA.md | moduleB.md | utils/common.md | tests/test_moduleA.md |
|  ...          |  ...          |   ...              |
+-----------------------------------------------------------------+
```

**11. Code Style Guide**

*   Adopt a consistent coding style (e.g., using a code formatter).
*   Use descriptive variable and function names.
*   Write clear and concise code.

These guidelines are designed to foster a sustainable and high-quality codebase for the AGENTS.md repository.
```