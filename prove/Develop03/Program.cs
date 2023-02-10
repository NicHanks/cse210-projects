using System;
public partial class Form1
{
class Program
{
    static void Main(string[] args)
    {
        private string input = "";
        Scripture scriptureobject1 = new Scripture();
        scriptureobject1._wordsInTheScripture("Trust in the Lord with all thine heart and lean not unto thin own understanding; in all thy ways acknowledge him, and he shall direct thy paths. ");

        Refrence refrenceobject1 = new Refrence();
        refrenceobject1.set_Book("Proverbs");
        refrenceobject1.set_Chapter("3");
        refrenceobject1.set_Verse("5");
        refrenceobject1.set_EndVerse("6");
        
        if (string input != "quit")
        {
            Console.WriteLine("Press enter to continure or type 'quit' to finish:");
            string = Console.ReadKey();
            Console.WriteLine($"{refrenceobject1.get_Book} {refrenceobject1.get_Chapter}: {refrenceobject1.get_Verse} - {refrenceobject1.get_EndVerse} ");
            Console.WriteLine(object1.setWordsInTheScripture("Trust in the Lord with all thine heart and lean not unto thin own understanding; in all thy ways acknowledge him, and he shall direct thy paths. "));
            if (string != "quite")
            {
            Console.WriteLine(refrenceobject1.getRefrence())
            Console.WriteLine(Scripture.Hide());
            }

        }
    }
}
}