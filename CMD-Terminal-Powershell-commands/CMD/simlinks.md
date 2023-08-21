# Symbolic Links

Symbolic links are basically shortcuts to a file or folder (junction).



## Usage

### Soft link to files
`mklink link target`

### Soft link to folders
`mklink /D link target`

### Hard link pointing to file
`mklink /H link target`

### Hard link pointing to folder
`mklink /J link target`

### Example
`mklink /J "C:\LinkToFolder" "C:\Users\Name\OriginalFolder"`


## Acknowledgements

- [howtogeek](https://www.howtogeek.com/16226/complete-guide-to-symbolic-links-symlinks-on-windows-or-linux/)