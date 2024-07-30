# Todo List Application

A simple command-line Todo List application in Python.

## Features

- Add a task with a description.
- List all tasks.
- Complete a task.
- Edit a task description.

## Setup

1. Clone the repository.
2. Navigate to the project directory.
3. Create and activate a virtual environment:
    ```bash
    python3 -m venv venv
    source venv/bin/activate  # On Windows use `venv\Scripts\activate`
    ```
4. Initialize the `todo.json` file:
    ```bash
    echo "[]" > todo.json
    ```

## Usage

- **Add a task**:
    ```bash
    python todo.py add "Your task description"
    ```
- **List tasks**:
    ```bash
    python todo.py list
    ```
- **Complete a task**:
    ```bash
    python todo.py complete [task_number]
    ```
- **Edit a task**:
    ```bash
    python todo.py edit [task_number] "New task description"
    ```
