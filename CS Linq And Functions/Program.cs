// See https://aka.ms/new-console-template for more information

//CS linq challenge 1 part 1

int[] numbers = { 1, 2, 3, 4, 5 };

var evenNumbers = numbers.Where(number => number % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}
//CS linq challenge 1 part 2
List<int> studentGrades = new List<int> { 85, 90, 75, 88, 92 };
double averageGrade = studentGrades.Average();
Console.WriteLine($"\nAverage Grade: {averageGrade}");


// Bonus 1
var sortedGrades = studentGrades.OrderBy(grade => grade);
Console.WriteLine("\nSorted Grades:");
foreach (var grade in sortedGrades)
{
    Console.WriteLine(grade);
}

var groupedGrades = studentGrades.GroupBy(grade => grade >= 80 ? "Pass" : "Fail");
Console.WriteLine("\nGrouped Grades:");
foreach (var group in groupedGrades)
{
    Console.WriteLine($"Group: {group.Key}");
    foreach (var grade in group)
    {
        Console.WriteLine(grade);
    }
}







//CS linq challenge 2 part 1
    static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
GreetUser("Alice");



//CS linq challenge 2 part 2
static double CalculateBoxVolume(double length, double width, double height)
{
    double volume = length * width * height;
    return volume;
}

//bonus 2
double length = 5.0;
double width = 3.0;
double height = 4.0;

double volume = CalculateBoxVolume(length, width, height);
Console.WriteLine($"The volume of the box issss: {volume}");