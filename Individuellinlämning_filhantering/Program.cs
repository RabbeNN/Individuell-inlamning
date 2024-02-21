using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Individuellinlämning_filhantering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] StringToList = { "Adam", "Agnes", "Brian", "Fredrik", "Abraham", "Kristina", "Björn", "Bella", "Krister"};

            //Asking the use to choose a letter to list.
            Console.WriteLine("Skriv in bokstaven du vill komma åt");
            //Write in the letter and make it a char.
            char ChooseLetter = char.Parse(Console.ReadLine());
            


            List<string> StringToList2 = FilteredList<string>(StringToList, ChooseLetter);
            foreach (string str in StringToList2)
            {
                Console.WriteLine(str);
            }
            FileList(StringToList2, ChooseLetter);

            

        }
        public static List<T> FilteredList<T>(string[] StringToList, char ChooseLetter)
        {
            List<T> ConvertList= new List<T>();
            //Loops through the array.
            foreach (string i in StringToList)
            {
                //Checks the first letter in each name, takes the ChooseLetter, converts it to string and to upper to so i gets the name if they both are small or big letters.
                if (i[0] == ChooseLetter.ToString().ToUpper()[0])
                    ConvertList.Add((T)Convert.ChangeType(i, typeof(T)));
            }

            //Returns list
            return ConvertList;
        }
        public static void FileList(List<string> StringToList, char ChooseLetter)
        {   //Creating a directory to put the file.
            //Directory.CreateDirectory($@"..\\..\\..\\Namn");

            //reaching the path of the directory.
            string path = @"..\\..\\..\\Namn";
            //Creating the .txt file with the name of the Letter the user inputs in ChooseLetter. If the user wants a list for the letter B the .txt file is named B to get
            //easier access and find the file.
            FileInfo fi = new FileInfo(@$"{path}\{ChooseLetter}.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamWriter w = new StreamWriter(fs);

            //Prints all names into file.
            foreach(string i in StringToList)
            {
                w.WriteLine(i);
            }
            //Closing StreamWriter
            w.Close();
        }
        
    }
}
