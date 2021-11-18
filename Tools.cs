using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Potion_Crafting_Tool
{
    class Tools
    {
        public List<String> readFile(String fileAddress)
        {
            List<String> returnResult = new List<string>();

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileAddress))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        returnResult.Add(line);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(exp.Message);
            }
            finally
            {

            }
            return returnResult;
        }

        public bool saveFile(String fileAddress, List<string> writeLines)
        {
            bool justFine = true;
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileAddress))
                {
                    foreach (string line in writeLines)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(exp.Message);
                justFine = false;
            }
            finally
            {
            }
            return justFine;
        }
    }
}
