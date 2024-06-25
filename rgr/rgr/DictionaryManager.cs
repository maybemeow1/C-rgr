using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryApp
{
    public class DictionaryManager
    {
        private readonly string filePath;
        private readonly Dictionary<string, Term> terms;

        public DictionaryManager(string filePath)
        {
            this.filePath = filePath;
            terms = new Dictionary<string, Term>();
            LoadTerms();
        }

        private void LoadTerms()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        terms[name] = new Term(name, description);
                    }
                }
            }
        }

        public void AddTerm(string name, string description)
        {
            var term = new Term(name, description);
            terms[name] = term;
            SaveTerms();
        }

        public Term SearchTerm(string name)
        {
            terms.TryGetValue(name, out var term);
            return term;
        }

        public List<Term> GetTermsStartingWith(char letter)
        {
            var result = new List<Term>();
            foreach (var term in terms.Values)
            {
                if (term.Name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(term);
                }
            }
            result.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase));
            return result;
        }

        private void SaveTerms()
        {
            var lines = new List<string>();
            foreach (var term in terms.Values)
            {
                lines.Add($"{term.Name}|{term.Description}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
