using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DictionaryManager
{
    private string _filePath;
    private Dictionary<string, string> _dictionary;

    public DictionaryManager(string filePath)
    {
        _filePath = filePath;
        _dictionary = LoadDictionary();
    }

    private Dictionary<string, string> LoadDictionary()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        if (File.Exists(_filePath))
        {
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { ':' }, 2);
                if (parts.Length == 2)
                {
                    dictionary[parts[0]] = parts[1];
                }
            }
        }

        return dictionary;
    }

    public void SaveDictionary()
    {
        List<string> lines = new List<string>();
        foreach (var entry in _dictionary)
        {
            lines.Add($"{entry.Key}:{entry.Value}");
        }
        File.WriteAllLines(_filePath, lines);
    }

    public string SearchTerm(string term)
    {
        if (_dictionary.TryGetValue(term, out string description))
        {
            return description;
        }
        return null;
    }

    public IEnumerable<KeyValuePair<string, string>> GetTermsStartingWith(char letter)
    {
        return _dictionary
            .Where(entry => entry.Key.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            .OrderBy(entry => entry.Key);
    }

    public void AddTerm(string term, string description)
    {
        _dictionary[term] = description;
    }
}
