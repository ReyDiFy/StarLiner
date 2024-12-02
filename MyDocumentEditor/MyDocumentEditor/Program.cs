using System;
using System.IO;

namespace DocumentCreator {
    public class Program
    {


        public static void Main(string[] args) {
            Console.Write("Input FileName: ");
            String FileName = Console.ReadLine();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String Input = Inputter();
            using (StreamWriter Info = new StreamWriter(Path.Combine(docPath, FileName)))
            {
                Console.WriteLine(Input);
                Info.WriteLine(Input);
            }
            

        }
        public static string Inputter() {
            String ProgName, Section, Address;
            int Age;
            String StringBuilt = "";
            ProgName = "";
            Console.Write("Input Name:");
            ProgName = Console.ReadLine();
            Console.Write("\nInput Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput Section:");
            Section = Console.ReadLine();
            Console.WriteLine("\nInput Address:");
            Address = Console.ReadLine();
            StringBuilt = "Name: " + ProgName + " Age: " + Age + " Section: " + Section + " Address: " + Address;
            return StringBuilt;
        }
    }
}

