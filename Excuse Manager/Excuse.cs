namespace Excuse_Manager
{
    internal class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
        }

        public Excuse(string filePath)
        {
            OpenFile(filePath);
        }

        public Excuse(Random random, string dicPath)
        {
            string[] files = Directory.GetFiles(dicPath);
            int index = random.Next(files.Length);
            OpenFile(files[index]);
        }

        public void OpenFile(string filePath)
        {
            ExcusePath = filePath;
            using (StreamReader streamReader = new(filePath))
            {
                Description = streamReader.ReadLine();
                Results = streamReader.ReadLine();
                LastUsed = Convert.ToDateTime(streamReader.ReadLine());
            }
        }

        public void SaveFile(string filePath)
        {
            ExcusePath = filePath;
            using (StreamWriter streamWriter = new(filePath))
            {
                streamWriter.WriteLine(Description);
                streamWriter.WriteLine(Results);
                streamWriter.WriteLine(LastUsed);
            }
        }
    }
}