# CyberSecurityChatbotPart3

## Project Name

Cyber Security Assistant Chatbot

## Project Description

The Cyber Security Assistant is a Windows Forms application developed in C# for the PROG6221 Programming 2A Part 3 POE. The application educates users about cybersecurity while providing a Task Assistant, Cybersecurity Quiz, Activity Log, and Natural Language Processing (NLP) simulation. The Task Assistant uses a MySQL database to store tasks permanently.

---

## Features

* GUI-based chatbot
* Cybersecurity advice and responses
* Task Assistant

  * Add tasks
  * View tasks
  * Mark tasks as completed
  * Delete tasks
  * Set reminders
* MySQL database integration
* Cybersecurity Quiz (10 questions)
* NLP simulation using keyword detection
* Activity Log
* Sentiment detection
* User memory for follow-up questions

---

## Software Requirements

* Visual Studio 2022 or later
* .NET Windows Forms
* MySQL Server
* MySQL Workbench
* MySQL.Data NuGet Package

---

## How to Run the Project

1. Open the solution (.sln) file in Visual Studio.
2. Open MySQL Workbench.
3. Run the SQL script provided (CyberSecurityChatbot.sql) to create the Tasks table.
4. Ensure the MySQL connection string in DatabaseHelper.cs matches your MySQL username and password.
5. Build and run the application.

---

## Database Setup

Run the CyberSecurityChatbot.sql script in MySQL Workbench before running the application.

The application stores:

* Task Title
* Description
* Reminder
* Completed Status

---

## Using the Task Assistant

Open the **Task Assistant** tab.

You can:

* Add a cybersecurity task
* View all tasks
* Mark tasks as completed
* Delete tasks
* Set reminders

---

## Cybersecurity Quiz

Open the **Cybersecurity Quiz** tab.

Click **Start Quiz**.

The quiz contains 10 cybersecurity questions with immediate feedback and a final score.

---

## NLP Simulation

The chatbot recognises different user commands, including:

* Start quiz
* Play quiz
* Add task
* Create task
* New task
* Show activity log
* Show recent actions
* What have you done for me?
* Remind me
* Set reminder

---

## Activity Log

The Activity Log records important actions including:

* Task added
* Task completed
* Task deleted
* Quiz started
* Quiz completed
* NLP commands recognised

Users can refresh or clear the activity log through the GUI.

---

## Important Notes

A MySQL Server must be running before the application starts.

The database connection string may need to be updated to match the local MySQL username and password.

---

## Video Presentation

YouTube Video Link:

(Add your unlisted YouTube link here.)
