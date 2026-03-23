# CatanBus – Bus Timetable and Ticketing System

## Project Overview
CatanBus is a WinForms desktop application developed using C# .NET 8 and SQL Server.
It allows users to search bus routes, book tickets, and process payments.

## Technologies Used
- C# .NET 8
- WinForms
- SQL Server
- ADO.NET
- MSTest

## Features
- User registration and login
- Moderator role for assigning admins
- Admin dashboard for managing buses and trips
- User dashboard for searching trips and booking tickets
- Ticket booking with seat validation
- Payment processing
- Automatic refund on trip cancellation
- Unit tests for service layer

## Database Setup
1. Open SQL Server Management Studio
2. Run the file:

DatabaseScript.sql

This will create the **CatanBusDB database and sample data**.

## Default Accounts

Moderator  
Email: moderator@catanbus.com  
Password: Mod@123  

Admin  
Email: admin1@catanbus.com  
Password: Admin@123  

Admin  
Email: admin2@catanbus.com  
Password: Admin@123  

## Running the Application

1. Open the solution in Visual Studio
2. Update the connection string if needed
3. Run the project

## Unit Tests

Open Test Explorer and run all MSTest tests.

Total tests: ~20
