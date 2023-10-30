using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }
        }
    }
}

class Scripture
{
    private string reference;
    private string text;
    private List<string> hiddenWords;

    List<int> usedIndexes = new List<int>(); // almacena index usados para no repetir

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.hiddenWords = new List<string>();
    }

    public void DisplayScripture()
    {

        Console.WriteLine(reference);

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            if (hiddenWords.Contains(word))
            {
                Console.Write("___ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }

        Console.WriteLine();

    }

    public void HideWord()
    {
        Boolean indexUsed = true;

        string[] words = text.Split(' ');
        Random rand = new Random();

        // verifica si el numero random ya fue utilizado, si lo fue, genera otro hasta que no se repita
        while (indexUsed)
        {
            int index = rand.Next(words.Length);

            if (!usedIndexes.Contains(index))
            {
                string wordToHide = words[index];
                hiddenWords.Add(wordToHide);
                usedIndexes.Add(index);
                indexUsed = false;
            }
        }


    }

    public bool AllWordsHidden()
    {
        string[] words = text.Split(' ');
        return hiddenWords.Count == words.Length;
    }
}