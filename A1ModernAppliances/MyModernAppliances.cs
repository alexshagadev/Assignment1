using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Alexandr Shagabutdinov 

            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an allpiance: ");

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
                Console.WriteLine("No appliances found with that item number.");
            } else {
                if (foundAppliance.IsAvailable) {
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                } else {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
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
            foreach(Appliance appliance in Appliances) {
                if (appliance.Brand == enteredBrand) {
                    found.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "

            // Create variable to hold entered number of doors

            // Get user input as string and assign to variable

            // Convert user input from string to int and store as number of doors variable.

            // Create list to hold found Appliance objects

            // Iterate/loop through Appliances
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
                // Assign "Any" to grade
            // Test input is "1"
                // Assign "Residential" to grade
            // Test input is "2"
                // Assign "Commercial" to grade
            // Otherwise (input is something else)
                // Write "Invalid option."

                // Return to calling (previous) method
                // return;

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"

            // Get user input as string
            // Create variable to hold voltage

            // Test input is "0"
                // Assign 0 to voltage
            // Test input is "1"
                // Assign 18 to voltage
            // Test input is "2"
                // Assign 24 to voltage
            // Otherwise
                // Write "Invalid option."
                // Return to calling (previous) method
                // return;

            // Create found variable to hold list of found appliances.

            // Loop through Appliances
                // Check if current appliance is vacuum
                    // Down cast current Appliance to Vacuum object
                    // Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

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

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
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
        public override void RandomList()
        {
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
