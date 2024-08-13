using ChongYuHau_s_resume_MAUI_app.Data;
using System;
using Microsoft.Maui.Controls;

namespace ChongYuHau_s_resume_MAUI_app
{
    public partial class MainPage : ContentPage
    {
        private readonly ContactFormService _contactFormService;

        public MainPage()
        {
            InitializeComponent();
            _contactFormService = new ContactFormService();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            try
            {
                string name = NameEntry.Text;
                string email = EmailEntry.Text;
                string comment = CommentEditor.Text;

                // Save the data to the database
                await _contactFormService.SaveContactFormAsync(name, email, comment);

                // Clear the form fields after submission
                NameEntry.Text = string.Empty;
                EmailEntry.Text = string.Empty;
                CommentEditor.Text = string.Empty;

                // Show success message in the result label
                ResultLabel.Text = "Contact form submitted successfully!";
                ResultLabel.TextColor = Colors.Green;

                // Show a pop-up alert to confirm submission
                await DisplayAlert("Success", "Submitted successfully!", "OK");
            }
            catch (Exception ex)
            {
                // Show error message
                ResultLabel.TextColor = Colors.Red;
                ResultLabel.Text = "Error: " + ex.Message;

                //Show an error alert
                await DisplayAlert("Error", "An error occurred while submitting the form.", "OK");
            }
        }

        private async void OnResumeClicked(object sender, EventArgs e)
        {
            try
            {
                // Open the resume link in the default web browser
                await Launcher.OpenAsync("https://www.linkedin.com/feed/");
            }
            catch (Exception ex)
            {
                // Handle any errors that occur when trying to open the link
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }
    }
}
