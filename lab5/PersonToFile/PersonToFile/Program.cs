using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;





namespace PersonToFile
{
    class Program
    {
        static void Main(string[] args)
        {
          

            String line, data1, data2, data3;

            DirectoryInfo dir1 = new DirectoryInfo(@".\PERSON");
            if (!dir1.Exists)
            {
                Console.WriteLine("Folder PERSON does not exist!\nCreating folder PERSON");
                dir1.Create();
            }
            else Console.WriteLine("The folder PERSON exist!");

            FileInfo file = new FileInfo(@".\PERSON\persons.dat");
            if (!file.Exists)
            {
                Console.WriteLine("The file persons.dat does not exist!\nCreating file persons.dat");
                file.Create();
            }
            else
            {
                Console.WriteLine("The file persons.dat exist!");
                Console.WriteLine("***************************");
                Console.WriteLine("File name: {0}", file.Name);
                Console.WriteLine("File size: {0}", file.Length);
                Console.WriteLine("Creation: {0}", file.CreationTime);
                Console.WriteLine("Attributes: {0}", file.Attributes);
                Console.WriteLine("***************************\n");
            }

            ArrayList persons = new ArrayList();

            persons.Add(new Person("Sergey", "255523-11111", "22"));
            persons.Add(new Person("Roma", "888888-55555", "35"));
            persons.Add(new Person("Test", "111111-22222", "90"));
            persons.Add(new Person("Egor", "342512-13377", "23"));

            BinaryFormatter binFormat = new BinaryFormatter();
            FileStream fStream = new FileStream(@".\PERSON\persons.dat", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            binFormat.Serialize(fStream, persons);
            fStream.Close();

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@".\PERSON\persons.dat");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Console.ReadKey();



        }
    }
}
