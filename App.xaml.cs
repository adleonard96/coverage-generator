using System.Configuration;
using System.Data;
using System;
using System.IO;

using System.Windows;

namespace coverage_generator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Call the base method to ensure the Startup event is raised
            base.OnStartup(e);

            string filePath = "config.json"; // Path to the file you want to check

            if (File.Exists(filePath))
            {
                // File found: proceed with normal startup or load data
                Console.WriteLine("File exists.");
            }
            else
            {
                // File missing: show a message or shut down
                File.WriteAllText("config.json", "{}"); // Create an empty config file
            }
        }
    }
}
