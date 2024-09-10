namespace WriteDateTimeToFile;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: <ProgramName> <Text> <FolderPath>");
            Console.WriteLine("Example: .\\WriteTextToFile Aug-20-2024-09:20 C:\\priority\\bin.95\\PDFMerge");
            return;
        }

        // Get the parameters from command line arguments
        string dateHour = args[0];
        string folderPath = args[1];

        // Define the file name using the first parameter
        string fileName = $"{dateHour}.txt";

        // Combine the folder path and file name to get the full path
        string fullPath = Path.Combine(folderPath, fileName);

        try
        {
            // Ensure the directory exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Write the content to the file
            File.WriteAllText(fullPath, dateHour);

            Console.WriteLine($"File '{fileName}' created successfully at '{folderPath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}