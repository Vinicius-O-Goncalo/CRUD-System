C# CRUD Application – Windows Forms + SQL Server

# Overview

This project is a desktop CRUD (Create, Read, Update, Delete) application developed using C# and Windows Forms, connected to a SQL Server database.

The application allows users to manage records through a graphical interface while maintaining synchronization with the database. Data binding is implemented using BindingSource, ensuring real-time interaction between the user interface and the database.

This project demonstrates practical knowledge of object-oriented programming, database integration, and desktop application development using .NET technologies.


# Features

Create new records in the database

Read and display data from SQL Server

Update existing records

Delete records from the database

Data synchronization using BindingSource

Object-oriented structure with entity classes


# Technologies Used

C#

.NET Framework

Windows Forms

SQL Server

SQL Server Management Studio (SSMS)

ADO.NET

BindingSource


# Project Structure

CrudApp
│
├── Models
│ └── Client.cs
│
├── Data
│ └── Database.cs
│
├── Forms
│ └── Form1.cs
│
└── Program.cs


# Models

Contains the entity classes that represent the structure of the database tables.

Example:
Client.cs

The properties of the class correspond to the columns in the database.

Data Layer

Responsible for database communication using ADO.NET.

Database.cs

This class performs all SQL operations:

SELECT

INSERT

UPDATE

DELETE


# User Interface

The application interface is built using Windows Forms.

Main components:

DataGridView for displaying records

TextBox controls for input fields

Buttons for CRUD operations


# Database Setup

Create the database using the following SQL script:

CREATE DATABASE CrudDB
GO

USE CrudDB
GO

CREATE TABLE Clients
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100),
Email NVARCHAR(100)
)


# How to Run

  Clone this repository
  
  Open the project in Visual Studio
  
  Configure the connection string inside Database.cs
  
  Example:
  
  Server=localhost;Database=CrudDB;Trusted_Connection=True;
  
  Build the solution and run the application.


# Application Flow

  The application loads records from SQL Server
  
  Data is connected to the interface using BindingSource
  
  Users can create, update, or delete records
  
  The DataGridView automatically refreshes to reflect changes


# Learning Objectives

This project was created to practice:

  Object-Oriented Programming in C#
  
  Desktop application development with Windows Forms
  
  CRUD operations with SQL Server
  
  Data binding using BindingSource
  
  Integration between UI and relational databases


# Possible Improvements

Future enhancements may include:

Input validation

Error handling for database operations

Search and filtering features

UI improvements

Repository pattern implementation

Migration to Entity Framework


# Author

Vinícius Gonçalo
