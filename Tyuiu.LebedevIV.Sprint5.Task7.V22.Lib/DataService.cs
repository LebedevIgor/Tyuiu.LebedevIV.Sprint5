using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;


namespace Tyuiu.LebedevIV.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint5\Tyuiu.LebedevIV.Sprint5.Task7.V22\bin\Debug\OutPutDataFileTask7V22.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }


            string fileContent = File.ReadAllText(path);

            string modifiedContent = Regex.Replace(fileContent, @"[\p{P}\p{S}]", "#");

            File.WriteAllText(pathSaveFile, modifiedContent);
            return pathSaveFile;
        }
    }
}
