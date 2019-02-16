using System;
using System.IO;
namespace TadamsCommon
{
    public class FileReader
    {
        public static string fileName = "I have a dream.txt";

        public void setFileName(string f)
        {
            if(f != null || f != "")
            {
                fileName = f;

            }


        }

        public void readFile()
        {
            try
            {
            TextReader reader = new StreamReader(fileName);
            string line = reader.ReadToEnd();
            Console.WriteLine(line);
            reader.Close();
            Console.ReadKey();
            }

            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine("File name not found {0} .",fnfe.FileName);

            }

            catch(IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }

        }


    }
}