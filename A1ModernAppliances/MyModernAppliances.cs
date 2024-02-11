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
            // Write "Enter the item number of an appliance: "

            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber;


            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            itemNumber = Convert.ToInt64(Console.ReadLine());

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance;
            foundAppliance = null;

            // Loop through Appliances

            foreach (Appliance appliance in Appliances)
            {
                
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliance with that number was found");

            }
                else if (foundAppliance.IsAvailable)
                    {
                        foundAppliance.Checkout();
                        Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out");
                    }

                    else
                    {
                        Console.WriteLine("The item is not available to be checked out");
                    }
                
            }
        

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
        

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"

            Console.WriteLine("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string EnteredBrand;
            EnteredBrand = Console.ReadLine();


            

            // Create list to hold found Appliance objects

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand == EnteredBrand)
                {
                    found.Add(appliance);
                }
            }

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list


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
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                {
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
        public override void DisplayVacuums()
        {

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
            else
            {
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
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.

            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance.Type == Appliance.ApplianceTypes.Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum volta

                    if (grade == "Any" || vacuum.Grade == grade && voltage == 0 || voltage == vacuum.BatteryVoltage)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                        
                    }


                }
            }
            DisplayAppliancesFromList(found, 0);
        }
                    // Display found appliances
                    // DisplayAppliancesFromList(found, 0);
    
                



        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");


            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");

            // Get user input as string and assign to variable
            string roomType = Console.ReadLine();

            // Create character variable that holds room type
            char rmType;

            // Test input is "0"
            // Assign 'A' to room type variable
            if (roomType == "0")
            { rmType = 'A'; }
            // Test input is "1"
            // Assign 'K' to room type variable
            else if (roomType == "1")
            {
                rmType = 'K';
            }
            // Test input is "2"
            // Assign 'W' to room type variable
            else if (roomType == "2")
            {
                rmType = 'W';
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            
           



            // Create variable that holds list of 'found' appliances

            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance.Type == Appliance.ApplianceTypes.Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    
                    if (rmType == 'A' || microwave.RoomType == 'A')
                        found.Add(appliance);

                    else if (rmType == 'K' && microwave.RoomType == 'K')
                        found.Add(appliance);

                    else if (rmType == 'W' && microwave.RoomType == 'W')
                        found.Add(appliance);

                }

            }

            
            
            

            
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            Console.WriteLine("Possible Options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any ");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest ");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter ");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet ");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating: ");

            // Get user input as string and assign to variable
            string UserInput = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;
            // Test input is "0"
            if (UserInput == "0")
            // Assign "Any" to sound rating variable
            {
                soundRating = "Any";
                    }

            // Test input is "1"
            else if (UserInput == "1")
            // Assign "Qt" to sound rating variable
            {
                soundRating = "Qt";
            }
            // Test input is "2"
            else if (UserInput == "2")
            // Assign "Qr" to sound rating variable
            {
                soundRating = "Qr";
            }
            // Test input is "3"

            else if (UserInput == "3")
            // Assign "Qu" to sound rating variable
            {
                soundRating = "Qu";
            }
            // Test input is "4"
            else if (UserInput == "4")
            // Assign "M" to sound rating variable
            {
                soundRating = "M";
            }
            // Otherwise (input is something else)
            else

            // Write "Invalid option."
            {
                Console.WriteLine("Invalid option.");
                // Return to calling method
                { return; }
            }


            // Create variable that holds list of found appliances

            List<Appliance> found = new List<Appliance>();


            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Down cast current Appliance to Dishwasher
                if (appliance.Type == Appliance.ApplianceTypes.Dishwasher)
                {
                    // Down cast Appliance to Microwave
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                        // Add current appliance in list to found list
                        found.Add(appliance);


                }
                DisplayAppliancesFromList(found, 0);
            }

            
            
            

            
            

            // Display found appliances (up to max. number inputted)
            // 
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
