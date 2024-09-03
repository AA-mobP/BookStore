Here’s a draft of the `README` file for your project:

---

# Maktaba Bookstore

## Project Overview

**Maktaba Bookstore** is an online platform developed for a publishing house to showcase and sell books digitally. The platform offers a comprehensive solution for book lovers to browse, explore, and purchase books online. The website features a homepage displaying all available books, a detailed page for each book, a shopping cart for managing selected books, and a user profile page where users can view and manage their account details and purchase history.

## Key Features

- **Home Page**: Displays all books fetched from the database, allowing users to browse through the available selection.
- **Details Page**: 
  - Displays detailed information about a selected book.
  - Suggests books based on the publication year, author, and category of the currently viewed book.
- **Login Page**:
  - Allows users to register an account, log in, and log out.
  - Includes email confirmation after registration.
  - Password recovery feature through email.
- **Cart Page**:
  - Manages items in the shopping cart, including adding, deleting, and updating the quantity of books.
  - Facilitates the checkout process.
- **Profile Page**:
  - Displays and allows the user to edit their profile information.
  - Shows past orders and purchase history.
- **Contact Us Page**:
  - Displays and allows the user to send Emails for the creators.
  - ability for anonymous Emails.
- **Deployment**: The website is deployed on a real host, making it accessible to users online.

## Technologies Used

- **ASP.NET MVC**: For the overall web application structure and logic.
- **LINQ & Entity Framework Core**: For database operations and management.
- **Identity Module**: For authentication and user management.
- **C#**: As the primary programming language.
- **HTML, CSS, JavaScript**: For the front-end design and user interaction.
- **AJAX**: For asynchronous operations to enhance user experience.
- **Bootstrap**: For responsive and modern UI design.
- **MonsterAsp**: For deployment and hosting.

## Installation and Setup

1. **Clone the repository**: 
   ```bash
   git clone https://github.com/yourusername/maktaba-bookstore.git
   ```
2. **Update Connection String**:
   - Replace the connection string in the `appsettings.json` with your own database connection string.
   
3. **Email Sending Service**:
   - Update the email `UserName`, `Password`, and `Host` settings in the configuration files.

4. **Web Server**:
   - Ensure that IIS Webserver is installed and properly configured.

5. **Run the application**:
   - Use Visual Studio or another IDE to build and run the project.

## Deployment

The website is live and can be accessed at: [Maktaba Bookstore](https://bookstoreiti.runasp.net/)

## Screenshots
![bookstoreImage1](https://github.com/user-attachments/assets/241c2208-53e7-4131-a78c-6db80a41930f)
![bookstore](https://github.com/user-attachments/assets/cf69c209-ee79-46c8-90fe-9be7d34b9dc9)
![bookstoreImage2](https://github.com/user-attachments/assets/3e44855c-493a-48b7-a1cb-68f0de0c337c)
![bookstoreImage3](https://github.com/user-attachments/assets/c743f5f4-e5ee-435d-a595-f0e45c610ae9)
![bookstoreImage4](https://github.com/user-attachments/assets/a25d8c94-59ec-4baf-9f7c-fb615123deec)
