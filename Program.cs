using System;
using System.Collections.Generic;

namespace TravelAgency
{
    internal class Program
    {
        // List to store itineraries
        private static List<Itinerary> itineraries = new List<Itinerary>();

        private static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Algonquin College Student Travel Agency!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Travel Agency Menu");
                Console.WriteLine("1. View all itineraries");
                Console.WriteLine("2. Add a new itinerary");
                Console.WriteLine("3. Change an existing itinerary");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter a choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewItineraries();
                        break;
                    case "2":
                        AddItinerary();
                        break;
                    case "3":
                        ChangeItinerary();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Algonquin College Student Travel Agency!");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4.");
                        break;
                }
            }
        }

        /*
         * GetResponse
         * Used to work with nullable strings from user response.
         * Will continue to prompt the user with an information request
         * Until the user provides a non-nullable value
         * @params: {string} information request
         * @returns: {string} user's response
         */
        static string GetResponse(string request)
        {
            string? response = null;

            while (string.IsNullOrWhiteSpace(response))
            {
                Console.Write(request);
                response = Console.ReadLine();
            }

            return response;
        }

        // Method to view all itineraries
       // Method to view all itineraries
      // Method to view all itineraries
static void ViewItineraries()
{
    if (itineraries.Count == 0)
    {
        Console.WriteLine("No itinerary exists in the system.");
    }
    else
    {
        for (int i = 0; i < itineraries.Count; i++)
        {
            var itinerary = itineraries[i];
            Console.WriteLine($"{i} - Passenger: {itinerary.PassengerName}, Departure: {itinerary.DepartureCity}, Arriving: {itinerary.ArrivalCity}, Cost: ${itinerary.Cost}");
        }
    }
}

        

        // Method to add a new itinerary
        static void AddItinerary()
        {
            try
            {
                string name = GetResponse("Enter passenger's name: ");
                string departureCity = GetResponse("Enter departure city: ");
                string arrivalCity = GetResponse("Enter arrival city: ");

                Itinerary newItinerary = new Itinerary(name, departureCity, arrivalCity);
                itineraries.Add(newItinerary);

                Console.WriteLine($"Itinerary added with cost: ${newItinerary.Cost}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to change an existing itinerary
        static void ChangeItinerary()
        {
            if (itineraries.Count == 0)
            {
                Console.WriteLine("No itinerary exists in the system.");
                return;
            }

            Console.WriteLine($"Enter the index of the itinerary to change (0 to {itineraries.Count - 1}):");
            int index;
            while (!int.TryParse(GetResponse("Index: "), out index) || index < 0 || index >= itineraries.Count)
            {
                Console.WriteLine($"Invalid index. Enter a number between 0 and {itineraries.Count - 1}:");
            }

            Itinerary itineraryToChange = itineraries[index];

            try
            {
                Console.WriteLine($"Changing itinerary for: {itineraryToChange.PassengerName}");
                string newDepartureCity = GetResponse("Enter new departure city: ");
                string newArrivalCity = GetResponse("Enter new arrival city: ");

                itineraryToChange.ChangeItinerary(newDepartureCity, newArrivalCity);

                Console.WriteLine($"Itinerary changed with a fee of ${Itinerary.ChangeFee}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
