using System;


class PromptGenerator
{
    public List<String> _prompts = new List<string>();


    public PromptGenerator()
    {
        this._prompts.Add("Who was the most interesting person I interacted with today?");
        this._prompts.Add("What was the best part of my day?");
        this._prompts.Add("How did I see the hand of the Lord in my life today?");
        this._prompts.Add("What was the strongest emotion I felt today?");
        this._prompts.Add("If I had one thing I could do over today, what would it be?");
        this._prompts.Add("What did you do today to serve someone?");
        this._prompts.Add("What did you ponder over in your scriptures today?");
        this._prompts.Add("What Christ-like attribute did you emulate today and how?");
        this._prompts.Add("How were you helped today and by who?");
        this._prompts.Add("What outside event did you witness or ponder today?");
        this._prompts.Add("What did you do today, that was enjoyable?");
        this._prompts.Add("What did you learn today?");
        this._prompts.Add("What did you improve in your life today?");
        this._prompts.Add("What happened today that you didn't like and how could you manage it better?");
        this._prompts.Add("What would you like to write in your journal?");
    }

    public String randomlyChoosePrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}