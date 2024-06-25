<h1 align="center">Dot Net Learning Management System</h1>
<p>This is a basic learning management system built with the Dot Net Framework, Bootstrap, JavaScript, Python, SASS, and Postgres.</p>

### Contents:
- [Prerequisites](#prerequisites)
- [Get Started](#get-started)
- [Articles](#articles)
- [Styling](#styling)
- [Contribute](#contribute)
- [Demo](#demo)

## Prerequisites
<p>Here is a list of prerequisites to be able to run this project on your computer:</p>
<ul>
<li>Have Dot Net installed on your computer</li>
<li>Have Postgres installed on your computer, and set up a database instance you want to use, a good name for this database is dotnet_lms_sandbox</li>
<li>Have SASS installed on your computer</li>
<li>Have Python installed on your computer</li>
<li>Fundamentals of how Git and GitHub work</li>
</ul>
If you are confused about any of the prerequisites please reference the <a href="#articles">articles section</a>, there are resources provided to guide you on how to install the necessary software on your computer

## Get Started
1. Clone this repository to your computer, so open a new terminal on your computer and run this command: `git clone https://github.com/javiguerra777/learning-management-system.git`
2. After cloning the repository create a `.env` file at the root of your project.
<br>
In this file this is what needs to be included
```
DB_HOST="Database Host goes here [ex: localhost]"
DB_PORT="Database Port goes here [ex: 5432]"
DB_NAME="Database Name goes here [ex: dotnet_lms_sandbox]"
DB_USERNAME="Username to log into database instance [ex: admin]"
DB_PASSWORD"Password to log into database instance [ex: password]"
```
3. After setting up your environment variables, you need to run the database migrations first open this project in your VSCode, and then open a terminal, inside the terminal run these commands:
```
dotnet ef database update
```
If you get an error you may need to install the EF core tools globally to do so run: `dotnet tool install --global dotnet-ef` and then re-try the database migrations.

4. Now that you have your database set up, environment variables set up, and the database migrations complete. It is now time to run the project to do so, first open a terminal in VSCode and you can run either of these commands:
```
dotnet run (this starts the application)
or
dotnet watch run (this starts the application but in hot-reload mode)
```

## Styling
Since this project uses SASS, you will first need to write your SASS styles,  then compile it into CSS.
<br>
1. To begin writing styles look inside `wwwroot/sass` in this folder contains all the styling for this project. You can either add to the existing styles or if you create a new page create a new SASS file for that page. If you create a new SASS file then make sure to import it inside `site.scss` (this is the file that gets compiled to css for this project)
2. To compile your SASS to CSS, you can do it manually by running SASS in your terminal, or you can use the python script in this project that is used to automate compiling sass.
3. To use the python script open a terminal and change directories until you are in the `scripts` folder, then execute the `compile_sass.py` file.

## Articles

### Setting Up Your Development Environment
- [Installing Dot Net on Windows](https://docs.microsoft.com/en-us/dotnet/core/install/windows)
- [Installing Dot Net on Linux](https://docs.microsoft.com/en-us/dotnet/core/install/linux)
- [Installing Dot Net on macOS](https://docs.microsoft.com/en-us/dotnet/core/install/macos)
- [Setting Up PostgreSQL](https://www.postgresql.org/docs/current/tutorial-install.html)
- [Installing Python](https://www.python.org/downloads/)
- [Getting Started with SASS](https://sass-lang.com/guide)
- [Installing SASS](https://sass-lang.com/install)
- [Understanding Environment Variables in .NET](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-5.0)

### Working with Git and GitHub
- [Git Basics](https://git-scm.com/book/en/v2/Getting-Started-Git-Basics)
- [GitHub Quickstart](https://docs.github.com/en/get-started/quickstart)

### Database Migrations with EF Core
- [Entity Framework Core Migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
- [Using the EF Core Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

### Additional Resources
- [Introduction to Bootstrap](https://getbootstrap.com/docs/5.0/getting-started/introduction/)
- [JavaScript Basics](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Introduction)
- [Python for Beginners](https://www.python.org/about/gettingstarted/)

## Contribute
- Fork this repository.
- Create a new branch for your contributions.
- Submit a pull request with your changes.

Your contributions are highly appreciated. Together, we can make this project even better!


## Demo

Coming Soon!