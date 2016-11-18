using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////compares and prints the file date created in assending order
            //PrintFileDateInOrder();

            ////Moves the File named "testMove.txt from Dir Location1 to Dir Location2"
            ////the Dir and file must exist.  change file path to make it work 
            //MoveFile();


            MoveFilesToFolders("C:\\Users\\Tim\\Desktop\\test");

           




            Console.Read();

        }//end Main()


        //compares and prints the file date created in assending order
        public static void PrintFileDateInOrder()
        {
            //http://stackoverflow.com/questions/23243336/how-to-get-file-created-date-and-modified-date

            DateTime dateCreated = File.GetCreationTime("C:\\JavaPrograms\\FolderFileNamePrint.java");
            DateTime dateCreated2 = File.GetCreationTime("C:\\JavaPrograms\\FolderFileNamePrint.class");

            //compares and prints the file date ("Year") created in assending order
            if (dateCreated < dateCreated2)
                Console.WriteLine(".java " + dateCreated.Year + "\n.class " + dateCreated2.Year);

            else if (dateCreated > dateCreated2)
                Console.WriteLine(".class " + dateCreated2 + "\n.java " + dateCreated);
            else
                Console.WriteLine("nada");

            Console.Read();
        }//end PrintFileDateInOrder()




        //Moves the File named "testMove.txt from Dir Location1 to Dir Location2"
        //the Dir and file must exist.  change file path to make it work 
        //https://msdn.microsoft.com/en-us/library/system.io.file.move(v=vs.110).aspx
        public static void MoveFile()
        {
            string path = @"C:\Users\tpaulson.IRONDALE\Desktop\Location1\testMove.txt";
            string path2 = @"C:\Users\tpaulson.IRONDALE\Desktop\Location2\testMove.txt";
            try
            {
                File.Move(path, path2);
                Console.WriteLine("{0}\nwas moved to \n{1}.", path, path2);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.Read();

        }//end MoveFile()







        //gets the file creation date and returns just the year created as a string
        public static String GetFileDate(string file)
        {
            DateTime fileCreationDate = File.GetCreationTime(file);
            string fileDate = fileCreationDate.Year.ToString();
            return fileDate;
        }//end GetFileDate()



        //moves files from designated root Directory to a new Dir Named for the year of the file
        public static void MoveFilesToFolders(string rootPath)
        { 
           string[] fileNames = Directory.GetFiles(rootPath);

            //create directory if needed and or move file to new location
            foreach (string file in fileNames)
            {
                string newFilePath = rootPath + "\\" + GetFileDate(file);

                if (!System.IO.Directory.Exists(newFilePath))
                {
                    try
                    {
                        System.IO.Directory.CreateDirectory(newFilePath);
                        File.Move(file, newFilePath + "\\"+ Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The process failed: {0}", e.ToString());
                    }
                }//end if
                else
                {
                    try
                    {
                        File.Move(file, newFilePath + "\\" + Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The process failed: {0}", e.ToString());
                    }
                }//end else
            }//end foreach

            Console.Read();

        }//MoveFilesToFolders()

        
    }//end class Program


}//end namespace
