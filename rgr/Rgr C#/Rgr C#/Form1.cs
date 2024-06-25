using System;
using System.Linq;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private DictionaryManager _dictionaryManager;

    public MainForm()
    {
        InitializeComponent();
        _dictionaryManager = new DictionaryManager("dictionary.txt");
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string term = txtSearchTerm.Text.Trim();
        string description = _dictionaryManager.SearchTerm(term);
        if (description != null)
        {
            MessageBox.Show($"Опис терміну '{term}': {description}", "Результат пошуку");
        }
        else
        {
            MessageBox.Show("Термін не знайдено.", "Результат пошуку");
        }
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
        char letter = txtStartingLetter.Text.Trim().ToUpper()[0];
        var terms = _dictionaryManager.GetTermsStartingWith(letter);

        if (!terms.Any())
        {
            MessageBox.Show($"Не знайдено термінів, що починаються з букви '{letter}'.", "Результат відображення");
        }
        else
        {
            string result = $"Терміни, що починаються з букви '{letter}':\n\n";
            foreach (var term in terms)
            {
                result += $"{term.Key}: {term.Value}\n";
            }
            MessageBox.Show(result, "Результат відображення");
        }
    }

    private void btnAddTerm_Click(object sender, EventArgs e)
    {
        string term = txtNewTerm.Text.Trim();
        string description = txtDescription.Text.Trim();

        if (string.IsNullOrEmpty(term) || string.IsNullOrEmpty(description))
        {
            MessageBox.Show("Будь ласка, введіть назву та опис терміну.", "Помилка");
            return;
        }

        if (_dictionaryManager.SearchTerm(term) != null)
        {
            MessageBox.Show($"Термін '{term}' вже існує.", "Помилка");
            return;
        }

        _dictionaryManager.AddTerm(term, description);
        _dictionaryManager.SaveDictionary();
        MessageBox.Show($"Термін '{term}' додано до словника.", "Успішно");
    }
}
