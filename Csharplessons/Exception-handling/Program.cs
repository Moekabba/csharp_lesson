string FilePath = "";

try
{
    FilePath = File.ReadAllText("doc.txt");
    Console.WriteLine("The file has been read");
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($" ERROR: the file '{ex.FileName}' could not be found");
}
finally
{
    Console.WriteLine($"The content length is: {FilePath.Length}");
   // FilePath = File.ReadAllLines("doc.txt");
   // write to file
}