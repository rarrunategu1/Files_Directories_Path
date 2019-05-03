using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csharp_files_work
{
    class Program
    {
        static void Main(string[] args)
        {   
            string path = @"C:\Users\Rose\source\repos\csharp_files_work\csharp_files_work\TextFile1.txt";
            int howManyWords = FileExercises.numberOfWords(path);
            Console.WriteLine("There are {0} words in your text file",howManyWords);

            string longWord = FileExercises.longestWord(path);
            Console.WriteLine(longWord);
            ////USING FILE
            ////just a var to reuse in different methods
            //string path = @"c:/somefile.jpg";
            //// if c file exists it will copy into the d file as requested 
            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //File.Delete(path);
            //if (File.Exists(path))
            //{
                //
            //}
            //string content = File.ReadAllText(path);
            
            ////USING FILEINFO
            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("..");
            //fileInfo.Delete();
            //if (fileInfo.Exists)
            //{
                //
            //}
            ////USING DIRECTORY
            //Directory.CreateDirectory(@"c:\temp\folder1");
            ////the following returns all the files in the current directory and it's subdirectories
            //string[] files =  Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
              //  Console.WriteLine(file);
            //}
            //string[] directories = Directory.GetDirectories(@"c:\projects\cSharpFundamentals", "*.*", SearchOption.AllDirectories);
            //foreach (string directory in directories)
            //{
              //  Console.WriteLine(directory);
            //}
            //Directory.Exists("..");

            ////USING DIRECTORYINFO
            //var directoryInfo = new DirectoryInfo("..");
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();

            ////USING PATH
            //string path = @"C:\Projects\CSharpFundamentals\HellowWorld.sln";
            //int dotIndex = path.IndexOf('.');
            //string extension = path.Substring(dotIndex);

            //Console.WriteLine("Extension: " + Path.GetExtension(path));
            //Console.WriteLine("File Name: " + Path.GetFileName(path));
            //Console.WriteLine("File Name without Ext: " + Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
    class FileExercises{

        public static int numberOfWords(string textFile)
        {
            int wordCount = 0;
            if (File.Exists(textFile))
            {
                    string content = File.ReadAllText(textFile);
                    string[] split_text = content.Split(' ');
                    foreach (string word in split_text)
                    {
                        wordCount++;
                    }
            }
            return wordCount;
        }
        public static string longestWord(string textFile)
        {   
            string longerWord = "";
            int count = 0;
            if (File.Exists(textFile))
            {
                string content = File.ReadAllText(textFile);
                string[] split_text = content.Split(new[]{' '}, StringSplitOptions.None);

                foreach (string word in split_text)
                {
                if (word.Length > count)
                {
                    longerWord = word;
                  
        
                }
                }
                Console.WriteLine(longerWord);
               
            }
            return "hello";

        }
    }
}
