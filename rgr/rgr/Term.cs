namespace DictionaryApp
{
    public class Term
    {
        public string Name { get; }
        public string Description { get; }

        public Term(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}