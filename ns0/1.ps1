# file: msgbox.ps1
# PowerShell MessageBox Display Script

Add-Type -AssemblyName System.Windows.Forms

$Title = "Primordial Lua Test"
$Message = "Test script successfully executed!"
$Buttons = [System.Windows.Forms.MessageBoxButtons]::OK
$Icon = [System.Windows.Forms.MessageBoxIcon]::Information

[System.Windows.Forms.MessageBox]::Show($Message, $Title, $Buttons, $Icon)