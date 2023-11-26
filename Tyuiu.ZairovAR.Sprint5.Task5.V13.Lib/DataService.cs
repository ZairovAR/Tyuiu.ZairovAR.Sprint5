using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ZairovAR.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int k = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) >= -1.5 && Convert.ToDouble(line) <= 1.5) 
                    {
                        res = res + Convert.ToDouble(line);
                        k += 1;
                    }
                }
            }
            return Math.Round(res/k, 3);
        }
    }
}
