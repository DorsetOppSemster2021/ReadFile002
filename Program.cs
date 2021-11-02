using System;
using System.IO;

namespace ReadFile002
{
    class Program
    {
        static void Main(string[] args)
        {

          ///  FileDemo.ReadDemo("jamaica.txt");
           

            string dc_heroesFile = "heroes-dc.txt";
            string[] dc_heroes = { "Batman:Bruce Wayne", "Superman:Clarke Kent", "Aquaman:Arthur Curry" };

            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadDemo(dc_heroesFile);
           




            string marvel_heroesFile = "heroes-marvel.txt";
            string[] marvel_heroes = { "SpiderMan:Peter Parker", "The Hulk:David Banner", "Captain America:Steve Rogers" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);

            FileDemo.ReadDemo(marvel_heroesFile);




            FileDemo.OutputSeparator();
            char[] characters = FileDemo.SplitAsString("supercalifragilisticexpialidocious");

            Console.WriteLine($"The character at index position 10, live position 11 is {characters[10]}");


          


        }
    }
}
