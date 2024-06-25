namespace DictionaryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox termNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox termDescriptionTextBox;
        private System.Windows.Forms.Button addTermButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox resultListBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.termNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.termDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addTermButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.letterLabel = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Назва терміну:";
            // 
            // termNameTextBox
            // 
            this.termNameTextBox.Location = new System.Drawing.Point(133, 12);
            this.termNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termNameTextBox.Name = "termNameTextBox";
            this.termNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.termNameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 49);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(97, 16);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Опис терміну:";
            // 
            // termDescriptionTextBox
            // 
            this.termDescriptionTextBox.Location = new System.Drawing.Point(133, 49);
            this.termDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termDescriptionTextBox.Name = "termDescriptionTextBox";
            this.termDescriptionTextBox.Size = new System.Drawing.Size(265, 22);
            this.termDescriptionTextBox.TabIndex = 3;
            // 
            // addTermButton
            // 
            this.addTermButton.Location = new System.Drawing.Point(265, 87);
            this.addTermButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTermButton.Name = "addTermButton";
            this.addTermButton.Size = new System.Drawing.Size(133, 28);
            this.addTermButton.TabIndex = 4;
            this.addTermButton.Text = "Додати термін";
            this.addTermButton.UseVisualStyleBackColor = true;
            this.addTermButton.Click += new System.EventHandler(this.AddTermButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(13, 123);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(104, 16);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Знайти термін:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(133, 123);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(265, 22);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(265, 161);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 28);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Location = new System.Drawing.Point(13, 197);
            this.letterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(102, 16);
            this.letterLabel.TabIndex = 8;
            this.letterLabel.Text = "Першка буква:";
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(133, 197);
            this.letterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(265, 22);
            this.letterTextBox.TabIndex = 9;
            this.letterTextBox.TextChanged += new System.EventHandler(this.letterTextBox_TextChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(265, 235);
            this.displayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(133, 28);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Вивести";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(13, 271);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(385, 244);
            this.resultListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 554);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.termNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.termDescriptionTextBox);
            this.Controls.Add(this.addTermButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.letterLabel);
            this.Controls.Add(this.letterTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.resultListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Програма \'Словник\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
