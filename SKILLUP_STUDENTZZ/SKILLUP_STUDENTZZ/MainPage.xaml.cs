using System;
using Microsoft.Maui.Controls;

namespace SKILLUP_STUDENTZZ
{
    public partial class MainPage : ContentPage
    {
        string[] questions =
        {
            "Tell me about yourself",
            "Why should we hire you?",
            "What are your strengths?",
            "Explain your communication skills"
        };

        int currentIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            questionLabel.Text = questions[currentIndex];
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answerEntry.Text))
            {
                resultLabel.Text = "Enter answer!";
                return;
            }

            resultLabel.Text = "Saved!";
            answerEntry.Text = "";

            currentIndex++;

            if (currentIndex < questions.Length)
            {
                questionLabel.Text = questions[currentIndex];
            }
            else
            {
                questionLabel.Text = "Completed!";
            }
        }
    }
}