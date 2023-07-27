# List Files and Folders

This script recursively lists all files and folders in a given directory, excluding specified folders.

## Usage

To use this script, simply call the `list_files_and_folders` function, passing in the starting directory and optionally a list of excluded folders:

```python
excluded_folders = [".venv"] 

list_files_and_folders("/path/to/directory", excluded_folders=excluded_folders)
```

This will print out a tree view of all files and folders under the given directory, excluding anything in the `.venv` folder.

## Features

- Recursively lists all files and folders under a given starting directory
- Allows excluding specific folders from the output
- Prints a nested tree view showing the folder structure

## Contributing

Contributions to this script are welcome! To contribute:

1. Fork this repo
2. Make changes and commit to your fork
3. Open a pull request against this repo

Issues and feature requests are also welcome in the repo's issue tracker.

## Credits

This script was written by Sharvin Suntoobacus from [Code Crafters Corner](https://www.youtube.com/channel/UCZGXfClJ2l8MP0l2bMbHa6w). The core folder traversal logic relies on Python's `os` module.
