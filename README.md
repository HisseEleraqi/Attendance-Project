# ReadMe - ScriptCS Attendance

## About
This Branch is for testing ScriptCs before including them into Solutions
## Installation
To get started, follow these steps to install the required dependencies:

1. **Chocolatey Installation:**
   Open a PowerShell window with administrator privileges and run the following command to install Chocolatey, a package manager for Windows.
   ```powershell
   @powershell -NoProfile -ExecutionPolicy Unrestricted -Command "iex ((New-Object Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%systemdrive%\chocolatey\bin
   ```

2. **Install Chocolatey Compatibility Extension:**
   Install the Chocolatey Compatibility Extension for enhanced compatibility with various Chocolatey packages.
   ```powershell
   choco install chocolatey-compatibility.extension
   ```
3. **Install ScriptCS:**
   Once Chocolatey is installed, use the following command to install ScriptCS.
   ```powershell
   choco install scriptcs
   ```


## Usage
After successfully installing the required dependencies, you can use the ScriptCS as follows:

1. Create a file named `script.csx` and include your  script code.

   ```powershell
   scriptcs script.csx
   ```


