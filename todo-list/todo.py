import argparse
import json
import os

TODO_FILE = "todo.json"

def load_tasks():
    if os.path.exists(TODO_FILE):
        with open(TODO_FILE, "r") as file:
            try:
                return json.load(file)
            except json.JSONDecodeError:
                return []
    return []

def save_tasks(tasks):
    with open(TODO_FILE, "w") as file:
        json.dump(tasks, file, indent=4)

def add_task(description):
    tasks = load_tasks()
    tasks.append({"description": description, "completed": False})
    save_tasks(tasks)
    print(f'Added task: "{description}"')

def list_tasks():
    tasks = load_tasks()
    for i, task in enumerate(tasks):
        status = "✔" if task["completed"] else "✘"
        print(f"{i + 1}. [{status}] {task['description']}")

def complete_task(task_number):
    tasks = load_tasks()
    if 0 < task_number <= len(tasks):
        tasks[task_number - 1]["completed"] = True
        save_tasks(tasks)
        print(f'Task {task_number} marked as completed.')
    else:
        print("Invalid task number.")

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Todo List Application")
    subparsers = parser.add_subparsers(dest='action', help='Action to perform')

    # Subparser for the add action
    parser_add = subparsers.add_parser('add', help='Add a new task')
    parser_add.add_argument('description', help='Description of the task')

    # Subparser for the list action
    parser_list = subparsers.add_parser('list', help='List all tasks')

    # Subparser for the complete action
    parser_complete = subparsers.add_parser('complete', help='Complete a task')
    parser_complete.add_argument('task_number', type=int, help='Task number to complete')

    args = parser.parse_args()

    if args.action == "add":
        add_task(args.description)
    elif args.action == "list":
        list_tasks()
    elif args.action == "complete":
        complete_task(args.task_number)
    else:
        parser.print_help()