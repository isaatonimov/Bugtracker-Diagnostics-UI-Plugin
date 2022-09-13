#small post build script to copy created executable and plugin dll, for later use in setup - creates a smoother build pipeline

try
{
    #Copy UI Plugin to Project Folder of MainProgram, UI is included, force for overwrite
    Copy-Item "C:\Users\Dominik Beyerle\Documents\GUIBugtracker\Bugtracker Diagnostics UI\bin\Debug\Debug\net6.0-windows\BugtrackerDiagnosticsUI.dll" -Destination "C:\Users\Dominik Beyerle\Documents\Bugtracker\bin\Debug\net6.0-windows\plugins" -Force
    Copy-Item "C:\Users\Dominik Beyerle\Documents\GUIBugtracker\Bugtracker Diagnostics UI\bin\Debug\Debug\net6.0-windows\BugtrackerDiagnosticsUI.dll" -Destination "C:\Users\Dominik Beyerle\Documents\Bugtracker\plugins" -Force
}
catch
{
	exit 1
}