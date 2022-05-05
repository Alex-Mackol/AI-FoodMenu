using System.Diagnostics;
using System.IO;
using System.Text;

namespace FoodMenu
{
    public class PythonInteractor
    {
        public static string ReadPythonFile(string data)
        {
            ProcessStartInfo start = new ProcessStartInfo();

            string curDir = Directory.GetCurrentDirectory();
            start.FileName = curDir + @"\core\main.exe";
            
            start.UseShellExecute = false;
            start.RedirectStandardInput = true;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            start.WindowStyle = ProcessWindowStyle.Hidden;
            using (Process process = Process.Start(start))
            {
                StreamWriter writer = process.StandardInput;
                writer.WriteLine("{}");
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadLine();
                    return result;
                }
            }
        }
    }
}