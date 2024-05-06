using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Get the current directory
        string currentDirectory = Environment.CurrentDirectory;

        // Prepare the command to set the path
        string command = $"@cd /d {currentDirectory}";

        // Get the path to the temp folder
        string tempPath = Path.GetTempPath();

        // Create the full path to the .cmd file in the temp folder
        string cmdFilePath = Path.Combine(tempPath, "SetPath.cmd");

        // Write the command to a .cmd file in the temp folder
        File.WriteAllText(cmdFilePath, command);
    }
}