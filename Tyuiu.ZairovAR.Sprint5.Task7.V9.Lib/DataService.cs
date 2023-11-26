using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace Tyuiu.ZairovAR.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\pfbhj\source\repos\Tyuiu.ZairovAR.Sprint5\Tyuiu.ZairovAR.Sprint5.Task7.V9\bin\Debug\InPutDataFileTask7V9.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
           
            using (StreamReader reader = new StreamReader(path))
            {
                string line = File.ReadAllText(path).Replace(',', ' ');
                Regex newReg = new Regex("[A-Z]");
                MatchCollection matches = newReg.Matches(line);
                foreach (Match mat in matches)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Replace(mat.Value, "");
                    }
                }
            }
       
            return pathSaveFile;
        }
    }
}
