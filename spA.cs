using System;
using System.IO;

public class spA
{
    public static void Main()
    {
        // Get the current directory
        string currentDirectory = Environment.CurrentDirectory;

        // Prepare the command to set the path
        string command = $"@cd /d {currentDirectory}";

        // Get the path to the AppData folder
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        // Specify the new folder in AppData
        string folderName = "SavePathAndReturn";
        string tempPath = Path.Combine(appDataPath, folderName);

        // Check if the folder exists and create it if it doesn't
        CreateFolderIfNotExists(tempPath);

        // Create the full path to the .cmd file in the new folder
        string cmdFilePath = Path.Combine(tempPath, "SetPath.cmd");

        // Write the command to a .cmd file in the new folder
        File.WriteAllText(cmdFilePath, command);
    }

    private static void CreateFolderIfNotExists(string folderPath)
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
    }
}
