# -000895841-CPRG211Final_Project

Resume Application
 
Overview
 
This Contact Form Application is a simple .NET MAUI project designed to collect user contact information and store it securely in a MariaDB database. The application features a user-friendly interface where users can enter their name, email, and comments. Upon submission, the data is saved in a database, and a confirmation message is displayed.
 
Features
 
- User Input: Users can enter their name, email, and comments in the provided form.
- Data Storage: The application saves user input to a MariaDB database.
- Confirmation Messages: Users receive a confirmation message after successful form submission.
- Resume Link: Users can view a resume by clicking a button within the application.
- Error Handling: The application includes robust error handling to manage database connection issues and data submission errors.
 
## Technologies Used
 
- .NET MAUI: Used to build the cross-platform user interface.
- C#: The primary programming language used for implementing the application logic.
- MySqlConnector: A .NET data provider used to connect to and interact with the MariaDB database.
- XAML: Used to define the UI layout and elements in the application.
 
## Project Structure
 
- MainPage.xaml: Defines the user interface of the application, including input fields, buttons, and labels.
- MainPage.xaml.cs: Contains the logic for handling user interactions, such as submitting the form and opening the resume link.
- ContactFormService.cs: Manages the database connection and handles the insertion of user data into the `contact_form` table.
 
Functionality
 
1. User Interface (MainPage.xaml)
 
- Personal Information Display: The top of the page displays the developer's name, email, and phone number.
- Contact Form: Users can input their name, email, and comments into text fields.
- Submit Button: When clicked, this button triggers the form submission process.
- View Resume Button: Opens a link to the developer's resume in the user's default web browser.
- Result Label: Displays a success or error message after form submission.
 
 2. Form Submission Logic (MainPage.xaml.cs)
 
OnSubmitClicked Method:
  - Captures user input from the form fields.
  - Calls the `SaveContactFormAsync` method in `ContactFormService` to save the data to the database.
  - Clears the form fields after successful submission.
  - Displays a confirmation message in a label and a pop-up alert.
 
OnResumeClicked Method:
  - Opens the developer's resume link in the default web browser.
 
