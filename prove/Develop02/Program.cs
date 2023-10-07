using System;

class Program
{
    static void Main(string[] args)
    {
    
        bool isPlay = true;
        bool defaultMode = false; 
        Journal journal1 = new Journal();
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {
                Console.WriteLine(" -------------------------------------- Journal Menu -------------------------------------- ");
                Console.WriteLine("\n1)  Add Journal entry. \n2)  Display journal. \n3)  Load journal. \n4)  Save journal.\n5)  Exit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;

                    Entry newEntry = new Entry();
                    Console.WriteLine(newEntry._prompt);
                    newEntry._response = Console.ReadLine();
                    journal1.addingNewEntry(newEntry);

                    Console.WriteLine("Entry added");
                    break;
                case 2:
                    defaultMode = false;

                    journal1.displayAllEntries();

                        if (journal1.entries.Count() == 0)
                        {
                            Console.WriteLine("No entries to display");
                        }
                    
                    break;
                case 3:
                    defaultMode = false;

                    Console.WriteLine("Please enter the filename: ");
                    string fileNameL = Console.ReadLine();
                    
                    Console.WriteLine("loading from file...");
                    journal1.LoadFile(fileNameL, journal1.GetLines());

                    Console.WriteLine("Uploaded data");
                    break;
                case 4:
                    defaultMode = false;

                    Console.WriteLine("Please enter the filename: ");
                    string fileNameS = Console.ReadLine();
                    
                    Console.WriteLine("saving to file...");
                    journal1.savingFile(fileNameS);

                    Console.WriteLine("stored data");
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the Journal Program, hope to see you tomorrow.\n");
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                      Console.WriteLine("The entered character isn't found among the options. Try again: ");
                      menuOption = int.Parse(Console.ReadLine());  

                      if (menuOption >0 && menuOption < 5)
                      {
                        break;
                      }

                      if(i==2)
                      {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                      }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 5);


    }
}