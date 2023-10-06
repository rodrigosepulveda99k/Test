using System;

class Entry
{
    public String _date;

    public String _prompt;

    public String _response;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        this._date = theCurrentTime.ToShortDateString();

        PromptGenerator pg = new PromptGenerator();
        this._prompt = pg.randomlyChoosePrompt();
    }

    public Entry(String date, String prompt, String response)
    {
        this._date = date;
        this._prompt = prompt;
        this._response = response;
    }

    public void displayEntry()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} \n{_response}");
    }

    public String getEntry()
    {
        return $"Date: {_date} Prompt: {_prompt} \n{_response}";
    }

    public String getEntryCSV()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    
}