using System; // Import the base .NET system library

namespace ShippingQuoteApp // Define the container for our application
{
    class Program // Define the main class of the program
    {
        static void Main(string[] args) // The starting point where the code begins execution
        {
            // Requirement 1: Display the mandatory opening greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to provide the weight of their package
            Console.WriteLine("Please enter the package weight:");
            // Read user input and convert the text into a numerical double value
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            // Requirement: If weight is over 50, the shipment is rejected
            if (packageWeight > 50)
            {
                // Print the specific error message for heavy packages
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Exit the application immediately
                return;
            }

            // Request the horizontal dimension from the user
            Console.WriteLine("Please enter the package width:");
            // Store the width as a double for decimal support
            double packageWidth = Convert.ToDouble(Console.ReadLine());

            // Request the vertical dimension from the user
            Console.WriteLine("Please enter the package height:");
            // Store the height as a double
            double packageHeight = Convert.ToDouble(Console.ReadLine());

            // Request the depth dimension from the user
            Console.WriteLine("Please enter the package length:");
            // Store the length as a double
            double packageLength = Convert.ToDouble(Console.ReadLine());

            // Check if the combined dimensions (Width + Height + Length) exceed the limit of 50
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                // Print the specific error message for oversized packages
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Terminate the program execution
                return;
            }

            // Calculation logic: Multiply dimensions together, then by weight, then divide by 100
            double totalProduct = (packageHeight * packageWidth * packageLength) * packageWeight;
            // Finalize the quote by dividing the product by 100
            double shippingQuote = totalProduct / 100;

            // Requirement: Output the final dollar amount formatted to 2 decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");

            // Requirement: Final sign-off message
            Console.WriteLine("Thank you!");

            // Prevent the console from closing instantly so the user can see the result
            Console.ReadLine();
        }
    }
}
