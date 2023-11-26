using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };
            string[] words = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int countWordsSixChars = words.Count(word => word.Length == 6);
            return countWordsSixChars;
        }
    }
}
