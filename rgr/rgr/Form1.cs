    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    namespace DictionaryApp
    {
        public partial class Form1 : Form
        {
            private DictionaryManager dictionaryManager;

            public Form1()
            {
                InitializeComponent();
                dictionaryManager = new DictionaryManager("dictionary.txt");
            }

            private void AddTermButton_Click(object sender, EventArgs e)
            {
                string name = termNameTextBox.Text;
                string description = termDescriptionTextBox.Text;

                dictionaryManager.AddTerm(name, description);

                termNameTextBox.Clear();
                termDescriptionTextBox.Clear();

                MessageBox.Show("Term added successfully!");
            }

            private void SearchButton_Click(object sender, EventArgs e)
            {
                string name = searchTextBox.Text;
                Term term = dictionaryManager.SearchTerm(name);

                resultListBox.Items.Clear();
                if (term != null)
                {
                    resultListBox.Items.Add(term.ToString());
                }
                else
                {
                    resultListBox.Items.Add("Term not found.");
                }
            }

            private void DisplayButton_Click(object sender, EventArgs e)
            {
                if (letterTextBox.Text.Length > 0)
                {
                    char letter = letterTextBox.Text[0];
                    List<Term> terms = dictionaryManager.GetTermsStartingWith(letter);

                    resultListBox.Items.Clear();
                    if (terms.Count > 0)
                    {
                        foreach (var term in terms)
                        {
                            resultListBox.Items.Add(term.ToString());
                        }
                    }
                    else
                    {
                        resultListBox.Items.Add("No terms found starting with that letter.");
                    }
                }
            }

            private void letterTextBox_TextChanged(object sender, EventArgs e)
            {

            }
    }
}
