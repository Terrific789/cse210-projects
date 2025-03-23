using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd"); // Get current date
        Prompt = prompt;
        Response = response;
    }

    // Format entry for saving
    public string FormatForSaving()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}
