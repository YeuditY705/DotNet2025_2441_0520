using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools;

public static class LogManager
{
    private static string logRouting = "Log";
    public static string space = "";
    private static string getCurrentFolderPath()
    {
        //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
        return $@"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}/bin/{logRouting}";
    }

    private static string getCurrentFilePath()
    {
        return $@"{getCurrentFolderPath()}/{DateTime.Now.Year}.{DateTime.Now.Month}/{DateTime.Now.Day}";
    }
    public static void writingToLog(string projectName, string funcName, string message)
    {
        string pathForFileLog = getCurrentFilePath();
        string pathForFolderLog = Path.Combine(getCurrentFolderPath(),$"{ DateTime.Now.Year}.{ DateTime.Now.Month}");
        if (!File.Exists($"{pathForFileLog}.txt"))
        {
            Console.WriteLine("לא קים קובץ");
            if (!Directory.Exists(pathForFolderLog))
            {
                Console.WriteLine("לא קים תקיה");
                Directory.CreateDirectory(pathForFolderLog);
                //File.AppendAllText(pathForFileLog, string.Empty);
            }
            File.Create($"{pathForFileLog}.txt").Close();
        }
        File.AppendAllText($"{pathForFileLog}.txt", $"{space}{DateTime.Now}\t{projectName}.{funcName}\t{message}"+Environment.NewLine);
    }
    public static void cleanLog()
    {
        string[] folders = Directory.GetDirectories(getCurrentFolderPath());
        int month = DateTime.Now.AddMonths(-2).Month,year= DateTime.Now.AddMonths(-2).Year;
        foreach (string folder in folders) { 
            if(folder.CompareTo($"{year}.{month}")<0)
                Directory.Delete(folder);
        }
    } 

}