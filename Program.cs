using jsreport.Binary;
using jsreport.Local;

namespace JsReportStudio
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var rs = new LocalReporting()
                    .UseBinary(JsReportBinary.GetBinary())
                    .KillRunningJsReportProcesses()
                    .RunInDirectory(Path.Combine(Directory.GetCurrentDirectory(), "jsreport"))
                    .Configure((cfg) =>
                    {
                        return cfg.FileSystemStore()
                                .BaseUrlAsWorkingDirectory();
                    })
                    .AsWebServer()
                    .RedirectOutputToConsole()
                    .Create();

                await rs.StartAsync();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\njsreport studio is running at http://localhost:5488");
                Console.WriteLine("Press any key to stop the server...");
                Console.ResetColor();

                Console.ReadKey();

                await rs.KillAsync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nError: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.ResetColor();

                // Exit with error code
                Environment.Exit(1);
            }
        }
    }
}