using C969Scheduling;
using System;
using System.IO;

namespace C969Scheduling
{
    public static class Log
    {
        private static readonly string fileName = "Login_History.txt";

        public static void ActivityLog(User user)
        {
            string currentLog = $"User \"{user.UserName}\" logged in {DateTime.UtcNow} (UTC).";

            try
            {
                using (StreamWriter fileWriter = new StreamWriter(fileName, true))
                {
                    fileWriter.WriteLine(currentLog);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing log file: {ex.Message}");
            }
        }
    }
}
