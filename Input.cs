using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KnapsackProblem
{
    public class Input
    {
        public Input(string stringPath)
        {
            readFile(stringPath);
        }
        public int itemCount { get; set; }
        public double backpackSize { get; set; }
        public List<Double> itemMassList { get; set; }
        public List<Double> itemValueList { get; set; }
        protected void readFile(string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (TextReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            int a;
                            double b;
                            if (int.TryParse(line.Split(' ', '\t')[1], out a))
                            {
                                itemCount = a;
                            }
                            if (double.TryParse(line.Split(' ', '\t')[0], out b))
                            {
                                backpackSize = b;
                            }
                            line = sr.ReadLine();
                            itemMassList = line.Split(',').Select(e => Double.Parse(e)).ToList();
                            line = sr.ReadLine();
                            itemValueList = line.Split(',').Select(e => Double.Parse(e)).ToList();
                            Console.WriteLine("Items count {0}, backpack capacity {1}", itemCount, backpackSize);
                            foreach (double e in itemValueList)
                            {
                                sb.Append(e).Append(" ");
                            }
                            Console.WriteLine("Values list {0}", sb.ToString());
                            sb.Clear();
                            foreach (double e in itemMassList)
                            {
                                sb.Append(e).Append(" ");
                            }
                            Console.WriteLine("Weights list {0}", sb.ToString());
                        }
                        sr.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

    }
}
