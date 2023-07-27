import os

def list_files_and_folders(directory, indent="", excluded_folders=None):
    if excluded_folders is None:
        excluded_folders = []

    if os.path.basename(directory) in excluded_folders:
        return

    print(indent + os.path.basename(directory) + "\\")

    indent += "-"

    for item in os.listdir(directory):
        item_path = os.path.join(directory, item)

        if os.path.isfile(item_path):
            if not os.path.basename(item).startswith('.'):
                print(indent + item)
        elif os.path.isdir(item_path):
            if not os.path.basename(item).startswith('.'):
                list_files_and_folders(item_path, indent + "-", excluded_folders)

# Get the current working directory
current_directory = os.getcwd()

# Define excluded folders
excluded_folders = [".venv"]

# Example usage
list_files_and_folders(current_directory, excluded_folders=excluded_folders)
