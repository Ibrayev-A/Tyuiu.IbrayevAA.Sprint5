using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                int x = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        x++;
                        if ((line[i] == '.') || (line[i] == '?') || (line[i] == ',') || (line[i] == '!') || (line[i] == ' '))
                        {
                            if (x == 7)
                            {
                                count++;
                                
                            }
                            x = 0;
                        }
                    }
                }
                //string line = reader.ReadToEnd();
                //string[] linestr = line.Split();
                //for (int i = 0; i < linestr.Length - 1; i++)
                //{
                //    if (linestr[i].Length == 6)
                //    {
                //        count++;
                //    }
                //}

                return count;
            }
            
        }
    }
}
