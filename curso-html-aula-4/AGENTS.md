```markdown
# AGENTS.md File Guidelines

These guidelines are designed to ensure the consistent, high-quality development of the AGENTS.md repository. Adherence to these principles is mandatory for all development activities.

## 1. DRY (Don't Repeat Yourself)

*   **Single Responsibility Principle:** Each agent should have a single, well-defined responsibility. Avoid creating multiple agents performing similar functions.
*   **Code Reuse:**  Promote the creation of reusable components and modules across multiple agents.
*   **Abstraction:**  Abstract complex logic into well-defined interfaces.
*   **Pattern Recognition:** Identify and implement common design patterns to reduce redundancy.

## 2. KISS (Keep It Simple, Stupid)

*   **Minimize Complexity:**  Strive for the simplest solution that meets the requirements. Avoid over-engineering.
*   **Readability:**  Code should be easy to understand – use meaningful variable and function names, consistent indentation, and comments where necessary.
*   **Focus on Core Logic:** Keep the core functionality of each agent concise and easily testable.

## 3. SOLID Principles

*   **Single Responsibility:** As mentioned above, all agents should focus on a single, manageable responsibility.
*   **Open/Closed Principle:**  The agent’s interface should be open for extension but closed for modification.  New features should be added without altering existing code.
*   **Liskov Substitution Principle:**  Subclasses should be able to replace parent classes without breaking the program’s behavior.
*   **Interface Segregation Principle:** Each interface should have a limited and well-defined set of responsibilities.  Avoid method dependencies.
*   **Dependency Inversion Principle:**  High-level modules (agents) should be dependent on low-level modules (interfaces), not their implementations.

## 4. YAGNI (You Aren’t Gonna Need It)

*   **Avoid Unnecessary Code:** Only implement features that are explicitly required. Don't introduce logic that isn't currently needed.
*   **Future-Proofing:**  Design the codebase with adaptability in mind, anticipating potential future requirements.

## 5. Development Practices

*   **Unit Tests:** All code must be thoroughly tested with unit tests.  A minimum of 80% of code should pass.  Tests should cover all relevant logic and edge cases.
*   **Integration Tests:** Comprehensive integration tests are required to validate interactions between agents and components.
*   **Code Reviews:**  All code must undergo peer review before merging.
*   **Static Analysis:** Utilize static analysis tools (e.g., ESLint, SonarQube) to identify potential issues and enforce coding standards.
*   **Documentation:**  Clear and concise documentation (docstrings, comments) should be provided for all functions, classes, and modules.
*   **Version Control:**  Use a version control system (Git) for all code changes.
*   **Code Style:**  Adhere to a consistent code style guide (e.g., Google Style Guide, PEP 8).
*   **Commit Messages:**  Use concise and informative commit messages.
*   **Error Handling:**  Implement robust error handling with appropriate logging and exception handling.

## 6. File Size Limit (180 lines max)

*   Each file should be no more than 180 lines of code.  This includes comments, docstrings, and logical structure.

## 7. Test Coverage Requirements

*   **Minimum:** 90% test coverage across all modules and functions.
*   **Target:** 95% test coverage, striving for 98% where feasible.  Coverage should be measured using a chosen test framework (e.g., pytest, unittest).

## 8.  Specific File Structure (Example - adapt to project needs)

*   **Agents:**  A dedicated directory for each agent class/module.
*   **Components:**  Reusable modules that can be used by multiple agents.
*   **Data Models:**  Define data structures that are used by all agents.
*   **Configuration Files:**  Store configuration data separately for better maintainability.

## 9.  Deliverables

*   All code must be reviewed and approved by a designated team lead.
*   Continuous integration/continuous deployment (CI/CD) pipeline implemented.

These guidelines are to be considered a baseline. Further refinement and updates may be necessary based on project needs and evolving best practices.
```