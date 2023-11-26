using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ZairovAR.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            string r = File.ReadAllText(path).Replace(',', ' ');
            string[] str = r.Split(' ');
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 8)
                    res++;
            }
            return res;
        }
    }
}
