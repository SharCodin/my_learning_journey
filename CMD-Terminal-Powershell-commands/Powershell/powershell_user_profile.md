# Customize with PowerShell profiles

This repo shows how to change PowerShell default prompt from displaying long folder path to a shorten version.

You'll need to create or modify the profile script to adjust the displayed path format.

Here's a basic outline of how you might achieve this by modifying your PowerShell profile:

1. **Check if a Profile Exists:**
   First, check if you have a PowerShell profile. Profiles are scripts that automatically run when you start a PowerShell session. To check for an existing profile, run:

   ```powershell
   Test-Path $PROFILE
   ```

2. **Create or Edit the Profile:**
   If you don't have a profile, you can create one using:

   ```powershell
   New-Item -Path $PROFILE -ItemType File -Force
   ```

   If you have a profile, you can edit it using a text editor or by running:

   ```powershell
   notepad $PROFILE
   ```

3. **Modify the Profile:**
   In your profile script, you can customize the prompt function to display the path as desired. Here's an example function that you can include in your profile:

   ```powershell
    function prompt {
        $shortenedPath = $PWD.Path -replace [regex]::Escape($HOME), "HOME"

        $pathParts = $shortenedPath -split "\\"
        $pathToShow = "... " + $pathParts[-2] + " > " + $pathParts[-1]

        Write-Host "`n$($pathToShow) $('>' * ($nestedPromptLevel + 1)) " -NoNewline -ForegroundColor Cyan
        return " "
    }
   ```

   This function shortens the path by keeping only the last two components of the path, which include the immediate parent folder and the current folder. It also replaces the home directory path with "~" for brevity.

4. **Save and Restart PowerShell:**
   After modifying the profile script, save the changes and close the text editor. Then, open a new PowerShell session for the changes to take effect.

Remember that this is a basic example, and you can customize the `prompt` function to your preferences.


## Sponsor and Support

- [Patreon Page](https://www.patreon.com/ssharworks)
- [Code Crafters Corner YouTube Channel](https://www.youtube.com/channel/UCZGXfClJ2l8MP0l2bMbHa6w)

## License

[MIT](https://choosealicense.com/licenses/mit/)

## Acknowledgements

[Microsoft Documentation](https://learn.microsoft.com/en-us/powershell/scripting/learn/shell/creating-profiles?view=powershell-7.3)
