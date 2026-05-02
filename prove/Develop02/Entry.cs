public class Entry
{
	private string _prompt;
	private string _record;
	private string _date;

	public Entry(string prompt, string record, string date)
	{
		_prompt = prompt;
		_record = record;
		_date = date;
	}

	public void Display()
	{
		// simple and straightforward listings to ease of reference
		Console.WriteLine($"Date: {_date}");
		Console.WriteLine($"Prompt: {_prompt}");
		Console.WriteLine($"Record: {_record}");
		Console.WriteLine("------------------------------");
	}
	
	public string ToFileString()
	{
		return $"{_date}|{_prompt}|{_record}";
	}

}