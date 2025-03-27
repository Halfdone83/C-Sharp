using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<sep>[.\-\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})";


Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);


foreach (Match match in matches)

{

    Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value} ");
   
}
