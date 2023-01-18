using System;
using System.IO;
using System.Reflection;
using ReadFileLineByLibe.Models;

public class ReadFileLineByLine
{
    public static void Main()
    {
        /*Find the file path from the data folder.*/
        var path = Path.Combine(Environment.CurrentDirectory, "Data", "Test.txt");

        /*Read the all lines from the file.*/
        string[] lines = File.ReadAllLines(path);

        /*
         * Assume a model according the depend on Text file data/
         * Here i assume a model which name is information.
         */

        /*Since i know the file has multiple rows,
         *So i create a list in 24 no line.
         */
        var information = new List<Information>();


        /*
         *Here i use a loop for each rows
         */
        foreach (var line in lines)
        {
            /*
             * Split the every column of the rows.
             */
            var lineParts = line.Split(" ");

            /*
             * Add information into the list.
             */
            information.Add(new Information()
            {
                Id = Convert.ToInt32(lineParts[0]),
                FirstName = lineParts[1],
                MiddleName = lineParts[2],
                LastName = lineParts[3],
                Location = lineParts[4],
                ContactNo = lineParts[5],
            });
        }

        /*
         * Here is the final result
         */
        Console.WriteLine(@"The whole output file are generated from \data\test.txt file");
        foreach (var info in information)
        {

            Console.WriteLine($"SL:{info.Id} Name: {info.FirstName} {info.MiddleName} {info.LastName} Location: {info.Location} Contact: {info.ContactNo}");
        }

    }
}