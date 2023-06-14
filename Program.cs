// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// ----------------------
Eruption? chileEruption = eruptions.FirstOrDefault(location => location.Location == "Chile");
if (chileEruption != null)
{
Console.WriteLine($"The first Chile eruption is:   {chileEruption.ToString()}");
}
// ----------------------
Eruption? hawaiianEruption = eruptions.FirstOrDefault(location => location.Location == "Hawaiian Is");
if (hawaiianEruption != null)
{
Console.WriteLine($"The first Hawaiian Is eruption is:   {hawaiianEruption.ToString()}");
}
else 
{
    Console.WriteLine("No Hawaiian Is eruption found.");
}
// ----------------------
Eruption? greenlandEruption = eruptions.FirstOrDefault(location => location.Location == "Greenland");
if (greenlandEruption != null)
{
Console.WriteLine($"The first Greenland eruption is:   {greenlandEruption.ToString()}");
}
else 
{
    Console.WriteLine("No Greenland eruption found.");
}
// ----------------------
Eruption? firstNewZealand = eruptions.FirstOrDefault(eruption => eruption.Year > 1900 && eruption.Location == "New Zealand");
if (firstNewZealand != null)
{
Console.WriteLine($"The first New Zealand eruption that is after 1900 is:   {firstNewZealand.ToString()}");
}
else 
{
    Console.WriteLine("No New Zealand eruption found.");
}
// ----------------------
IEnumerable<Eruption> elevationEruptions = eruptions.Where(eruption => eruption.ElevationInMeters > 2000);
PrintEach(elevationEruptions, "These are the eruptions that are over 2000m.");
// ----------------------
IEnumerable<Eruption> eruptionsWithL = eruptions.Where(eruption => eruption.Volcano.StartsWith("L"));
int count = eruptionsWithL.Count();
PrintEach(eruptionsWithL, "Eruptions where the volcano's name starts with the letter L.");
Console.WriteLine($"Number of eruptions found: {count}");
// ----------------------
int highestElevation = eruptions.Max(eruption => eruption.ElevationInMeters);
Console.WriteLine($"The highest elevation: {highestElevation}");
// ----------------------
Eruption? volcanoWithHighestElevation = eruptions.FirstOrDefault( eruption => eruption.ElevationInMeters == highestElevation);
if (volcanoWithHighestElevation != null)
{
    Console.WriteLine($"Volcano with the highest elevation ({highestElevation} meters) is: {volcanoWithHighestElevation.Volcano}");
}
else 
{
    Console.WriteLine("Volcano not found. ");
}
// ----------------------
IEnumerable<string> namesOfVolcanos = eruptions.Select(eruption => eruption.Volcano).OrderBy(name => name);
Console.WriteLine("Volcano names alphabetically:");
foreach (string nameOfVolcano in namesOfVolcanos)
{
    Console.WriteLine(nameOfVolcano);
}
// ----------------------
int sumOfElevations = eruptions.Sum(eruptions => eruptions.ElevationInMeters);
Console.WriteLine($"The sum of all elevations is: {sumOfElevations}");
// ----------------------
bool anyEruption2000 = eruptions.Any(eruptions => eruptions.Year == 2000);
if (anyEruption2000)
{
    Console.WriteLine("Some volcano erupted in 2000");
}
else 
{
    Console.WriteLine("Everyone was spared in the year 2000. No eruptions found.");
}
// ----------------------
IEnumerable<Eruption> stratovolcanos = eruptions.Where(eruption => eruption.Type == "Stratovolcano").Take(3);
PrintEach(stratovolcanos, "The first three Stratovolcanos are: ");
// ----------------------
IEnumerable<Eruption> eruptionsBefore1000 = eruptions.Where(eruption => eruption.Year < 1000).OrderBy(eruption => eruption.Volcano);
PrintEach(eruptionsBefore1000, "Eruptions before the year 1000. (Alphabetically by volcano name)");
// ----------------------
IEnumerable<string> volcanoNames1000 = eruptions.Where(eruption => eruption.Year < 1000).OrderBy(eruption => eruption.Volcano).Select(eruption => eruption.Volcano);
Console.WriteLine("Names of volcanos before the year 1000:");
foreach (string volcanoName in volcanoNames1000)
{
    Console.WriteLine(volcanoName);
}
// ----------------------

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
