namespace FishingGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new loginform());
            //string rawCSV = System.IO.File.ReadAllText("C:\\Users\\Kai.Zhang\\Desktop\\kai's fishing game\\FishData.csv");
            string[] csvlines = System.IO.File.ReadAllLines("C:\\Users\\Kai.Zhang\\Desktop\\kai's fishing game\\FishData.csv");

            for(int i = 0; i < csvlines.Length; i++)
            {
                string[] rawData = csvlines[i].Split(',');

            }

        }
    }
}