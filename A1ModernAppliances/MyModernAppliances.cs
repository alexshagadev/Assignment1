// Group: Alexandr Shagabutdinov, Rajat Sharma, Harshdeep Singh, Jeffrey McLaughlin
// This project provides the user with a menu to find information about appliances.
// 2024-02-11

using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances {
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout() {
            // Alexandr Shagabutdinov 

            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            itemNumber = Convert.ToInt64(userInput);

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance foundAppliance;
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;


            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)
            foreach (Appliance appliance in Appliances) {
                if (appliance.ItemNumber == itemNumber) {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."

            if (foundAppliance == null) {
                Console.WriteLine("No appliances found with that item number.\n");
            }
            else {
                if (foundAppliance.IsAvailable) {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.\n");
                }
                else {
                    Console.WriteLine("The appliance is not available to be checked out.\n");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find() {
            // Alexandr Shagabutdinov
            // NOTE: there is one key difference between the output of this function and the output of the sample runs from the assignment PDF:
            // The difference is that, when entering "Tefal", you will get a battery voltage of 18 instead of "Low". 
            // The assignment sample run has "Low" where this output will have "18." This is an inconsistency between the project skeleton that was 
            // provided and the assignment itself, but the logic is still the exact same. Since we did not create the project skeleton and it 
            // was included in the assignment, I hope that we will not get any marks deducted for this. 

            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string enteredBrand;
            enteredBrand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances) {
                if (appliance.Brand == enteredBrand) {
                    found.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        public override void DisplayRefrigerators() {
            // Jeffrey McLaughlin
            // Write "Possible options:"

            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0- Any");
            // Write "2 - Double doors"
            Console.WriteLine("2- Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - three doors ");
            // Write "4 - Four doors"
            Console.WriteLine("4 - four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter the number of doors: ");
            // Create variable to hold entered number of doors
            string numDoors;

            // Get user input as string and assign to variable
            numDoors = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            int numDoorsint = Convert.ToInt32(numDoors);

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances) {
                if (appliance.Type == Appliance.ApplianceTypes.Refrigerator) {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numDoorsint == 0 || refrigerator.Doors == numDoorsint)
                        found.Add(appliance);

                }

            }
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        /// 
        public override void DisplayVacuums() {
            // Jeffrey McLaughlin
            // Write "Possible options:"

            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            // Test input is "0"
            if (userInput == "0") { grade = "Any"; }
            // Assign "Any" to grade
            // Test input is "1"
            else if (userInput == "1") { grade = "Residential"; }
            // Assign "Residential" to grade
            // Test input is "2"
            else if (userInput == "2") { grade = "Commercial"; }
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            else {
                Console.WriteLine("Invalid Option ");
                // Write "Invalid option."

                // Return to calling (previous) method
                // return;
                return;
            }
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any ");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");

            // Get user input as string

            string userInputVoltage = Console.ReadLine();
            // Create variable to hold voltage
            int voltage;

            // Test input is "0"
            if (userInputVoltage == "0") { voltage = 0; }
            // Assign 0 to voltage
            // Test input is "1"
            else if (userInputVoltage == "1") { voltage = 18; }
            // Assign 18 to voltage
            // Test input is "2"
            else if (userInputVoltage == "2") { voltage = 24; }
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            else {
                Console.WriteLine("Invalid option");
                return;
            }
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.

            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances) {
                // Check if current appliance is vacuum
                if (appliance.Type == Appliance.ApplianceTypes.Vacuum) {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum volta

                    if (grade == "Any" && voltage == 0 || grade == "Any" && voltage == vacuum.BatteryVoltage || vacuum.Grade == grade && voltage == 0 || grade == vacuum.Grade && voltage == vacuum.BatteryVoltage) {
                        // Add current appliance in list to found list
                        found.Add(appliance);

                    }


                }
            }
            DisplayAppliancesFromList(found, 0);
        }

        public override void DisplayMicrowaves() {
            // Harshdeep Singh
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("Possible options:");

            Console.WriteLine("0 - Any");

            Console.WriteLine("1 - Kitchen");

            Console.WriteLine("2 - Work site");

            Console.Write("Enter room type: ");

            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create character variable that holds room type
            char roomType;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;

            if (userInput == "0") {
                roomType = 'A';
            }
            else if (userInput == "1") {
                roomType = 'K';
            }
            else if (userInput == "2") {
                roomType = 'W';
            }
            else {
                Console.WriteLine("Invalid option.");
                DisplayMicrowaves();
                return;
            }

            // Create variable that holds list of 'found' appliances
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances) {
                if (appliance is Microwave) {
                    Microwave microwave = (Microwave)appliance;

                    if (roomType == 'A' || microwave.RoomType == roomType) {
                        found.Add(microwave);
                    }
                }
            }


            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers() {
            // Alexandr Shagabutdinov
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate): ");
            string soundRating = Console.ReadLine();
            // flag 
            bool any = soundRating == "Qt" || soundRating == "Qr" || soundRating == "Qu" || soundRating == "M";

            // Check for validity of user input.
            if (!any) {
                Console.WriteLine("Invalid option.");
                DisplayDishwashers();
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances and downcast matching appliances to Dishwasher, then verify the sound rating.
            foreach (Appliance appliance in Appliances) {
                if (appliance.Type == Appliance.ApplianceTypes.Dishwasher) {
                    Dishwasher current = (Dishwasher)appliance;

                    if (soundRating == current.SoundRating) {
                        found.Add(current);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList() {
            // Alexandr Shagabutdinov
            // According to the sample runs in the assignment PDF, this is all that needs to be done.
            // The project skeleton was once again inconsistent with the assignment. 

            // Get input.
            Console.WriteLine("Enter number of appliances: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Randomize appliance list and display to the user.
            List<Appliance> found = Appliances;
            found.Sort(new RandomComparer());
            DisplayAppliancesFromList(found, num);
        }
    }
}
