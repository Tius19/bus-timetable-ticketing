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

## Core Business Logic & Rules
* **Seat Management:** The system strictly enforces capacity. You cannot book more seats than are available or more than 10 seats per booking (`SeatsAvailable` in the `Bus` table).
* **Security & Validation:** * **Registration:** Passwords must contain at least one uppercase letter, one number, and one symbol (verified in `RegisterForm.cs`).
    * **Payments:** Implements the **Luhn Algorithm** to validate credit card numbers before processing.
* **Role-Based Access:** * **Users:** Search and book tickets.
    * **Admins:** Manage buses, schedules, and view all bookings.
    * **Moderators:** Elevated role capable of promoting users to Admin status and vice-versa.
* **Automated Refunds:** When an Admin cancels a trip, the system uses a **SQL Transaction** to mark the trip as 'Cancelled' and all associated tickets are considered refunded simultaneously.

## System Architecture
The project follows a **Layered Architecture** to ensure separation of concerns and maintainability:
* **UI Layer (WinForms):** All forms (Login, Dashboards, Payments) handle user interaction and input validation.
* **Service Layer:** Contains the core business logic (e.g., `TicketService.cs`, `AuthenticationService.cs`). This layer communicates between the UI and the Database.
* **Data Layer (`DatabaseService.cs`):** Manages the SQL Server connections and ADO.NET command execution.
* **Models:** Classes like `Bus.cs`, `Trip.cs`, and `User.cs` that represent our database entities as objects.

## Security Features
* **Payment Session Timeout:** To prevent unauthorized access, the `PaymentForm` includes a **30-second inactivity timer**. If no action is taken, the session expires and the user is redirected.
* **Global Session Management:** The `Session.cs` class maintains the `CurrentUser` state across the entire application, ensuring data persistence between forms.

## Database Schema
The database (`CatanBusDB`) consists of 5 relational tables:
1.  **Users:** Stores credentials and role flags (`IsAdmin`, `IsModerator`).
2.  **Bus:** Stores vehicle details and real-time `SeatsAvailable` tracking.
3.  **Trip:** Links buses to specific routes, prices, and status.
4.  **Ticket:** Records individual user bookings and seat counts.
5.  **Payment:** Logs transaction amounts and statuses linked to UserIDs.

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

## Troubleshooting
### Build Error MSB3821 (Mark of the Web)
If you get an error saying "Couldn't process file... due to its being in the Internet or Restricted zone," follow these steps:

1. Close Visual Studio.
2. Navigate to the project folder on your Desktop.
3. Open the 'bus-timetable-ticketing-master' folder on your desktop.
4. Go into the BST folder, then the Forms folder.
5. Right-click on 'UserDashboardForm.resx'.
4. Select **Properties**.
5. On the **General** tab, look for a **Security** section at the bottom.
6. Check the **Unblock** box and click **OK**.

## Unit Tests

Open Test Explorer and run all MSTest tests.

Total tests: ~20

## 🚀 Future Roadmap
- [ ] **Password Hashing:** Move from plain-text storage to BCrypt for user security.
- [ ] **Graphical Seat Map:** Allow users to pick specific seats on a visual bus layout.
- [ ] **Email Notifications:** Integrate an SMTP service to send ticket confirmations via email.
- [ ] **Export to PDF:** Generate and download a printable bus ticket after a successful payment.
