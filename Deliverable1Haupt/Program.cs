//Set up variables for sandwich ingredients
int slices_per_loaf = 28;
int pb_per_jar = 32;
int jelly_per_jar = 48;

//Initialize do/while loop
var option = "yes";
do
{
    //Get User Input of Number of People
    Console.WriteLine("How many people are we making PB&J sandwiches for?");
    decimal number_of_people = int.Parse(Console.ReadLine());

    //Calculate Ingredient Need
    decimal slice_and_pb = number_of_people * 2;
    decimal jelly_tsp = number_of_people * 4;

    decimal loave = slice_and_pb / slices_per_loaf;
    decimal pb = slice_and_pb / pb_per_jar;
    decimal jelly = jelly_tsp / jelly_per_jar;

    decimal total_loaves = Math.Ceiling(loave);
    decimal total_pb = Math.Ceiling(pb);
    decimal total_jelly = Math.Ceiling(jelly);

    //Print results
    Console.WriteLine("You need: ");
    Console.WriteLine(slice_and_pb + " slices of bread");
    Console.WriteLine(slice_and_pb + " tablespoons of peanut butter");
    Console.WriteLine(jelly_tsp + " teaspoons of jelly");
    Console.WriteLine("Which is...");
    Console.WriteLine(total_loaves + " loaves of bread");
    Console.WriteLine(total_pb + " jars of peanut butter");
    Console.WriteLine(total_jelly + " jars of jelly");

    //Reset option variable to continue or exit loop
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    option = Console.ReadLine();
}
while (option == "yes" || option == "y");
Console.WriteLine("Goodbye!");
