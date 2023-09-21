
using System.Diagnostics;
using System.Text;

var naturalNumbers = Enumerable.Range(1, 1000).ToList();

var naturalString = string.Empty;

var stopWatch = new Stopwatch();

stopWatch.Start();
foreach (int number in naturalNumbers)
{
    if (number % 2 == 0)
    {
        naturalString = naturalString + $"{number} is even ";
    }
    else
    {
        naturalString = naturalString + $"{number} is odd ";
    }
}

stopWatch.Stop();

// Console.WriteLine(naturalString);
Console.WriteLine(stopWatch.ElapsedMilliseconds);

var naturalNumbers2 = Enumerable.Range(1, 1000).ToList();

var naturalStringBuilder = new StringBuilder();

stopWatch.Start();
foreach (int number in naturalNumbers2)
{
    if (number % 2 == 0)
    {
        naturalStringBuilder.Append($"{number} is even ");
    }
    else
    {
        naturalStringBuilder.Append($"{number} is odd ");
    }
}

stopWatch.Stop();

// Console.WriteLine(naturalStringBuilder);
Console.WriteLine(stopWatch.ElapsedMilliseconds);
