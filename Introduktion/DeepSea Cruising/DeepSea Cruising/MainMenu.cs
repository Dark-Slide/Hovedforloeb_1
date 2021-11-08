using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSea_Cruising
{
    
    public class UniversalData
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
    }

    internal class MainMenu
    {

       public MainMenu()
        {
            List<Cabins> CabinList = PopulateCabins(); // Populates the CabinList
            ShowCabins(CabinList); // Debug method shows all entries in CabinList

            List<Crew> CrewList = PopulateCrewList(); // Populates the CrewList
            ShowCrew(CrewList); // Debug method shows all entries in CrewList

            List<Passengers> PassengerList = PopulatePassengerList(); // Populates the PassengerList
            ShowPassengers(PassengerList); // Debug method shows all entries in PassengerList

            List<Cruises> CruisesList = PopulateCruises(); // Populates the CruisesList
            ShowCruises(CruisesList); // Debug method shows all entries in CruisesList



            Console.WriteLine("\t\t\t\t\t--- Welcome ---"); // Welcome Message

            while (true) // Main Menu Loop
            {
                Console.WriteLine("Would you like to register or login?\n\n1. Register.\n2. Login.\n3. Admin Login");

                switch (Parser()) // Main Menu Switch, calls the Parser Method which returns an int
                {
                    case 1: // Case 1, Register a new user/passenger
                        Console.Clear();
                        Passengers p = new Passengers();

                        Console.WriteLine("Please enter your Name:");
                        p.Name = Console.ReadLine().ToString();

                        Console.WriteLine("Please choose your Gender:\n1. Male\n2. Female\n 3.Disabled");
                        switch (Parser())
                        {
                            case 1:
                                p.Gender = GenderEnum.Male;
                                break;
                            case 2:
                                p.Gender = GenderEnum.Female;
                                break;
                            case 3:
                                p.Gender = GenderEnum.Disabled;
                                break;
                            default:
                                Console.WriteLine("Please select a valid gender:");
                                return;
                        }

                        Console.WriteLine("Please enter your Email:");
                        p.Email = Console.ReadLine().ToString();

                        Console.WriteLine("Please enter your Phone Number:");
                        p.Phone = Console.ReadLine().ToString();

                        Console.WriteLine("Please enter your Date of Birth yy/mm/dd");
                        p.DoB = Console.ReadLine().ToString();
                        break;
                    case 2: // Case 2, Login as a user/passenger
                        break;
                    case 3: // Case 3 Login as Admin
                        break;
                    default: // If no valid key is pressed
                        Console.WriteLine("That was not a valid item");
                        break;
                }
            }
        }

        void ShowCabins(List<Cabins> CabinList)
        {
            foreach (Cabins c in CabinList)
            {
                Console.WriteLine($"Cabin: {c.CabinNumber}, Class: {c.Cabin}");
            }
        }

        void ShowCrew(List<Crew> CrewList)
        {
            foreach (Crew c in CrewList)
            {
                Console.WriteLine($"ID: {c.ID}, Name: {c.Name}, Email: {c.Email}, Phone {c.Phone}, Work From: {c.WorkStart} to {c.WorkEnd}");
            }
        }
        
        void ShowPassengers(List<Passengers> PassengerList) 
        { 
            foreach (Passengers c in PassengerList)
            {
                Console.WriteLine($"ID: {c.ID}, Name: {c.Name}, Email: {c.Email}, Phone {c.Phone}");
            }
        }
        void ShowCruises(List<Cruises> CruisesList)
        {
            foreach (Cruises c in CruisesList)
            {
                Console.WriteLine($"Sails from: {c.Origin}, On Date: {c.Departure}, Sails To: {c.Destination}, On Date: {c.Arrival}");
            }
        }

        public int Parser() // Parser Method, asks for an input (ReadKey) and tryparses it, returning only if it clears.
        {
            int Input;

            do
            {
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out Input))
                {
                    return Input;
                }
                else
                {
                    Console.WriteLine("Please press a valid key to continue");
                }

            } while (true);
        }

        public List<Cabins> PopulateCabins()
        {
            List<Cabins> cabins = new List<Cabins>();
            int i = 1;
            for (; i < 21; i++)
            {
                cabins.Add(new Cabins { CabinNumber = i, Cabin = CabinType.FirstClass });
            }
            for (; i < 61; i++)
            {
                cabins.Add(new Cabins { CabinNumber = i, Cabin = CabinType.BusinessClass });
            }
            for (; i < 201; i++)
            {
                cabins.Add(new Cabins { CabinNumber = i, Cabin = CabinType.EconomyClass });
            }
            return cabins;
        } // NOT DONE!
        public List<Crew> PopulateCrewList()
        {
            List<Crew> crew = new List<Crew>();


            crew.Add(new Crew() { Email = "cptjack@company.com", Name = "Captain Jack Sparrow", ID = 0, Phone = "88888888", WorkStart = DateTime.AddHours(11), WorkEnd = new DateTime().AddHours(23), Role = CrewRole.Captain }); // Captains
            /*
            crew.Add(new Crew() { Email = "dick@company.com", Name = "Dick Winthers", ID = 1, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Captain });


            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 10, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor }); // Sailors
            crew.Add(new Crew() { Email = "jceasar@company.com", Name = "Gaius Julius Ceasar", ID = 11, WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "karl@company.com", Name = "Karl Marx", ID = 12, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "savior@company.com", Name = "Jesus", ID = 13, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "god@company.com", Name = "Morgan Freeman", ID = 14, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 15, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 16, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 17, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 18, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 19, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 20, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });


            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 100, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor }); // Engineers
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 101, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 102, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 103, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 104, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 105, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 106, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });


            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 200, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor }); // Cooks
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 201, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 202, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 203, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });


            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 300, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor }); // Waitors
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 301, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 302, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 303, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 304, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 305, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 306, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });
            crew.Add(new Crew() { Email = "charles@company.com", Name = "Charles Martel", ID = 307, Phone = "88888888", WorkStart = null, WorkEnd = null, Role = CrewRole.Sailor });

            */

            return crew;
        } // NOT DONE!
        public List<Passengers> PopulatePassengerList()
        {
            List<Passengers> passengers = new List<Passengers>();

            passengers.Add(new Passengers() { ID = 1000, Name = "Test Passenger", Email = "test@passenger.com", Gender = GenderEnum.Male, Phone = "00000000", Description = "TestPassenger", DoB = DateTime.Now, CreationDate = DateTime.Now });

            return passengers;
        } // NOT DONE!
        public List<Cruises> PopulateCruises()
        {
            List<Cruises> cruises = new List<Cruises>();

            cruises.Add(new Cruises() { CruiseID = 0, Origin = Locations.Stockholm, Destination = Locations.Copenhagen, Departure = new DateTime(2021, 10, 12), Arrival = new DateTime(2021, 15, 12) });
            cruises.Add(new Cruises() { CruiseID = 1, Origin = Locations.Copenhagen, Destination = Locations.London, Departure = new DateTime(2021, 18, 12), Arrival = new DateTime(2021, 23, 12) });

            return cruises;
        } // NOT DONE!
        public List<TicketClass> PopulateTickets() 
        {
            List<TicketClass> tickets = new List<TicketClass>();

            tickets.Add(new TicketClass() { });

            return tickets;
        } // NOT DONE!
    }
}
