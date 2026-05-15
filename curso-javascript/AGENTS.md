```markdown
# AGENTS.md Guidelines

These guidelines are designed to ensure the creation and maintenance of high-quality, maintainable, and robust AI coding agents within this repository. Adherence to these principles is crucial for collaboration and long-term success.

## 1. DRY (Don't Repeat Yourself)

*   **Code Reuse:**  Avoid duplicating code blocks across different files.  When a functionality is reused, it should be encapsulated in a reusable component or function.
*   **Function/Method Abstraction:**  Each function or method should have a single, well-defined purpose.  Avoid creating overly complex or generalized functions.
*   **Template-Based Code:** Utilize templates where appropriate to reduce boilerplate and ensure consistency.

## 2. KISS (Keep It Simple, Stupid)

*   **Minimize Complexity:** Strive for the simplest solution that meets the requirements. Avoid unnecessary features or complex logic.
*   **Clear Intent:** Each line of code should have a clear and understandable purpose.  Explain complex logic concisely.
*   **Readability:** Prioritize code readability. Use meaningful variable names, comments judiciously, and consistent indentation.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module/function should have one primary responsibility.
*   **Open/Closed Principle:**  The system should be open for extension but closed for modification.  New functionality should be implemented as separate modules/components.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:**  Clients shouldn’t be forced to depend on methods they don’t use.
*   **Dependency Inversion Principle:**  High-level modules should not depend on low-level modules.

## 4. YAGNI (You Aren't Gonna Need It)

*   **Future-Proofing:**  Avoid adding features that are currently not required.  Focus on implementing what is necessary *now*.
*   **Avoid Over-Engineering:**  Don't add complexity just because you think it’s a good idea.  Consider whether the added complexity provides real value.
*   **Refactor for Maintainability:**  Refactor code to improve its structure and readability, anticipating future requirements.

## 5. Development Workflow & Best Practices

*   **Unit Testing:**  All code must be thoroughly tested with unit tests.  Tests should cover critical logic and edge cases.
*   **Code Review:** All changes must undergo mandatory code review by at least two team members.  Review focuses on maintainability, adherence to SOLID principles, and potential bugs.
*   **Documentation:**  Provide clear documentation explaining the purpose of each function/method, its parameters, and its return values.  Include unit tests.
*   **Versioning:** Employ a consistent versioning scheme (e.g., Semantic Versioning) for code and dependencies.
*   **Error Handling:** Implement robust error handling and logging.  Prevent unhandled exceptions.
*   **Test Coverage:**  Aim for at least 80% code coverage through unit tests.
*   **Code Style:** Adhere to a consistent code style (e.g., PEP 8) using linters and formatters.
*   **Maintainability Metrics:** Track maintainability metrics (e.g., cyclomatic complexity) to identify areas for improvement.
*   **Dependency Management:**  Use a dependency management tool (e.g., `pip`, `conda`) to track and manage dependencies.
*   **Commit Messages:** Write clear and concise commit messages explaining the *why* behind the changes.
*   **Branching Strategy:**  Utilize a well-defined branching strategy (e.g., Gitflow) to manage feature development and releases.



## 6. File Length Constraint (180 lines max)

*   Each file must not exceed 180 lines of code.
*   Lines must be properly formatted (e.g., using a code formatter).
*   No whitespace is allowed within lines.

## 7. Specific File Requirements (Example - Adjust as needed)

*   **`agent_module.py`**:  Contains the core logic for agent management.  Includes example data structures and algorithms.
*   **`agent_interaction.py`**:  Handles communication with other agents.  Focuses on event handling and data exchange.
*   **`agent_metrics.py`**:  Collects and analyzes agent performance metrics.
*   **`agent_data_loader.py`**:  Loads and processes agent data.  Includes data validation.
*   **`test_agent_module.py`**:  Contains comprehensive unit tests for the `agent_module.py` file.
*   **`agent_utils.py`**:  Provides reusable utility functions and helper classes.

These guidelines serve as a foundational framework for maintaining a high-quality AGENTS.md repository.  Regular review and updates are crucial to ensure the repository remains aligned with best practices.  Any deviations should be documented and justified.
```