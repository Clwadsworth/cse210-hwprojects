public class Journal
{
	private List<Entry> _entries = new List<Entry>();
	// A list of prompts that should spark the interest. Trying to be thoughtful.
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
		"Did you have a spiritual thought on your mind?",
	};
	
	public void Record()
	{
		// allows the program to pull a prompt when it is requested.
		Random rand = new Random();
		int index = rand.Next(_prompts.Count);
		string prompt = _prompts[index];
		
		Console.WriteLine($"\nPrompt: {prompt}");
		Console.Write("Your record states: ");
		string record = Console.ReadLine();

		string date = DateTime.Now.ToShortDateString();
		//  formats the prompt to a saved location for future pulls.
		Entry newPrompt = new Entry(prompt, record, date);
		_entries.Add(newPrompt);
		// response to saving the entry
		Console.WriteLine("Your thoughts has been recorded!");
	}

	public void OpenJournal()
	{
		// a friendly response to not having any entries
		if (_entries.Count == 0)
		{
			Console.WriteLine("Your Journal seems to be empty!");
		}		
		else
		{
			foreach (Entry entry in _entries)
			{	
				entry.Display();
			}
		}
	}

	public void InkToPaper()
	{
		// Needs a way to pull or record the journal entry
		Console.Write("Enter file location: ");
		string filename = Console.ReadLine();
	
		using (StreamWriter outputFile = new StreamWriter(filename))
		{	
			foreach (Entry entry in _entries)
			{
				outputFile.WriteLine(entry.ToFileString());
			}
		}
		// friendly response
		Console.WriteLine("Journal has been written down!");
	}

	public void PaperToScreen()
	{
		// load from a save file of choosing
		Console.Write("Enter file location: ");
		string filename = Console.ReadLine();
	
		_entries.Clear();
		
		string[] lines = System.IO.File.ReadAllLines(filename);
		// added dividers from easy reading 
		foreach (string line in lines)
		{
			string[] parts = line.Split('|');

			string date = parts[0];
			string prompt = parts[1];
			string record = parts[2];

			Entry newPrompt = new Entry(prompt, record, date);
			_entries.Add(newPrompt);
		}
		//  friendly response
		Console.WriteLine("Journal has been recorded!");
	}
}