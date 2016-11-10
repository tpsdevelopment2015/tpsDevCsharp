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


            MoveFilesToFolders();


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
        public String GetFileDate(string file)
        {
            DateTime fileCreationDate = File.GetCreationTime(file);
            string fileDate = fileCreationDate.Year.ToString();
            return fileDate;
        }//end GetFileDate()



        //WORKING ->    Moves files from one location to another
        public static void MoveFilesToFolders()
        {
           string filePath = "C:\\Users\\tpaulson.IRONDALE\\Desktop\\A-Current Work\\TestFile";
           string[] fileNames = Directory.GetFiles(filePath);

            //create directory
            string filePath2 = "C:\\Users\\tpaulson.IRONDALE\\Desktop\\A-Current Work\\TestFile2";

            if (!System.IO.Directory.Exists(filePath2))
            {
                
                System.IO.Directory.CreateDirectory(filePath2);
            }
            else
            {

            }

            //foreach (string file in fileNames)
            //{
            //    try
            //    {
            //        /*
            //         * write code to get file date.year, check to see if Dir exists, creates dir
            //         * and moves file
            //         * 
            //         * https://msdn.microsoft.com/en-us/library/as2f1fez.aspx
            //        */

            //        string newLocationPath = "C:\\Users\\tpaulson.IRONDALE\\Desktop\\" +
            //                                "A-Current Work\\TestFile\\newLocation\\" + Path.GetFileName(file);
            //        File.Move(file, newLocationPath);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("The process failed: {0}", e.ToString());
            //    }

            //    Console.WriteLine(file);

            //}//end foreach loop

            Console.Read();

        }//MoveFilesToFolders()

        
    }//end class Program


}//end namespace
