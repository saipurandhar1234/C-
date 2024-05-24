using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Example search query
        string searchQuery = "Which are the resumes contains \"JAVA\" skill";

        // Extract the keyword "JAVA" from the search query
        string keyword = ExtractKeyword(searchQuery);

        // Display the extracted keyword
        if (keyword != null)
        {
            Console.WriteLine("Extracted keyword: " + keyword);
        }
        else
        {
            Console.WriteLine("Keyword not found in the search query.");
        }
    }

    static string ExtractKeyword(string searchQuery)
    {
        // Define the keyword to search for
        string keyword = "JAVA";

        // Use regular expression to find the keyword in the search query
        Regex regex = new Regex(@"\b" + keyword + @"\b", RegexOptions.IgnoreCase);
        Match match = regex.Match(searchQuery);

        // Return the keyword if found, otherwise return null
        return match.Success ? match.Value : null;
    }
}
