internal class Program
{
    public static int TestWert1 = 0;
    public static int TestWert2 = 0;
    public static string filePath = "Datei1.dat";
    private static void Main(string[] args)
    {
        Load();
        Console.WriteLine(TestWert1 + "\n" + TestWert2);
    }
    private static void Save()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(TestWert1);
            writer.Write(',');
            writer.Write(TestWert2);
        }
    }
    private static void Load()
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Lade Zeilen
                    string[] parts1 = line.Split(',');
                    TestWert1 = Convert.ToInt32(parts1[0]);
                    TestWert2 = Convert.ToInt32(parts1[1]);
                }
            }
        }
        catch
        {
            Save();
        }
    }
}