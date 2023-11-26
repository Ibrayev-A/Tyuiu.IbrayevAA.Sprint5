using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double x;
                while ((line = reader.ReadLine()) != null)
                {
                    x = Convert.ToDouble(line);
                    if (x % 2 == 0)
                    {
                        res = res + Math.Round(x, 3);
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
