Project Overview
This C# program is a console-based application created for a travel agency. It allows users to manage travel itineraries by offering functionalities to view, add, and modify itineraries.

Key Features

Menu-Driven Interface: The application provides a straightforward menu interface, guiding users to view, add, or change itineraries easily.
Itinerary Management: Users can view all existing itineraries, create new ones by entering relevant travel details, and modify existing itineraries. The program calculates costs automatically and applies a change fee when an itinerary is modified.
Input Validation and Error Handling: The application includes strong validation and error handling to ensure data integrity and provide feedback when errors occur.
Techniques Used

Object-Oriented Programming (OOP): The program is structured around an Itinerary class, encapsulating properties and methods, and ensuring the integrity of itinerary data through encapsulation.
Static Properties: Constants like ChangeFee and TicketFee are defined as static properties within the Itinerary class, applicable across all itineraries.
Exception Handling: The program uses exception handling techniques to manage errors that occur during itinerary creation and modification, enhancing the application's robustness.
Validation Logic: The program includes extensive validation within the Itinerary class, ensuring correct user input and preventing logical errors (e.g., preventing duplicate city entries).
List Management: Itineraries are managed using a List collection, demonstrating effective handling of multiple items in C#.
Project Strengths

User-Friendly Interface: The console interface is designed for ease of use, making it simple for users to navigate and manage itineraries.
Robust Error Handling: The program is built to handle and report errors gracefully, ensuring a smooth user experience even in cases of incorrect input.
Well-Structured Code: The clear separation between the program's main logic and the Itinerary class promotes maintainability and clarity.
Comprehensive Validation: The validation logic ensures data integrity, preventing logical issues during itinerary management.
