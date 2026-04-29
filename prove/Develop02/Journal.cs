public class Journal
{
	private List<Entry> _entries = new List<Entry>();
	
	private List<string> _prompts = new List<string>
	{
		"Who was the most interesting person I interacted with today?",
		"What was the best part of my day?",
		"What was the strongest emotion I felt today?",
		"If I had one thing I could do over today, what would it be?",
		"What is something I learned today?",
		"Was there something that surprised you today?",
		"Was there an event or saying that stuck out in your mind?",
		"Who impressed you the most today?",
		"What is the highlight of your day?",
	};
	
	public void AddEntry()
	{
		Random random = new Random();
		int index = random.Next(_prompts.Count);
		string prompt = _prompts[index];
		
		Console.WriteLine($"\nPrompt: {prompt}");
		Console.Write("Your response: ");
		string response = Console.ReadLine();

		string date = DateTime.Now.ToShortDateString();
	
		Entry newEntry = new Entry(prompt, response, date);
		_entries.Add(newEntry);

		Console.WriteLine("Entry added!");
	}

	public void DisplayAll()
	{
		if (_entries.Count == 0)
		{
			Console.WriteLine("No entries yet!");
		}		
		else
		{
			foreach (Entry entry in _entries)
			{	
				entry.Display();
			}
		}
	}

	public void SaveToFile()
	{
		Console.Write("Enter filename: ");
		string filename = Console.ReadLine();
	
		using (StreamWriter outputFile = new StreamWriter(filename))
		{	
			foreach (Entry entry in _entries)
			{
				outputFile.WriteLine(entry.ToFileString());
			}
		}
		
		Console.WriteLine("Journal saved!");
	}

	public void LoadFromFile()
	{
		Console.Write("Enter filename: ");
		string filename = Console.ReadLine();
	
		_entries.Clear();
		
		string[] lines = System.IO.File.ReadAllLines(filename);

		foreach (string line in lines)
		{
			string[] parts = line.Split('|');

			string date = parts[0];
			string prompt = parts[1];
			string response = parts[2];

			Entry newEntry = new Entry(prompt, response, date);
			_entries.Add(newEntry);
		}
	
		Console.WriteLine("Journal loaded!");
	}
}